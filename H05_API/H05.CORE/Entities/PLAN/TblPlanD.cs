using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using H05.CORE.Common;

namespace H05.CORE.Entities.PLAN
{
    [Table("EAM_PLAN_D")]
    public class TblPlanD : SoftDeleteEntity
    {
        [Key]
        [Column("PLITEM")]
        public string Plitem { get; set; } = null!;

        [Column("WARPL")]
        public string Warpl { get; set; } = null!;

        [Column("EQUNR")]
        public string? Equnr { get; set; }

        [Column("TPLNR")]
        public string? Tplnr { get; set; }

        [Column("CYCTYPE")]
        public string? Cyctype { get; set; }

        [Column("CYCUNIT")]
        public string? Cycunit { get; set; }

        [Column("CYCLE")]
        public float? Cycle { get; set; }

        [Column("MEASURE")]
        public string? Measure { get; set; }

        [Column("MEASVALUE")]
        public float? Measvalue { get; set; }

        [Column("PLNNR")]
        public string? Plnnr { get; set; }
    }
} 