using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IDocumentHistoryService : IGenericService<TblDocumentHistory, DocumentHistoryDto>
    {
    }
    
    public class DocumentHistoryService : GenericService<TblDocumentHistory, DocumentHistoryDto>, IDocumentHistoryService
    {
        public DocumentHistoryService(AppDbContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }
        
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblDocumentHistory.AsQueryable();
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