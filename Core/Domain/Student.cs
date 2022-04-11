using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Domain
{
    public class Student
    {
        public string FullName { get; } = null!;
        public string Group { get; } = null!;

        public Student(string fullName, string group)
        {
            FullName = fullName; // TODO: Add null or empty check.
            Group = group;
        }
    }
}
