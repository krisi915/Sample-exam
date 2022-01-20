using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample_exam.Entities
{

    public class Student : BaseEntity
    {
        public string FaculityNumber { get; set; }
        public string Major { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student() { }

    }
}
