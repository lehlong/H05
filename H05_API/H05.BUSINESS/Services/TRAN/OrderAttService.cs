using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos.TRAN;
using H05.CORE;
using H05.CORE.Entities.TRAN;

namespace H05.BUSINESS.Services.TRAN
{
    public interface IOrderAttService : IGenericService<TblTranOrderAtt, OrderAttDto>
    {
    }
    
    public class OrderAttService(AppDbContext dbContext, IMapper mapper) : GenericService<TblTranOrderAtt, OrderAttDto>(dbContext, mapper), IOrderAttService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblTranOrderAtt.AsQueryable();
                if (!string.IsNullOrWhiteSpace(filter.KeyWord))
                {
                    query = query.Where(x => x.Aufnr.Contains(filter.KeyWord) ||
                                      x.FileType.Contains(filter.KeyWord) ||
                                      x.Path.Contains(filter.KeyWord));
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