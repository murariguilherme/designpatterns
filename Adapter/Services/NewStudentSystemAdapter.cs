using Adapter.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Services
{
    public class NewStudentSystemAdapter : IStudentTarget
    {
        private StudentsLegacySystemService legacySystem => new StudentsLegacySystemService();
        public List<Student> GetStudents()
        {
            var legacyStudents = legacySystem.GetStudents();
            var students = new List<Student>();

            foreach (var legacyStudent in legacyStudents)
            {
                students.Add(LegacyStudentToStudent(legacyStudent));
            }

            return students;
        }

        public Student LegacyStudentToStudent(LegacyStudentSystem legacyStudent)
        {
            return new Student()
            {
                Active = (legacyStudent.Active == "true") ? true : false,
                Gender = (Gender)((legacyStudent.Gender.ToString() == "Male") ? 0 : 1),
                Name = legacyStudent.Name
            };
        }
    }
}
