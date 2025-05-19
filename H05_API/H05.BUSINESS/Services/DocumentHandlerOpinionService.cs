using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IDocumentHandlerOpinionService : IGenericService<TblDocumentHandlerOpinion, DocumentHandlerOpinionDto>
    {
    }
    public class DocumentHandlerOpinionService(AppDbContext dbContext, IMapper mapper) : GenericService<TblDocumentHandlerOpinion, DocumentHandlerOpinionDto>(dbContext, mapper), IDocumentHandlerOpinionService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblDocumentHandlerOpinion.AsQueryable();
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