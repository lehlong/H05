using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IPersonalPlanCommentService : IGenericService<TblPersonalPlanComment, PersonalPlanCommentDto>
    {
    }
    public class PersonalPlanCommentService(AppDbContext dbContext, IMapper mapper) : GenericService<TblPersonalPlanComment, PersonalPlanCommentDto>(dbContext, mapper), IPersonalPlanCommentService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblPersonalPlanComment.AsQueryable();
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