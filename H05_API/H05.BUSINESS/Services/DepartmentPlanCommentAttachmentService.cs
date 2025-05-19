using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IDepartmentPlanCommentAttachmentService : IGenericService<TblDepartmentPlanCommentAttachment, DepartmentPlanCommentAttachmentDto>
    {
    }
    public class DepartmentPlanCommentAttachmentService(AppDbContext dbContext, IMapper mapper) : GenericService<TblDepartmentPlanCommentAttachment, DepartmentPlanCommentAttachmentDto>(dbContext, mapper), IDepartmentPlanCommentAttachmentService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblDepartmentPlanCommentAttachment.AsQueryable();
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