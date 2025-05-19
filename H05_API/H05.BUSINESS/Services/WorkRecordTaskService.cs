using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IWorkRecordTaskService : IGenericService<TblWorkRecordTask, WorkRecordTaskDto>
    {
    }
    public class WorkRecordTaskService(AppDbContext dbContext, IMapper mapper) : GenericService<TblWorkRecordTask, WorkRecordTaskDto>(dbContext, mapper), IWorkRecordTaskService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblWorkRecordTask.AsQueryable();
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