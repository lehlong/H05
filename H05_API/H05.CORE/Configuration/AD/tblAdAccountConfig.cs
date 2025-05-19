using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using H05.CORE.Entities.AD;

namespace H05.CORE.Configuration.AD
{
    public class TblAdAccountConfig : IEntityTypeConfiguration<TblAdAccount>
    {
        public void Configure(EntityTypeBuilder<TblAdAccount> builder)
        {
            builder.HasMany(x => x.Account_AccountGroups)
                .WithOne(g => g.Account)
                .HasForeignKey(x => x.UserName)
                .OnDelete(DeleteBehavior.Cascade);

           
        }
    }
}
