using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IWorkRecordProgressLogService : IGenericService<TblWorkRecordProgressLog, WorkRecordProgressLogDto>
    {
    }
    public class WorkRecordProgressLogService(AppDbContext dbContext, IMapper mapper) : GenericService<TblWorkRecordProgressLog, WorkRecordProgressLogDto>(dbContext, mapper), IWorkRecordProgressLogService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblWorkRecordProgressLog.AsQueryable();
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