using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IDepartmentPlanCommentService : IGenericService<TblDepartmentPlanComment, DepartmentPlanCommentDto>
    {
    }
    public class DepartmentPlanCommentService(AppDbContext dbContext, IMapper mapper) : GenericService<TblDepartmentPlanComment, DepartmentPlanCommentDto>(dbContext, mapper), IDepartmentPlanCommentService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblDepartmentPlanComment.AsQueryable();
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