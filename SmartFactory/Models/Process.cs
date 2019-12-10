using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class Process
    {
        [Key]
        public int Num { get; set; }
        [StringLength(150)]
        public string title { get; set; }
        [Column(TypeName = "ntext")]
        public string content { get; set; }
        [StringLength(50)]
        public string pic1 { get; set; }
        [StringLength(50)]
        public string pic2 { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? wrtie_date { get; set; }
        [StringLength(50)]
        public string writer_name { get; set; }
        [StringLength(50)]
        public string gubun { get; set; }
    }
}
