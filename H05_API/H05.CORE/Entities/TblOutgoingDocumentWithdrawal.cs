using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("outgoing_document_withdrawals")]
    public class TblOutgoingDocumentWithdrawal : BaseEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        
        [Column("document_id")]
        public int? DocumentId { get; set; }
        
        [Column("withdrawn_document_id")]
        public int? WithdrawnDocumentId { get; set; }
        
        [Column("withdrawal_date")]
        public DateTimeOffset? WithdrawalDate { get; set; }
        
        [Column("withdrawal_reason")]
        public string? WithdrawalReason { get; set; }
        
        [Column("withdrawn_by")]
        public int? WithdrawnBy { get; set; }
    }
} 
