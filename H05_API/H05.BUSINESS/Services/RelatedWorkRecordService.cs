using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IRelatedWorkRecordService : IGenericService<TblRelatedWorkRecord, RelatedWorkRecordDto>
    {
    }
    public class RelatedWorkRecordService(AppDbContext dbContext, IMapper mapper) : GenericService<TblRelatedWorkRecord, RelatedWorkRecordDto>(dbContext, mapper), IRelatedWorkRecordService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblRelatedWorkRecord.AsQueryable();
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