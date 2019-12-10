using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class project_dir
    {
        public project_dir()
        {
            project_act = new HashSet<project_act>();
        }

        [Key]
        public int idx { get; set; }
        public int project_id { get; set; }
        [Required]
        [StringLength(100)]
        public string project_dir_title { get; set; }
        public int project_step { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime write_date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime start_date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime end_date { get; set; }
        public int state { get; set; }
        [Required]
        [StringLength(50)]
        public string maker_id { get; set; }

        [ForeignKey(nameof(maker_id))]
        [InverseProperty(nameof(user.project_dir))]
        public virtual user maker_ { get; set; }
        [ForeignKey(nameof(project_id))]
        [InverseProperty(nameof(project_main.project_dir))]
        public virtual project_main project_ { get; set; }
        [InverseProperty("project_dir_idxNavigation")]
        public virtual ICollection<project_act> project_act { get; set; }
    }
}
