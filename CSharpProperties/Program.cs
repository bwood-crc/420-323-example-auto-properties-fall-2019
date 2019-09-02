using System;

namespace CSharpProperties
{
    class Program
    {
        /// <summary>
        /// DEMO of automatic and semi-automatic getters and setters.
        /// Investigate the Student and Course classes for more detail.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            // Student
            Student s1 = new Student();
            s1.Id = 1;
            s1.FirstName = "Brendan";
            s1.LastName = "Wood";
            Console.WriteLine(s1);

            Console.WriteLine();

            // Course
            // Note use of "var".
            var c1 = new Course();
            c1.CourseCode = "420-322-LA";
            c1.CourseDescription = "Gaming";
            Console.WriteLine(c1);
        }
    }
}
