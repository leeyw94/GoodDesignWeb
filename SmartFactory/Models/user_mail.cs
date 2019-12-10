using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class user_mail
    {
        [Key]
        public int idx { get; set; }
        [StringLength(150)]
        public string user_email { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime rdate { get; set; }
        [StringLength(1)]
        public string use_yn { get; set; }
        [StringLength(150)]
        public string password { get; set; }
    }
}
