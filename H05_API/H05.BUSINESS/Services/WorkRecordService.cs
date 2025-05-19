using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IWorkRecordService : IGenericService<TblWorkRecord, WorkRecordDto>
    {
    }
    public class WorkRecordService(AppDbContext dbContext, IMapper mapper) : GenericService<TblWorkRecord, WorkRecordDto>(dbContext, mapper), IWorkRecordService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblWorkRecord.AsQueryable();
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