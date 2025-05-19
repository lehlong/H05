using AutoMapper;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos.AD;
using H05.CORE;
using H05.CORE.Entities.AD;
using Microsoft.EntityFrameworkCore;

namespace H05.BUSINESS.Services.AD
{
    public interface IAppVersionService : IGenericService<TblAdAppVersion, AppVersionDto>
    {
        Task<AppVersionDto> GetCurrentVersion();
    }
    public class AppVersionService(AppDbContext dbContext, IMapper mapper) : GenericService<TblAdAppVersion, AppVersionDto>(dbContext, mapper), IAppVersionService
    {
        public async Task<AppVersionDto> GetCurrentVersion()
        {
            var data = await _dbContext.TblAdAppVersion.OrderByDescending(x => x.VersionCode).FirstOrDefaultAsync();

            return _mapper.Map<AppVersionDto>(data);
        }
    }
}
