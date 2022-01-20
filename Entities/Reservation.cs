using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample_exam.Entities
{
    public class Reservation: BaseEntity
    {
        public string FullName { get; set; }
        public int TableSize { get; set; }
        public DateTime DateTime { get; set; }
        
         
        

    }
}
