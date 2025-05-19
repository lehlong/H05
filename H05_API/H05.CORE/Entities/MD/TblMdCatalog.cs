﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using H05.CORE.Common;

namespace H05.CORE.Entities.MD
{
    [Table("EAM_MD_CATALOG")]
    public class TblMdCatalog : SoftDeleteEntity
    {
        [Key]
        [Column("ID")]
        public string Id { get; set; }
        [Column("CATCODE")]
        public string? CatCode { get; set; }

        [Column("CATNAME")]
        public string? CatName { get; set; }

        [Column("CATTYPE")]
        public string? CatType { get; set; }

        [Column("CODE")]
        public string? Code { get; set; }

        [Column("CODE_DES")]
        public string? CodeDes { get; set; }

        [Column("STATUS")]
        public string? Status { get; set; }

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
    }
}
