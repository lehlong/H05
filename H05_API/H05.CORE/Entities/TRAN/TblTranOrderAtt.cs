using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using H05.CORE.Common;

namespace H05.CORE.Entities.TRAN
{
    [Table("EAM_TRAN_ORDER_ATT")]
    public class TblTranOrderAtt : SoftDeleteEntity
    {
        [Key]
        [Column("AUFNR")]
        public string Aufnr { get; set; } = null!;

        [Column("FILETYPE")]
        public string? FileType { get; set; }

        [Column("FILESIZE")]
        public int? FileSize { get; set; }

        [Column("PATH")]
        public string? Path { get; set; }
    }
}
