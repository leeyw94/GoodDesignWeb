using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class cal_memo
    {
        [Key]
        public int idx { get; set; }
        [Required]
        [StringLength(50)]
        public string company_id { get; set; }
        [Required]
        [StringLength(50)]
        public string department_id { get; set; }
        [StringLength(50)]
        public string user_id { get; set; }
        public string title { get; set; }
        [Column(TypeName = "ntext")]
        public string content { get; set; }
        [StringLength(50)]
        public string gubun_type { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime write_date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? end_date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? work_date { get; set; }
        public int project_idx { get; set; }
        [StringLength(1)]
        public string use_yn { get; set; }
        [StringLength(100)]
        public string file_sn { get; set; }

        [ForeignKey(nameof(project_idx))]
        [InverseProperty(nameof(project_main.cal_memo))]
        public virtual project_main project_idxNavigation { get; set; }
        [ForeignKey(nameof(user_id))]
        [InverseProperty(nameof(user.cal_memo))]
        public virtual user user_ { get; set; }
    }
}
