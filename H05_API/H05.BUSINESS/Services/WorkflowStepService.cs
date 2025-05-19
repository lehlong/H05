using AutoMapper;
using Common;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos;
using H05.CORE;
using H05.CORE.Entities;

namespace H05.BUSINESS.Services
{
    public interface IWorkflowStepService : IGenericService<TblWorkflowStep, WorkflowStepDto>
    {
    }
    public class WorkflowStepService(AppDbContext dbContext, IMapper mapper) : GenericService<TblWorkflowStep, WorkflowStepDto>(dbContext, mapper), IWorkflowStepService
    {
        public override async Task<PagedResponseDto> Search(BaseFilter filter)
        {
            try
            {
                var query = _dbContext.TblWorkflowStep.AsQueryable();
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