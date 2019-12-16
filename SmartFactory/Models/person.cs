using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class person
    {
        [Key]
        public int idx { get; set; }
        [StringLength(50)]
        public string user_name { get; set; }
        [StringLength(7)]
        public string user_id { get; set; }
        [StringLength(10)]
        public string user_sex { get; set; }
        [StringLength(20)]
        public string user_tel { get; set; }
        [StringLength(100)]
        public string user_addr { get; set; }
        public int company_idx { get; set; }
        public int department_idx { get; set; }
        public int code_position_idx { get; set; }
        [Column(TypeName = "date")]
        public DateTime work_start_date { get; set; }
        [Column(TypeName = "date")]
        public DateTime? work_end_date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime write_date { get; set; }
        public int work_state { get; set; }
        [StringLength(10)]
        public string work_grade { get; set; }
        [StringLength(100)]
        public string user_email { get; set; }
        [StringLength(50)]
        public string fileId { get; set; }
        [StringLength(10)]
        public string use_yn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime edit_date { get; set; }
        [Column(TypeName = "ntext")]
        public string info { get; set; }
    }
}
