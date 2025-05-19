using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IRelatedOutgoingDocumentService : IGenericService<TblRelatedOutgoingDocument, RelatedOutgoingDocumentDto>
    {
    }
    public class RelatedOutgoingDocumentService(AppDbContext dbContext, IMapper mapper) : GenericService<TblRelatedOutgoingDocument, RelatedOutgoingDocumentDto>(dbContext, mapper), IRelatedOutgoingDocumentService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblRelatedOutgoingDocument.AsQueryable();
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