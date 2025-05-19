using H05.CORE.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("EAM_MD_ACCOUNT_TYPE")]
    public class TblMdAccountType : BaseEntity
    {
        [Key]
        [Column("CODE")]
        public string Code { get; set; }
        
        [Column("NAME")]
        public string? Name { get; set; }
    }
}
