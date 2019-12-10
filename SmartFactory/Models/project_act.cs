using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class project_act
    {
        [Key]
        public int idx { get; set; }
        [Required]
        [StringLength(100)]
        public string project_sub_title { get; set; }
        public int project_dir_idx { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime write_date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime start_date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime end_date { get; set; }
        [Required]
        [StringLength(50)]
        public string maker_id { get; set; }
        public int set_time { get; set; }
        public int state_id { get; set; }
        public int work_per { get; set; }
        [StringLength(150)]
        public string memo { get; set; }
        [StringLength(50)]
        public string manager { get; set; }
        public int project_id { get; set; }

        [ForeignKey(nameof(maker_id))]
        [InverseProperty(nameof(user.project_actmaker_))]
        public virtual user maker_ { get; set; }
        [ForeignKey(nameof(manager))]
        [InverseProperty(nameof(user.project_actmanagerNavigation))]
        public virtual user managerNavigation { get; set; }
        [ForeignKey(nameof(project_id))]
        [InverseProperty(nameof(project_main.project_act))]
        public virtual project_main project_ { get; set; }
        [ForeignKey(nameof(project_dir_idx))]
        [InverseProperty(nameof(project_dir.project_act))]
        public virtual project_dir project_dir_idxNavigation { get; set; }
    }
}
