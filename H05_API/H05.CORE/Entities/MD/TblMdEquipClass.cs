﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using H05.CORE.Common;

namespace H05.CORE.Entities.MD
{
    [Table("EAM_MD_EQUIP_CLASS")]
    public class TblMdEquipClass : SoftDeleteEntity
    {
        [Key]
        [Column("EQUNR")]
        public string Equnr { get; set; } = null!;

        [Column("CLASS")]
        public string? Class { get; set; }

        [Column("ADATU")]
        public DateTime? Adatu { get; set; }

        [Column("VNAME")]
        public string? Vname { get; set; }

        [Column("VDATU")]
        public DateTime? Vdatu { get; set; }

        [Column("VONDT")]
        public DateTime? Vondt { get; set; }

        [Column("BISDT")]
        public DateTime? Bisdt { get; set; }

        // Các trường IS_ACTIVE, CREATE_BY, UPDATE_BY, CREATE_DATE, UPDATE_DATE,
        // IS_DELETED, DELETE_DATE, DELETE_BY được kế thừa từ SoftDeleteEntity
    }
}
