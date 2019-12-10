using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class file_list
    {
        [Key]
        public int idx { get; set; }
        public int? file_menu_id { get; set; }
        [Required]
        [StringLength(100)]
        public string file_idx { get; set; }
        [StringLength(250)]
        public string file_name { get; set; }
        [StringLength(250)]
        public string file_pre_name { get; set; }
        public int file_size { get; set; }
        public int hit { get; set; }
        [StringLength(50)]
        public string file_type { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime write_date { get; set; }

        [ForeignKey(nameof(file_menu_id))]
        [InverseProperty(nameof(file_menu.file_list))]
        public virtual file_menu file_menu_ { get; set; }
    }
}
