using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IIncomingDocumentsRoleProcessingService : IGenericService<TblIncomingDocumentsRoleProcessing, IncomingDocumentsRoleProcessingDto>
    {
    }
    public class IncomingDocumentsRoleProcessingService(AppDbContext dbContext, IMapper mapper) : GenericService<TblIncomingDocumentsRoleProcessing, IncomingDocumentsRoleProcessingDto>(dbContext, mapper), IIncomingDocumentsRoleProcessingService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblIncomingDocumentsRoleProcessing.AsQueryable();
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