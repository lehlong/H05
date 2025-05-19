using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IOutgoingDocumentInternalUnitRecipientService : IGenericService<TblOutgoingDocumentInternalUnitRecipient, OutgoingDocumentInternalUnitRecipientDto>
    {
    }
    public class OutgoingDocumentInternalUnitRecipientService(AppDbContext dbContext, IMapper mapper) : GenericService<TblOutgoingDocumentInternalUnitRecipient, OutgoingDocumentInternalUnitRecipientDto>(dbContext, mapper), IOutgoingDocumentInternalUnitRecipientService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblOutgoingDocumentInternalUnitRecipient.AsQueryable();
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