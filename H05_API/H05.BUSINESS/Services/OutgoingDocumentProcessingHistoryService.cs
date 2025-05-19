using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IOutgoingDocumentProcessingHistoryService : IGenericService<TblOutgoingDocumentProcessingHistory, OutgoingDocumentProcessingHistoryDto>
    {
    }
    public class OutgoingDocumentProcessingHistoryService(AppDbContext dbContext, IMapper mapper) : GenericService<TblOutgoingDocumentProcessingHistory, OutgoingDocumentProcessingHistoryDto>(dbContext, mapper), IOutgoingDocumentProcessingHistoryService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblOutgoingDocumentProcessingHistory.AsQueryable();
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