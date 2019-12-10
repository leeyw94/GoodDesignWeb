using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class Avoidance
    {
        [Key]
        public int idx { get; set; }
        [Required]
        [StringLength(1)]
        public string Collision { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime r_date { get; set; }
        [Required]
        [StringLength(50)]
        public string page_name { get; set; }
    }
}
