using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IDocumentTypeService : IGenericService<TblDocumentType, DocumentTypeDto>
    {
    }
    public class DocumentTypeService(AppDbContext dbContext, IMapper mapper) : GenericService<TblDocumentType, DocumentTypeDto>(dbContext, mapper), IDocumentTypeService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblDocumentType.AsQueryable();
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