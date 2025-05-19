using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IOutgoingDocumentExternalRecipientService : IGenericService<TblOutgoingDocumentExternalRecipient, OutgoingDocumentExternalRecipientDto>
    {
    }
    public class OutgoingDocumentExternalRecipientService(AppDbContext dbContext, IMapper mapper) : GenericService<TblOutgoingDocumentExternalRecipient, OutgoingDocumentExternalRecipientDto>(dbContext, mapper), IOutgoingDocumentExternalRecipientService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblOutgoingDocumentExternalRecipient.AsQueryable();
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