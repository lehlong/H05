using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using H05.CORE.Common;

namespace H05.CORE.Entities.MD
{
    [Table("EAM_MD_PLANT")]
    public class TblMdPlant : SoftDeleteEntity
    {
        [Key]
        [Column("IWERK")]
        public string Iwerk { get; set; } = null!;

        [Column("IWERK_TXT")]
        public string? IwerkTxt { get; set; }
    }
}
