﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H05.CORE.Common;

namespace H05.CORE.Entities.MD
{
    [Table("EAM_MD_PLGRP")]
    public class TblMdPlgrp : SoftDeleteEntity
    {
        [Key]
        [Column("INGRP")]
        public string Ingrp { get; set; } = null!;

        [Column("INGRP_TXT")]
        public string? IngrpTxt { get; set; }
    }
}
