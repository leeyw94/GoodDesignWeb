using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class material
    {
        [Key]
        public int idx { get; set; }
        [StringLength(50)]
        public string aName { get; set; }
        public int material_idx { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime writeDate { get; set; }
        [StringLength(4)]
        public string use_yn { get; set; }
        public int code_material_spec_idx { get; set; }

        [ForeignKey(nameof(code_material_spec_idx))]
        [InverseProperty(nameof(code_material_spec.material))]
        public virtual code_material_spec code_material_spec_idxNavigation { get; set; }
    }
}
