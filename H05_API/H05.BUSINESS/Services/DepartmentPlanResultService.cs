using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IDepartmentPlanResultService : IGenericService<TblDepartmentPlanResult, DepartmentPlanResultDto>
    {
    }
    public class DepartmentPlanResultService(AppDbContext dbContext, IMapper mapper) : GenericService<TblDepartmentPlanResult, DepartmentPlanResultDto>(dbContext, mapper), IDepartmentPlanResultService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblDepartmentPlanResult.AsQueryable();
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