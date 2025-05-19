using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using H05.CORE.Common;

namespace H05.CORE.Entities.MD
{
    [Table("EAM_MD_EQ_CAT")]
    public class TblMdEqCat : SoftDeleteEntity
    {
        [Key]
        [Column("EQTYP")]
        public string Eqtyp { get; set; } = null!;

        [Column("EQTYP_TXT")]
        public string? EqtypTxt { get; set; }
    }
}
