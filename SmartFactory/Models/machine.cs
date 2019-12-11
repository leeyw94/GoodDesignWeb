using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class machine
    {
        [Key]
        public int idx { get; set; }
        [StringLength(50)]
        public string mName { get; set; }
        public int company_idx { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime writeDate { get; set; }
        [StringLength(4)]
        public string use_yn { get; set; }
        public int code_machine_spec_idx { get; set; }
        [Column(TypeName = "ntext")]
        public string info { get; set; }

        [ForeignKey(nameof(code_machine_spec_idx))]
        [InverseProperty(nameof(code_machine_spec.machine))]
        public virtual code_machine_spec code_machine_spec_idxNavigation { get; set; }
        [ForeignKey(nameof(company_idx))]
        [InverseProperty(nameof(company.machine))]
        public virtual company company_idxNavigation { get; set; }
    }
}
