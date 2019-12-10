using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class code_position
    {
        public code_position()
        {
            user = new HashSet<user>();
        }

        [Key]
        public int code_id { get; set; }
        [Required]
        [StringLength(50)]
        public string code_name { get; set; }
        [Required]
        [StringLength(1)]
        public string use_yn { get; set; }
        public int index_order { get; set; }
        [StringLength(100)]
        public string gubun { get; set; }
        [StringLength(50)]
        public string code_name_en { get; set; }
        public int company_idx { get; set; }

        [ForeignKey(nameof(company_idx))]
        [InverseProperty(nameof(company.code_position))]
        public virtual company company_idxNavigation { get; set; }
        [InverseProperty("position_idxNavigation")]
        public virtual ICollection<user> user { get; set; }
    }
}
