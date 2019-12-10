using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class code_sample
    {
        public code_sample()
        {
            sample = new HashSet<sample>();
        }

        [Key]
        public int code_id { get; set; }
        [Required]
        [StringLength(50)]
        public string code_name { get; set; }
        [StringLength(50)]
        public string code_name_en { get; set; }
        [Required]
        [StringLength(1)]
        public string use_yn { get; set; }
        public int index_order { get; set; }
        [StringLength(100)]
        public string gubun { get; set; }

        [InverseProperty("code_sample_idxNavigation")]
        public virtual ICollection<sample> sample { get; set; }
    }
}
