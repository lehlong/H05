﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using H05.CORE.Common;

namespace H05.CORE.Entities.TRAN
{
    [Table("EAM_TRAN_ORDER_EQ")]
    public class TblTranOrderEq : SoftDeleteEntity
    {
        [Column("AUFNR")]
        public string? Aufnr { get; set; }

        [Key]
        [Column("EQUNR")]
        public string Equnr { get; set; } = null!;

        [Column("ANLNR")]
        public string? Anlnr { get; set; }

        [Column("ANLUN")]
        public string? Anlun { get; set; }

        [Column("DATAB")]
        public DateTime? Datab { get; set; }

        [Column("TIME_F")]
        public TimeSpan? TimeF { get; set; }

        [Column("DATBI")]
        public DateTime? Datbi { get; set; }

        [Column("TIME_T")]
        public TimeSpan? TimeT { get; set; }

        [Column("STATUS")]
        public string? Status { get; set; }

        [Column("STATUS_TB")]
        public string? StatusTb { get; set; }

        [Column("STATUS_TH")]
        public string? StatusTh { get; set; }

        [Column("NOTE")]
        public string? Note { get; set; }

        [Column("STAFF_PL")]
        public string? StaffPl { get; set; }

        [Column("STAFF_QL")]
        public string? StaffQl { get; set; }

        [Column("STAFF_TH")]
        public string? StaffTh { get; set; }

        [Column("STAFF_SD")]
        public string? StaffSd { get; set; }
    }
}
