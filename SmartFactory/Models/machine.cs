using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class machine
    {
        [Required]
        [StringLength(50)]
        public string company_id { get; set; }
        public int idx { get; set; }
        [Key]
        [StringLength(50)]
        public string machine_id { get; set; }
        [StringLength(150)]
        public string machine_name { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? write_date { get; set; }
        [StringLength(50)]
        public string writer_id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime edit_date { get; set; }
        [StringLength(1)]
        public string use_yn { get; set; }
    }
}
