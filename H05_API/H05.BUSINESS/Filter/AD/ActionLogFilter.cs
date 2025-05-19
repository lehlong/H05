﻿using Common;

namespace H05.BUSINESS.Filter.AD
{
    public class ActionLogFilter : BaseFilter
    {
        public DateTime? FromDate { get; set; }

        public DateTime? ToDate { get; set; }

        public int? StatusCode { get; set; }
    }
}
