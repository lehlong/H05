using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IMinistryWorkRecordHistoryService : IGenericService<TblMinistryWorkRecordHistory, MinistryWorkRecordHistoryDto>
    {
    }
    public class MinistryWorkRecordHistoryService(AppDbContext dbContext, IMapper mapper) : GenericService<TblMinistryWorkRecordHistory, MinistryWorkRecordHistoryDto>(dbContext, mapper), IMinistryWorkRecordHistoryService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblMinistryWorkRecordHistory.AsQueryable();
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