using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos.MD;
using H05.CORE;
using H05.CORE.Entities.MD;

namespace H05.BUSINESS.Services.MD
{
    public interface IEqCatService : IGenericService<TblMdEqCat, EqCatDto>
    {
    }
    public class EqCatService(AppDbContext dbContext, IMapper mapper) : GenericService<TblMdEqCat, EqCatDto>(dbContext, mapper), IEqCatService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblMdEqCat.AsQueryable();
                if (!string.IsNullOrWhiteSpace(filter.KeyWord))
                {
                    query = query.Where(x => x.Eqtyp.ToString().Contains(filter.KeyWord) || x.EqtypTxt.Contains(filter.KeyWord));
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
