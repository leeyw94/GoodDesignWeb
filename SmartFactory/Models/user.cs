using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class user
    {
        public user()
        {
            BoardRread = new HashSet<BoardRread>();
            New_work = new HashSet<New_work>();
            cal_memo = new HashSet<cal_memo>();
            calendar = new HashSet<calendar>();
            history = new HashSet<history>();
            my_work = new HashSet<my_work>();
            project_actmaker_ = new HashSet<project_act>();
            project_actmanagerNavigation = new HashSet<project_act>();
            project_dir = new HashSet<project_dir>();
        }

        [Key]
        [StringLength(50)]
        public string user_id { get; set; }
        [StringLength(50)]
        public string user_password { get; set; }
        public int idx { get; set; }
        public int company_idx { get; set; }
        public int department_idx { get; set; }
        [Required]
        [StringLength(50)]
        public string user_name { get; set; }
        public string user_auth { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime write_date { get; set; }
        [StringLength(1)]
        public string use_yn { get; set; }
        public int check_auth { get; set; }
        [StringLength(50)]
        public string user_tel { get; set; }
        [StringLength(50)]
        public string writer { get; set; }
        [StringLength(150)]
        public string user_email { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? con_date { get; set; }
        [StringLength(10)]
        public string main_bg_color { get; set; }
        [StringLength(150)]
        public string photo_profile { get; set; }
        public int alert_yn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime edit_date { get; set; }
        [StringLength(1)]
        public string manager_yn { get; set; }
        public int position_idx { get; set; }
        [StringLength(20)]
        public string language { get; set; }

        [ForeignKey(nameof(check_auth))]
        [InverseProperty(nameof(code_auth.user))]
        public virtual code_auth check_authNavigation { get; set; }
        [ForeignKey(nameof(company_idx))]
        [InverseProperty(nameof(company.user))]
        public virtual company company_idxNavigation { get; set; }
        [ForeignKey(nameof(department_idx))]
        [InverseProperty(nameof(department.user))]
        public virtual department department_idxNavigation { get; set; }
        [InverseProperty("user_")]
        public virtual ICollection<BoardRread> BoardRread { get; set; }
        [InverseProperty("user_")]
        public virtual ICollection<New_work> New_work { get; set; }
        [InverseProperty("user_")]
        public virtual ICollection<cal_memo> cal_memo { get; set; }
        [InverseProperty("user_")]
        public virtual ICollection<calendar> calendar { get; set; }
        [InverseProperty("user_")]
        public virtual ICollection<history> history { get; set; }
        [InverseProperty("user_")]
        public virtual ICollection<my_work> my_work { get; set; }
        [InverseProperty(nameof(project_act.maker_))]
        public virtual ICollection<project_act> project_actmaker_ { get; set; }
        [InverseProperty(nameof(project_act.managerNavigation))]
        public virtual ICollection<project_act> project_actmanagerNavigation { get; set; }
        [InverseProperty("maker_")]
        public virtual ICollection<project_dir> project_dir { get; set; }
    }
}
