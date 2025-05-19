using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IOutgoingDocumentReplacementService : IGenericService<TblOutgoingDocumentReplacement, OutgoingDocumentReplacementDto>
    {
    }
    public class OutgoingDocumentReplacementService(AppDbContext dbContext, IMapper mapper) : GenericService<TblOutgoingDocumentReplacement, OutgoingDocumentReplacementDto>(dbContext, mapper), IOutgoingDocumentReplacementService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblOutgoingDocumentReplacement.AsQueryable();
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