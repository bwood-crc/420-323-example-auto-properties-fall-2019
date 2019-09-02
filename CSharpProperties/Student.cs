using System;

namespace CSharpProperties
{
    class Student
    {
        /// <summary>
        /// Student ID.  Auto getters and setters.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Legal last name.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Legal first name.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Get details of the object as a string.
        /// </summary>
        /// <returns>Nicely formatted string, 2 lines.</returns>
        public override string ToString()
        {
            return(string.Format("ID: {0}\nName: {1}, {2}", this.Id, this.LastName, this.FirstName));
        }
    }
}
