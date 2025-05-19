using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Common
{
    public class ReferenceEntity : BaseEntity, IReferenceEntity
    {
        [Column("REFERENCE_ID")]
        public Guid? ReferenceId { get; set; } = Guid.NewGuid();
    }
}
