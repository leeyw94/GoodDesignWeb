using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class code_1
    {
        [Key]
        public int idx { get; set; }
        [StringLength(50)]
        public string code_name { get; set; }
        [StringLength(1)]
        public string use_yn { get; set; }
        public int index_order { get; set; }
        [StringLength(50)]
        public string code_name_ko { get; set; }
        [StringLength(10)]
        public string lan_type { get; set; }
        [StringLength(10)]
        public string gubun { get; set; }
    }
}
