using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Services
{
    public class ThirdPartyStudentSystem
    {
        private IStudentTarget _students;

        public ThirdPartyStudentSystem(IStudentTarget students)
        {
            _students = students;
        }

        public void ShowStudents()
        {
            _students.GetStudents().ForEach(s => Console.WriteLine($"{s.ToString()}"));
            
        }
    }
}
