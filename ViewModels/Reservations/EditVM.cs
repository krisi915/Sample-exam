using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sample_exam.ViewModels.Reservations
{
    public class EditVM
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int TableSize { get; set; }
        public string DateTime { get; set; }

    }
}
