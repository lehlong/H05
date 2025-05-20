using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.BUSINESS.Filter;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IIncomingDocumentService : IGenericService<TblIncomingDocument, IncomingDocumentDto,IncommingDocumentFilterDto>
    {
    }
    public class IncomingDocumentService(AppDbContext dbContext, IMapper mapper) : GenericService<TblIncomingDocument, IncomingDocumentDto,IncommingDocumentFilterDto>(dbContext, mapper), IIncomingDocumentService
    {
        public override async Task<PagedResponseDto> Search(Filter<IncommingDocumentFilterDto> filter)
        {
            try
            {
                var test = filter.DataFilter.DocumentBookId;
                var custom = filter.DataFilter.FieldCustom; 
                
                var query = _dbContext.TblIncomingDocument.AsQueryable();
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