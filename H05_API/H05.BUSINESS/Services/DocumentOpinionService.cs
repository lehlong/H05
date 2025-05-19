using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IDocumentOpinionService : IGenericService<TblDocumentOpinion, DocumentOpinionDto>
    {
    }
    public class DocumentOpinionService(AppDbContext dbContext, IMapper mapper) : GenericService<TblDocumentOpinion, DocumentOpinionDto>(dbContext, mapper), IDocumentOpinionService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblDocumentOpinion.AsQueryable();
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