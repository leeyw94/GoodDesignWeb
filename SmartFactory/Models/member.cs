using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class member
    {
        [Required]
        [StringLength(50)]
        public string user_id { get; set; }
        public int idx { get; set; }
        [Required]
        [StringLength(50)]
        public string company_id { get; set; }
        [Required]
        [StringLength(50)]
        public string department_id { get; set; }
        [Required]
        [StringLength(50)]
        public string user_name { get; set; }
        public string user_auth { get; set; }
        [Required]
        [StringLength(150)]
        public string department_name { get; set; }
        [StringLength(150)]
        public string department_auth { get; set; }
        [Required]
        [StringLength(150)]
        public string company_name { get; set; }
        [Required]
        [StringLength(50)]
        public string nationality { get; set; }
    }
}
