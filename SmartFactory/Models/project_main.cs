using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class project_main
    {
        public project_main()
        {
            New_work = new HashSet<New_work>();
            cal_memo = new HashSet<cal_memo>();
            calendar = new HashSet<calendar>();
            my_work = new HashSet<my_work>();
            project_act = new HashSet<project_act>();
            project_dir = new HashSet<project_dir>();
        }

        [Key]
        public int project_id { get; set; }
        [Required]
        [StringLength(50)]
        public string project_name { get; set; }
        public int company_idx { get; set; }
        public int department_idx { get; set; }
        [StringLength(50)]
        public string owner_id { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime start_date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime end_date { get; set; }
        public int state { get; set; }
        [StringLength(350)]
        public string memo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime write_date { get; set; }
        [StringLength(50)]
        public string writer { get; set; }
        [StringLength(1)]
        public string use_yn { get; set; }
        public int index_order { get; set; }
        public int code_project_state_idx { get; set; }
        [StringLength(100)]
        public string file_sn { get; set; }
        [StringLength(20)]
        public string mode_type { get; set; }

        [InverseProperty("project_")]
        public virtual ICollection<New_work> New_work { get; set; }
        [InverseProperty("project_idxNavigation")]
        public virtual ICollection<cal_memo> cal_memo { get; set; }
        [InverseProperty("project_idxNavigation")]
        public virtual ICollection<calendar> calendar { get; set; }
        [InverseProperty("project_")]
        public virtual ICollection<my_work> my_work { get; set; }
        [InverseProperty("project_")]
        public virtual ICollection<project_act> project_act { get; set; }
        [InverseProperty("project_")]
        public virtual ICollection<project_dir> project_dir { get; set; }
    }
}
