using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class code_main
    {
        [Key]
        public int idx { get; set; }
        [StringLength(4)]
        public string code_id { get; set; }
        [Required]
        [StringLength(350)]
        public string code_name { get; set; }
        [Required]
        [StringLength(1)]
        public string use_yn { get; set; }
        public int index_order { get; set; }
        [StringLength(1)]
        public string gubun { get; set; }
        public int? project_id { get; set; }
        [StringLength(150)]
        public string project_name { get; set; }
    }
}
