using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using H05.CORE.Entities.AD;

namespace H05.CORE.Configuration.AD
{
    public class TblAdAccountRefreshTokenConfig : IEntityTypeConfiguration<TblAdAccountRefreshToken>
    {
        public void Configure(EntityTypeBuilder<TblAdAccountRefreshToken> builder)
        {
            builder.HasOne(x => x.Account).WithMany(x => x.RefreshTokens).HasForeignKey(x => x.UserName).IsRequired();
        }
    }
}
