using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos.MD;
using H05.CORE;
using H05.CORE.Entities.MD;

namespace H05.BUSINESS.Services.MD
{
    public interface IPlantService : IGenericService<TblMdPlant, PlantDto>
    {
    }
    public class PlantService(AppDbContext dbContext, IMapper mapper) : GenericService<TblMdPlant, PlantDto>(dbContext, mapper), IPlantService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblMdPlant.AsQueryable();
                if (!string.IsNullOrWhiteSpace(filter.KeyWord))
                {
                    query = query.Where(x => x.Iwerk.ToString().Contains(filter.KeyWord) || x.IwerkTxt.Contains(filter.KeyWord));
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
    }
}
