using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class code_index
    {
        public code_index()
        {
            calendar = new HashSet<calendar>();
        }

        [Key]
        public int code_id { get; set; }
        [Required]
        [StringLength(350)]
        public string code_name { get; set; }
        [Required]
        [StringLength(1)]
        public string use_yn { get; set; }
        public int index_order { get; set; }
        [StringLength(10)]
        public string gubun { get; set; }

        [InverseProperty("code_index_idxNavigation")]
        public virtual ICollection<calendar> calendar { get; set; }
    }
}
