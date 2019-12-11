using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class code_product_spec
    {
        public code_product_spec()
        {
            Product = new HashSet<Product>();
        }

        [Key]
        public int code_id { get; set; }
        [Required]
        [StringLength(50)]
        public string code_name { get; set; }
        [StringLength(50)]
        public string code_name_en { get; set; }
        [Required]
        [StringLength(1)]
        public string use_yn { get; set; }
        public int index_order { get; set; }
        [StringLength(100)]
        public string gubun { get; set; }

        [InverseProperty("code_product_spec_idxNavigation")]
        public virtual ICollection<Product> Product { get; set; }
    }
}
