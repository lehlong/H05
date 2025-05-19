using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos.TRAN;
using H05.CORE;
using H05.CORE.Entities.TRAN;

namespace H05.BUSINESS.Services.TRAN
{
    public interface IOrderVtService : IGenericService<TblTranOrderVt, OrderVtDto>
    {
    }
    
    public class OrderVtService(AppDbContext dbContext, IMapper mapper) : GenericService<TblTranOrderVt, OrderVtDto>(dbContext, mapper), IOrderVtService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblTranOrderVt.AsQueryable();
                if (!string.IsNullOrWhiteSpace(filter.KeyWord))
                {
                    query = query.Where(x => x.Aufnr.Contains(filter.KeyWord) ||
                                     x.Matnr.Contains(filter.KeyWord) ||
                                     x.Maktx.Contains(filter.KeyWord) ||
                                     x.Category.Contains(filter.KeyWord) ||
                                     x.Category2.Contains(filter.KeyWord) ||
                                     x.Werks.Contains(filter.KeyWord));
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