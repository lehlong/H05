using H05.CORE.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities.MD
{
    [Table("EAM_MD_USAGE_STATUS")]
    public class TblMdUsageStatus : SoftDeleteEntity
    {
        [Key]
        [Column("CODE")]
        public string Code { get; set; } = null!;

        [Column("NAME")]
        public string? Name { get; set; }
    }
}
