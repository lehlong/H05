using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using H05.CORE.Entities.AD;

namespace H05.CORE.Configuration.AD
{
    public class TblAdMenuRightConfig : IEntityTypeConfiguration<TblAdMenuRight>
    {
        public void Configure(EntityTypeBuilder<TblAdMenuRight> builder)
        {
            builder.HasKey(x => new { x.MenuId, x.RightId });
        }
    }
}
