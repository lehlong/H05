using H05.CORE.Common;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities.AD
{
    [Table("EAM_AD_ACCOUNT_ACCOUNTGROUP")]
    public class TblAdAccount_AccountGroup : BaseEntity
    {
        [Key]
        [Column("USER_NAME")]
        public string UserName { get; set; } = null!;

        [Key]
        [Column("GROUP_ID")]
        public Guid GroupId { get; set; }

        
        public virtual TblAdAccount? Account { get; set; }

        public virtual TblAdAccountGroup? AccountGroup { get; set; }
    }
}
