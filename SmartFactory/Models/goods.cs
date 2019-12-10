using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class goods
    {
        [Key]
        public int id { get; set; }
        [StringLength(150)]
        public string goodsName { get; set; }
        public int sellPrice { get; set; }
        public double sellPriceEn { get; set; }
        public int basicPrice { get; set; }
        public int discount { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime startDay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime endDay { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime distributionPeriod { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime manufacturingDate { get; set; }
        [StringLength(250)]
        public string goodsInfo { get; set; }
        [StringLength(250)]
        public string goodsAdvantage { get; set; }
        [StringLength(250)]
        public string goodsRecommendation { get; set; }
        [StringLength(250)]
        public string goodsMainImage { get; set; }
        public int goodsImageId { get; set; }
        public int totalQuantity { get; set; }
        public int residualQuantity { get; set; }
        [StringLength(5)]
        public string soldOutYn { get; set; }
        [StringLength(5)]
        public string OpenYn { get; set; }
        [Column(TypeName = "ntext")]
        public string goodsMemo { get; set; }
        public string specialAgreement { get; set; }
        public int goodsTypeId { get; set; }
        [StringLength(10)]
        public string goodsLanguage { get; set; }
        public string admin_memo { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime rdate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? delDate { get; set; }
        [StringLength(5)]
        public string delYn { get; set; }
        [StringLength(250)]
        public string goodsMainImageSmall { get; set; }
        [StringLength(250)]
        public string goodsSubImage { get; set; }
        public int index_order { get; set; }
    }
}
