﻿using AutoMapper;
using H05.BUSINESS.Common;
using H05.BUSINESS.Dtos.AD;
using H05.BUSINESS.Filter.AD;
using H05.CORE;
using H05.CORE.Entities.AD;
using Common;

namespace H05.BUSINESS.Services.AD
{
    public interface IActionLogService : IGenericService<TblActionLog, ActionLogDto>
    {
        Task<PagedResponseDto> Search(ActionLogFilter filter);
    }

    public class ActionLogService(AppDbContext dbContext, IMapper mapper) : GenericService<TblActionLog, ActionLogDto>(dbContext, mapper), IActionLogService
    {
        public async Task<PagedResponseDto> Search(ActionLogFilter filter)
        {
            try
            {
                var query = _dbContext.TblActionLogs.AsQueryable();

                if (!string.IsNullOrWhiteSpace(filter.KeyWord))
                {
                    query = query.Where(x =>
                        x.UserName.Contains(filter.KeyWord) ||
                        x.ActionUrl.Contains(filter.KeyWord)
                    );
                }
                query = query.Where(x => filter.FromDate == null || (x.RequestTime.HasValue && x.RequestTime.Value >= filter.FromDate))
                               .Where(x => filter.ToDate == null || (x.RequestTime.HasValue && x.RequestTime.Value <= filter.ToDate))
                               .Where(x => filter.StatusCode == null || x.StatusCode == filter.StatusCode)
                               .OrderByDescending(x => x.RequestTime);

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
