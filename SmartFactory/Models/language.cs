﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class language
    {
        public int idx { get; set; }
        public string korea { get; set; }
        public string english { get; set; }
        [Key]
        [StringLength(50)]
        public string code_name { get; set; }
    }
}
