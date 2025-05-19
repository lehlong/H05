using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos.MD;
using H05.CORE;
using H05.CORE.Entities.MD;

namespace H05.BUSINESS.Services.MD
{
    public interface ICharService : IGenericService<TblMdChar, CharDto>
    {
        Task<byte[]> Export(BaseMdFilter filter);
    }
    
    public class CharService(AppDbContext dbContext, IMapper mapper) : GenericService<TblMdChar, CharDto>(dbContext, mapper), ICharService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblMdChar.AsQueryable();
                if (!string.IsNullOrWhiteSpace(filter.KeyWord))
                {
                    query = query.Where(x => x.Atnam.Contains(filter.KeyWord) || 
                                          x.Atbez.Contains(filter.KeyWord) ||
                                          x.Atfor.Contains(filter.KeyWord));
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
                var query = _dbContext.TblMdChar.AsQueryable();
                if (!string.IsNullOrWhiteSpace(filter.KeyWord))
                {
                    query = query.Where(x => x.Atnam.Contains(filter.KeyWord));
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