using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IStorageBoxService : IGenericService<TblStorageBox, StorageBoxDto>
    {
    }
    public class StorageBoxService(AppDbContext dbContext, IMapper mapper) : GenericService<TblStorageBox, StorageBoxDto>(dbContext, mapper), IStorageBoxService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblStorageBox.AsQueryable();
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