using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IWorkRecordTaskGroupService : IGenericService<TblWorkRecordTaskGroup, WorkRecordTaskGroupDto>
    {
    }
    public class WorkRecordTaskGroupService(AppDbContext dbContext, IMapper mapper) : GenericService<TblWorkRecordTaskGroup, WorkRecordTaskGroupDto>(dbContext, mapper), IWorkRecordTaskGroupService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblWorkRecordTaskGroup.AsQueryable();
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