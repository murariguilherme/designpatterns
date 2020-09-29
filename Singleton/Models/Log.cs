using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Models
{
    public class Log
    {
        public DateTime Date { get; set; }
        public string Message { get; set; }

        public Log(DateTime date, string message)
        {
            this.Date = date;
            this.Message = message;
        }

        public Log() { }

        public override string ToString()
        {
            return $"{this.Date.ToString()} - {this.Message}";
        }
    }
}
