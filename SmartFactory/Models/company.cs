using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class company
    {
        public company()
        {
            BoardMenu = new HashSet<BoardMenu>();
            code_position = new HashSet<code_position>();
            department = new HashSet<department>();
            user = new HashSet<user>();
        }

        [Key]
        public int idx { get; set; }
        [Required]
        [StringLength(50)]
        public string company_id { get; set; }
        [Required]
        [StringLength(150)]
        public string company_name { get; set; }
        [Required]
        [StringLength(50)]
        public string nationality { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime write_date { get; set; }
        [StringLength(1)]
        public string use_yn { get; set; }
        public int? index_order { get; set; }
        public int gubun_idx { get; set; }
        [StringLength(50)]
        public string saupja_number { get; set; }
        [StringLength(50)]
        public string ceo_name { get; set; }
        [StringLength(150)]
        public string juso { get; set; }
        [StringLength(50)]
        public string work_uptae { get; set; }
        [StringLength(50)]
        public string work_jongmok { get; set; }
        [StringLength(50)]
        public string file_id { get; set; }

        [ForeignKey(nameof(gubun_idx))]
        [InverseProperty(nameof(code_company.company))]
        public virtual code_company gubun_idxNavigation { get; set; }
        [InverseProperty("company_idxNavigation")]
        public virtual ICollection<BoardMenu> BoardMenu { get; set; }
        [InverseProperty("company_idxNavigation")]
        public virtual ICollection<code_position> code_position { get; set; }
        [InverseProperty("company_idxNavigation")]
        public virtual ICollection<department> department { get; set; }
        [InverseProperty("company_idxNavigation")]
        public virtual ICollection<user> user { get; set; }
    }
}
