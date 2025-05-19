using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IPersonalPlanCommentAttachmentService : IGenericService<TblPersonalPlanCommentAttachment, PersonalPlanCommentAttachmentDto>
    {
    }
    public class PersonalPlanCommentAttachmentService(AppDbContext dbContext, IMapper mapper) : GenericService<TblPersonalPlanCommentAttachment, PersonalPlanCommentAttachmentDto>(dbContext, mapper), IPersonalPlanCommentAttachmentService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblPersonalPlanCommentAttachment.AsQueryable();
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