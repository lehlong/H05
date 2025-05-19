using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("department_plans")]
    public class TblDepartmentPlan 
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("title")]
        public string? Title { get; set; }
        
        [Column("start_date")]
        public DateTime? StartDate { get; set; }
        
        [Column("end_date")]
        public DateTime? EndDate { get; set; }
        
        [Column("department_id")]
        public int? DepartmentId { get; set; }
        
        [Column("status")]
        public short? Status { get; set; }
        
        [Column("sender_id")]
        public int? SenderId { get; set; }
    }
} 
