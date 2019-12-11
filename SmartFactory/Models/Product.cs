using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class Product
    {
        [Key]
        public int idx { get; set; }
        [StringLength(50)]
        public string pName { get; set; }
        public int product_idx { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime writeDate { get; set; }
        [StringLength(4)]
        public string use_yn { get; set; }
        public int code_product_spec_idx { get; set; }

        [ForeignKey(nameof(code_product_spec_idx))]
        [InverseProperty(nameof(code_product_spec.Product))]
        public virtual code_product_spec code_product_spec_idxNavigation { get; set; }
    }
}
