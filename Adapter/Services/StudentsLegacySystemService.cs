using Adapter.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Services
{
    public class StudentsLegacySystemService
    {
        public LegacyStudentSystem[] GetStudents()
        {
            var students = new LegacyStudentSystem[6];
            
            students[0] = new LegacyStudentSystem() { Id = "1", Name = "Martin", Gender = "Male", Active = "true" };
            students[1] = new LegacyStudentSystem() { Id = "2", Name = "Polly", Gender = "Famale", Active = "false" };
            students[2] = new LegacyStudentSystem() { Id = "3", Name = "Michael", Gender = "Male", Active = "true" };
            students[3] = new LegacyStudentSystem() { Id = "4", Name = "Vanessa", Gender = "Famale", Active = "true" };
            students[4] = new LegacyStudentSystem() { Id = "5", Name = "Britney", Gender = "Famale", Active = "true" };
            students[5] = new LegacyStudentSystem() { Id = "6", Name = "Anthony", Gender = "Male", Active = "false" };

            return students;
        }
    }
}
