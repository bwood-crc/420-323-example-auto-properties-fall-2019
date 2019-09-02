using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpProperties
{
    class Course
    {


        /// <summary>
        /// Standard course description, optional.
        /// Uses fully auto getters and setters.
        /// </summary>
        public string CourseDescription { get; set; }

        private string courseCode;

        /// <summary>
        /// Sets/Gets the course code.  Must start with 420.
        /// Uses semi-auto getters and setters to implement validation.
        /// </summary>
        public string CourseCode {
            get { return this.courseCode; }
            set {
                if (!value.StartsWith("420")) { throw new Exception("Course codes must start with 420"); }
                this.courseCode = value;
            }
        }

        /// <summary>
        /// Displays information about this object.
        /// </summary>
        /// <returns>Nicely formatted info about this course.</returns>
        public string printCourseInfo()
        {
            return string.Format("{0}: {1}", this.CourseCode, this.CourseDescription);
        }
    }
}
