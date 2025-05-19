using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface ITaskTypeService : IGenericService<TblTaskType, TaskTypeDto>
    {
    }
    public class TaskTypeService(AppDbContext dbContext, IMapper mapper) : GenericService<TblTaskType, TaskTypeDto>(dbContext, mapper), ITaskTypeService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblTaskType.AsQueryable();
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