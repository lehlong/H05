using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IDepartmentPlanService : IGenericService<TblDepartmentPlan, DepartmentPlanDto>
    {
    }
    public class DepartmentPlanService(AppDbContext dbContext, IMapper mapper) : GenericService<TblDepartmentPlan, DepartmentPlanDto>(dbContext, mapper), IDepartmentPlanService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblDepartmentPlan.AsQueryable();
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