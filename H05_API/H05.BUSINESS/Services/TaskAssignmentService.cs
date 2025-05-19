using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface ITaskAssignmentService : IGenericService<TblTaskAssignment, TaskAssignmentDto>
    {
    }
    public class TaskAssignmentService(AppDbContext dbContext, IMapper mapper) : GenericService<TblTaskAssignment, TaskAssignmentDto>(dbContext, mapper), ITaskAssignmentService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblTaskAssignment.AsQueryable();
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