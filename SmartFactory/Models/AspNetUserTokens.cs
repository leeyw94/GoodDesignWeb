using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class AspNetUserTokens
    {
        [Required]
        [StringLength(450)]
        public string UserId { get; set; }
        [Required]
        [StringLength(128)]
        public string LoginProvider { get; set; }
        [Required]
        [StringLength(128)]
        public string Name { get; set; }
        public string Value { get; set; }
    }
}
