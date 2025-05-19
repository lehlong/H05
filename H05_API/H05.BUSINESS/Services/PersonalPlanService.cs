using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IPersonalPlanService : IGenericService<TblPersonalPlan, PersonalPlanDto>
    {
    }
    public class PersonalPlanService(AppDbContext dbContext, IMapper mapper) : GenericService<TblPersonalPlan, PersonalPlanDto>(dbContext, mapper), IPersonalPlanService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblPersonalPlan.AsQueryable();
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