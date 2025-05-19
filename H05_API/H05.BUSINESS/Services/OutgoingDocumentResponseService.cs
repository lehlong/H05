using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IOutgoingDocumentResponseService : IGenericService<TblOutgoingDocumentResponse, OutgoingDocumentResponseDto>
    {
    }
    public class OutgoingDocumentResponseService(AppDbContext dbContext, IMapper mapper) : GenericService<TblOutgoingDocumentResponse, OutgoingDocumentResponseDto>(dbContext, mapper), IOutgoingDocumentResponseService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblOutgoingDocumentResponse.AsQueryable();
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