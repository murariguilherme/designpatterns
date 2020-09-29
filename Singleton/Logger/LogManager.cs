using Singleton.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;

namespace Singleton.Logger
{
    public class LogManager
    {
        private static LogManager _logManager;
        private List<Log> _logger;
        private string _filePath => "log.txt";
        private LogManager()
        {
            if (!LogFileExistis(_filePath)) CreateLogFile(_filePath);
            _logger = GetLogListFromFile(_filePath);
        }
        public void AddLog(Log log)
        {            
            _logger.Add(log);
            WriteJsonLogFile(_filePath, log);
        }

        public List<Log> GetLogList()
        {
            return _logger;
        }

        private void WriteJsonLogFile(string path, Log log)
        {            
            var jsonContent = JsonSerializer.Serialize(log);
            if (_logger.Count > 1) jsonContent = $", {jsonContent}";
            File.AppendAllText(path, jsonContent);
        }

        private void CreateLogFile(string path)
        {
            File.CreateText(path).Close();
        }

        private List<Log> GetLogListFromFile(string path)
        {
            var jsonFileContent = File.ReadAllText(path);
            if (JsonContentIsEmpty(jsonFileContent)) 
            {
                _logger = new List<Log>();
                return _logger;
            }            
            return JsonSerializer.Deserialize<List<Log>>(FormatToJsonArray(jsonFileContent), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        private string FormatToJsonArray(string jsonContent)
        {
            return $"[{jsonContent}]";
        }

        private bool LogFileExistis(string path)
        {
            return File.Exists(path);
        }

        private bool JsonContentIsEmpty(string content)
        {            
            return string.IsNullOrEmpty(content);
        }

        public static LogManager GetInstance()
        {
            if (_logManager == null) _logManager = new LogManager();
            return _logManager;
        }
    }
}
