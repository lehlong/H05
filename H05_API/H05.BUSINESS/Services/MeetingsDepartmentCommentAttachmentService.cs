using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IMeetingsDepartmentCommentAttachmentService : IGenericService<TblMeetingsDepartmentCommentAttachment, MeetingsDepartmentCommentAttachmentDto>
    {
    }
    public class MeetingsDepartmentCommentAttachmentService(AppDbContext dbContext, IMapper mapper) : GenericService<TblMeetingsDepartmentCommentAttachment, MeetingsDepartmentCommentAttachmentDto>(dbContext, mapper), IMeetingsDepartmentCommentAttachmentService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblMeetingsDepartmentCommentAttachment.AsQueryable();
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