using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class calendar
    {
        [Key]
        public int idx { get; set; }
        public int company_idx { get; set; }
        public int department_idx { get; set; }
        public int project_idx { get; set; }
        [StringLength(50)]
        public string user_id { get; set; }
        public double work_hour { get; set; }
        public string title { get; set; }
        [StringLength(50)]
        public string gubun_type { get; set; }
        [StringLength(4)]
        public string use_yn { get; set; }
        [StringLength(100)]
        public string who { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime write_date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? edit_date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime start_date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime end_date { get; set; }
        public int code_work_idx { get; set; }
        [Column(TypeName = "ntext")]
        public string content { get; set; }
        [StringLength(2)]
        public string open_it { get; set; }
        [StringLength(300)]
        public string who_list { get; set; }
        public int code_index_idx { get; set; }
        [StringLength(100)]
        public string fileId { get; set; }

        [ForeignKey(nameof(code_index_idx))]
        [InverseProperty(nameof(code_index.calendar))]
        public virtual code_index code_index_idxNavigation { get; set; }
        [ForeignKey(nameof(company_idx))]
        [InverseProperty(nameof(company.calendar))]
        public virtual company company_idxNavigation { get; set; }
        [ForeignKey(nameof(department_idx))]
        [InverseProperty(nameof(department.calendar))]
        public virtual department department_idxNavigation { get; set; }
        [ForeignKey(nameof(project_idx))]
        [InverseProperty(nameof(project_main.calendar))]
        public virtual project_main project_idxNavigation { get; set; }
        [ForeignKey(nameof(user_id))]
        [InverseProperty(nameof(user.calendar))]
        public virtual user user_ { get; set; }
    }
}
