using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IOutgoingDocumentTaskService : IGenericService<TblOutgoingDocumentTask, OutgoingDocumentTaskDto>
    {
    }
    public class OutgoingDocumentTaskService(AppDbContext dbContext, IMapper mapper) : GenericService<TblOutgoingDocumentTask, OutgoingDocumentTaskDto>(dbContext, mapper), IOutgoingDocumentTaskService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblOutgoingDocumentTask.AsQueryable();
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