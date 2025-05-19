using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IDocumentNumberService : IGenericService<TblDocumentNumber, DocumentNumberDto>
    {
    }
    public class DocumentNumberService(AppDbContext dbContext, IMapper mapper) : GenericService<TblDocumentNumber, DocumentNumberDto>(dbContext, mapper), IDocumentNumberService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblDocumentNumber.AsQueryable();
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