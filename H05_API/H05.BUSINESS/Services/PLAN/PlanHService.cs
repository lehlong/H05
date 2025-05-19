using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos.MD;
using H05.BUSINESS.Dtos.PLAN;
using H05.CORE;
using H05.CORE.Entities.MD;
using H05.CORE.Entities.PLAN;

namespace H05.BUSINESS.Services.PLAN
{
    public interface IPlanHService : IGenericService<TblPlanH, PlanHDto>
    {
        Task<byte[]> Export(BaseMdFilter filter);
    }

    public class PlanHService(AppDbContext dbContext, IMapper mapper) : GenericService<TblPlanH, PlanHDto>(dbContext, mapper), IPlanHService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblPlanH.AsQueryable();
                if (!string.IsNullOrWhiteSpace(filter.KeyWord))
                {
                    query = query.Where(x => x.Warpl.Contains(filter.KeyWord));
                }
                if (filter.IsActive.HasValue)
                {
                    query = query.Where(x => x.IsActive == filter.IsActive);
                }
                return await Paging(query, filter);
            }
            catch (Exception ex)
            {
                Status = false;
                Exception = ex;
                return null;
            }
        }
        public async Task<byte[]> Export(BaseMdFilter filter)
        {
            try
            {
                var query = _dbContext.TblPlanH.AsQueryable();
                if (!string.IsNullOrWhiteSpace(filter.KeyWord))
                {
                    query = query.Where(x => x.Warpl.Contains(filter.KeyWord));
                }
                if (filter.IsActive.HasValue)
                {
                    query = query.Where(x => x.IsActive == filter.IsActive);
                }
                var data = await base.GetAllMd(query, filter);
                int i = 1;
                data.ForEach(x =>
                {
                    x.OrdinalNumber = i++;
                });
                return await ExportExtension.ExportToExcel(data);
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