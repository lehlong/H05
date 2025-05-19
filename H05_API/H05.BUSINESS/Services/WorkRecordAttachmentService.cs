using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IWorkRecordAttachmentService : IGenericService<TblWorkRecordAttachment, WorkRecordAttachmentDto>
    {
    }
    public class WorkRecordAttachmentService(AppDbContext dbContext, IMapper mapper) : GenericService<TblWorkRecordAttachment, WorkRecordAttachmentDto>(dbContext, mapper), IWorkRecordAttachmentService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblWorkRecordAttachment.AsQueryable();
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