using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class v_mywork_project
    {
        public int project_id { get; set; }
        [Required]
        [StringLength(50)]
        public string project_name { get; set; }
    }
}
