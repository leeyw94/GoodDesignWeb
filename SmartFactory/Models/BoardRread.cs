﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SmartFactory.Models
{
    public partial class BoardRread
    {
        [Key]
        public int idx { get; set; }
        [StringLength(50)]
        public string user_id { get; set; }
        [StringLength(50)]
        public string user_name { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime read_date { get; set; }
        public int board_idx { get; set; }

        [ForeignKey(nameof(board_idx))]
        [InverseProperty(nameof(BoardList.BoardRread))]
        public virtual BoardList board_idxNavigation { get; set; }
        [ForeignKey(nameof(user_id))]
        [InverseProperty(nameof(user.BoardRread))]
        public virtual user user_ { get; set; }
    }
}
