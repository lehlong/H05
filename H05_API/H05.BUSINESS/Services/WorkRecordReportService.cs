using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IWorkRecordReportService : IGenericService<TblWorkRecordReport, WorkRecordReportDto>
    {
    }
    public class WorkRecordReportService(AppDbContext dbContext, IMapper mapper) : GenericService<TblWorkRecordReport, WorkRecordReportDto>(dbContext, mapper), IWorkRecordReportService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblWorkRecordReport.AsQueryable();
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