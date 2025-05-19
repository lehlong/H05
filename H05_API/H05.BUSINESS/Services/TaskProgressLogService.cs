using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface ITaskProgressLogService : IGenericService<TblTaskProgressLog, TaskProgressLogDto>
    {
    }
    public class TaskProgressLogService(AppDbContext dbContext, IMapper mapper) : GenericService<TblTaskProgressLog, TaskProgressLogDto>(dbContext, mapper), ITaskProgressLogService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblTaskProgressLog.AsQueryable();
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