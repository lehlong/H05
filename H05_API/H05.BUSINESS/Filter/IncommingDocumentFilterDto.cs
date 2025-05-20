using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common;
using H05.BUSINESS.Dtos;

namespace H05.BUSINESS.Filter
{
    public class IncommingDocumentFilterDto : IncomingDocumentDto
    {
        public string FieldCustom { get; set; }
    }
}
