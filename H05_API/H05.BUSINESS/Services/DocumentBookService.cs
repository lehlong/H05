using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IDocumentBookService : IGenericService<TblDocumentBook, DocumentBookDto>
    {
    }
    public class DocumentBookService(AppDbContext dbContext, IMapper mapper) : GenericService<TblDocumentBook, DocumentBookDto>(dbContext, mapper), IDocumentBookService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblDocumentBook.AsQueryable();
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