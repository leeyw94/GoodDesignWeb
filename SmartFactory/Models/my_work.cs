using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class my_work
    {
        [Key]
        public int idx { get; set; }
        [StringLength(50)]
        public string user_id { get; set; }
        public int work_time { get; set; }
        public string title { get; set; }
        [StringLength(100)]
        public string use_yn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime write_date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? edit_date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime work_date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime end_date { get; set; }
        public int state { get; set; }
        [Column(TypeName = "ntext")]
        public string content { get; set; }
        public int project_id { get; set; }
        [StringLength(2)]
        public string open_it { get; set; }
        [StringLength(100)]
        public string file_sn { get; set; }

        [ForeignKey(nameof(project_id))]
        [InverseProperty(nameof(project_main.my_work))]
        public virtual project_main project_ { get; set; }
        [ForeignKey(nameof(user_id))]
        [InverseProperty(nameof(user.my_work))]
        public virtual user user_ { get; set; }
    }
}
