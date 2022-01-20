using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample_exam.ViewModels.Reservations
{
    public class CreateVM
    {
        public string FullName { get; set; }
        public int TableSize { get; set; }
        public DateTime DateTime { get; set; }
    }
}
