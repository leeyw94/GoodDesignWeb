using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class code_auth_ex
    {
        [Key]
        public int code_id { get; set; }
        [Required]
        [StringLength(100)]
        public string code_name { get; set; }
        [Required]
        [StringLength(1)]
        public string use_yn { get; set; }
        public int index_order { get; set; }
        [StringLength(150)]
        public string gubun { get; set; }
        [StringLength(150)]
        public string url { get; set; }
    }
}
