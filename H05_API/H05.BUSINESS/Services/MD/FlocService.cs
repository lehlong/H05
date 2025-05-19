using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos.MD;
using H05.CORE;
using H05.CORE.Entities.MD;

namespace H05.BUSINESS.Services.MD
{
    public interface IFlocService : IGenericService<TblMdFloc, FlocDto>
    {
    }
    public class FlocService(AppDbContext dbContext, IMapper mapper) : GenericService<TblMdFloc, FlocDto>(dbContext, mapper), IFlocService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblMdFloc.AsQueryable();
                if (!string.IsNullOrWhiteSpace(filter.KeyWord))
                {
                    query = query.Where(x => x.Tplnr.ToString().Contains(filter.KeyWord));
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
