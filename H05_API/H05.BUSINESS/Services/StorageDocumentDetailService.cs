using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IStorageDocumentDetailService : IGenericService<TblStorageDocumentDetail, StorageDocumentDetailDto>
    {
    }
    public class StorageDocumentDetailService(AppDbContext dbContext, IMapper mapper) : GenericService<TblStorageDocumentDetail, StorageDocumentDetailDto>(dbContext, mapper), IStorageDocumentDetailService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblStorageDocumentDetail.AsQueryable();
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