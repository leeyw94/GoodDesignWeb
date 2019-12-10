using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class file_menu
    {
        public file_menu()
        {
            file_list = new HashSet<file_list>();
        }

        [Key]
        public int file_menu_id { get; set; }
        [StringLength(50)]
        public string file_menu_name { get; set; }
        [StringLength(1)]
        public string use_yn { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? write_date { get; set; }

        [InverseProperty("file_menu_")]
        public virtual ICollection<file_list> file_list { get; set; }
    }
}
