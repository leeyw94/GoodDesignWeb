using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class member_list
    {
        [Key]
        public int idx { get; set; }
        [StringLength(100)]
        public string userEmail { get; set; }
        [StringLength(50)]
        public string userName { get; set; }
        [StringLength(80)]
        public string userPassword { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime rdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime edate { get; set; }
        public int gubunID { get; set; }
        public int userPoint { get; set; }
        public int userPointId { get; set; }
        public string memo { get; set; }
        public int nation_id { get; set; }
        public int classId { get; set; }
        public int useInfoId { get; set; }
    }
}
