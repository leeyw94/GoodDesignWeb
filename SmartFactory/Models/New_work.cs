using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class New_work
    {
        [Key]
        public int idx { get; set; }
        [Required]
        [StringLength(50)]
        public string user_id { get; set; }
        public int project_id { get; set; }
        public double spend_hour { get; set; }
        public TimeSpan? spend_time { get; set; }
        [Column(TypeName = "ntext")]
        public string memo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime write_date { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime edit_date { get; set; }

        [ForeignKey(nameof(project_id))]
        [InverseProperty(nameof(project_main.New_work))]
        public virtual project_main project_ { get; set; }
        [ForeignKey(nameof(user_id))]
        [InverseProperty(nameof(user.New_work))]
        public virtual user user_ { get; set; }
    }
}
