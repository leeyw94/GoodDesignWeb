using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class v_new_work
    {
        public int idx { get; set; }
        public int? project_id_name { get; set; }
        [Required]
        [StringLength(50)]
        public string project_name { get; set; }
        public int state { get; set; }
        public int Expr1 { get; set; }
        public double spend_hour { get; set; }
        [Column(TypeName = "ntext")]
        public string memo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime edit_date { get; set; }
    }
}
