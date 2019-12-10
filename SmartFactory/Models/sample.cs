using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class sample
    {
        [Key]
        public int idx { get; set; }
        [StringLength(150)]
        public string title { get; set; }
        [StringLength(150)]
        public string userName { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime writeDate { get; set; }
        public int code_sample_idx { get; set; }

        [ForeignKey(nameof(code_sample_idx))]
        [InverseProperty(nameof(code_sample.sample))]
        public virtual code_sample code_sample_idxNavigation { get; set; }
    }
}
