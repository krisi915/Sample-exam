﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sample_exam.Entities

{
   public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
    }
}


