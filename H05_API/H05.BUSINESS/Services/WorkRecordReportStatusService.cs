using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IWorkRecordReportStatusService : IGenericService<TblWorkRecordReportStatus, WorkRecordReportStatusDto>
    {
    }
    public class WorkRecordReportStatusService(AppDbContext dbContext, IMapper mapper) : GenericService<TblWorkRecordReportStatus, WorkRecordReportStatusDto>(dbContext, mapper), IWorkRecordReportStatusService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblWorkRecordReportStatus.AsQueryable();
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