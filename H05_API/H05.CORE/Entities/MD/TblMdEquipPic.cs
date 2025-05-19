using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using H05.CORE.Common;

namespace H05.CORE.Entities.MD
{
    [Table("EAM_MD_EQUIP_PIC")]
    public class TblMdEquipPic : SoftDeleteEntity
    {
        [Key]
        [Column("ID")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        [Column("EQUNR")]
        public string Equnr { get; set; } = null!;

        [Column("FILETYPE")]
        public string? Filetype { get; set; }

        [Column("FILESIZE")]
        public int? Filesize { get; set; }
        [Column("FILENAME")]
        public string? Filename { get; set; }

        [Column("PATH")]
        public string? Path { get; set; }
    }
}
