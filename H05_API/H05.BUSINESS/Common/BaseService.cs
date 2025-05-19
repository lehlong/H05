﻿using H05.CORE;
using AutoMapper;
using Common;

namespace H05.BUSINESS.Common
{
    public class BaseService(AppDbContext dbContext, IMapper mapper) : IBaseService
    {
        public AppDbContext _dbContext = dbContext;
        public MessageObject MessageObject { get; set; } = new MessageObject();
        public Exception Exception { get; set; }
        public bool Status { get; set; } = true;
        public IMapper _mapper = mapper;
    }
}
