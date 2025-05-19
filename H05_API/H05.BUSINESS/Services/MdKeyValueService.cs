using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IMdKeyValueService : IGenericService<TblMdKeyValue, MdKeyValueDto>
    {
    }
    public class MdKeyValueService(AppDbContext dbContext, IMapper mapper) : GenericService<TblMdKeyValue, MdKeyValueDto>(dbContext, mapper), IMdKeyValueService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblMdKeyValue.AsQueryable();
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