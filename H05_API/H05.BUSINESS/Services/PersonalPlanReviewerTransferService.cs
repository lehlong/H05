using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IPersonalPlanReviewerTransferService : IGenericService<TblPersonalPlanReviewerTransfer, PersonalPlanReviewerTransferDto>
    {
    }
    public class PersonalPlanReviewerTransferService(AppDbContext dbContext, IMapper mapper) : GenericService<TblPersonalPlanReviewerTransfer, PersonalPlanReviewerTransferDto>(dbContext, mapper), IPersonalPlanReviewerTransferService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblPersonalPlanReviewerTransfer.AsQueryable();
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