using Adapter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Services
{
    public interface IStudentTarget
    {
        public List<Student> GetStudents();
    }
}
