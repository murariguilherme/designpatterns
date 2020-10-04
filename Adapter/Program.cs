using Adapter.Services;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            IStudentTarget studentTarget = new StudentSystemAdapter();
            var thirdParty = new ThirdPartyStudentSystem(studentTarget);
            thirdParty.ShowStudents();

            Console.ReadLine();
        }
    }
}
