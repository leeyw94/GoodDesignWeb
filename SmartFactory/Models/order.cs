using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class order
    {
        [Key]
        public int idx { get; set; }
        public int company_idx { get; set; }
        public int project_idx { get; set; }
        [Required]
        [StringLength(50)]
        public string orderList { get; set; }
        public int orderQty { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime start_date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime end_date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime writeDate { get; set; }
        [StringLength(100)]
        public string who { get; set; }
        [StringLength(20)]
        public string contact { get; set; }
        [StringLength(4)]
        public string use_yn { get; set; }
        public int code_work_idx { get; set; }
        [StringLength(2)]
        public string open_it { get; set; }

        [ForeignKey(nameof(code_work_idx))]
        [InverseProperty(nameof(code_index.order))]
        public virtual code_index code_work_idxNavigation { get; set; }
        [ForeignKey(nameof(company_idx))]
        [InverseProperty(nameof(company.order))]
        public virtual company company_idxNavigation { get; set; }
    }
}
