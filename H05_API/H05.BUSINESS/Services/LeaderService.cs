using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface ILeaderService : IGenericService<TblLeader, LeaderDto>
    {
    }
    public class LeaderService(AppDbContext dbContext, IMapper mapper) : GenericService<TblLeader, LeaderDto>(dbContext, mapper), ILeaderService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblLeader.AsQueryable();
                return await Paging(query, filter);
            }
            catch (Exception ex)
            {
                Status = false;
                Exception = ex;
                return null;
            }
        }
    }
} 