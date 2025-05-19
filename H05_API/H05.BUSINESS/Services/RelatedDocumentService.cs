using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IRelatedDocumentService : IGenericService<TblRelatedDocument, RelatedDocumentDto>
    {
    }
    public class RelatedDocumentService(AppDbContext dbContext, IMapper mapper) : GenericService<TblRelatedDocument, RelatedDocumentDto>(dbContext, mapper), IRelatedDocumentService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblRelatedDocument.AsQueryable();
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