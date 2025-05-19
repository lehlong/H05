using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos.MD;
using H05.CORE;
using H05.CORE.Entities.MD;

namespace H05.BUSINESS.Services.MD
{
    public interface IAssetService : IGenericService<TblMdAsset, AssetDto>
    {
    }
    
    public class AssetService(AppDbContext dbContext, IMapper mapper) : GenericService<TblMdAsset, AssetDto>(dbContext, mapper), IAssetService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblMdAsset.AsQueryable();
                if (!string.IsNullOrWhiteSpace(filter.KeyWord))
                {
                    query = query.Where(x => x.Anln1.Contains(filter.KeyWord) || 
                                        x.Iwerk.Contains(filter.KeyWord) ||
                                        x.Txt50.Contains(filter.KeyWord) ||
                                        x.Liefe.Contains(filter.KeyWord) ||
                                        x.Herst.Contains(filter.KeyWord));
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