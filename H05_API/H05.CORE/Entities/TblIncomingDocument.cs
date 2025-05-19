using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("incoming_documents")]
    public class TblIncomingDocument : BaseEntity
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("document_book_id")]
        public int? DocumentBookId { get; set; }
        
        [Column("document_number_id")]
        public long? DocumentNumberId { get; set; }
        
        [Column("document_code")]
        public string? DocumentCode { get; set; }
        
        [Column("sender_department_id")]
        public int? SenderDepartmentId { get; set; }
        
        [Column("receiver_department_id")]
        public int? ReceiverDepartmentId { get; set; }
        
        [Column("document_date")]
        public DateTime? DocumentDate { get; set; }
        
        [Column("received_date")]
        public DateTime? ReceivedDate { get; set; }
        
        [Column("book_date")]
        public DateTime? BookDate { get; set; }
        
        [Column("response_deadline")]
        public DateTime? ResponseDeadline { get; set; }
        
        [Column("sub_number")]
        public string? SubNumber { get; set; }
        
        [Column("receive_method")]
        public int? ReceiveMethod { get; set; }
        
        [Column("security_level")]
        public int? SecurityLevel { get; set; }
        
        [Column("urgency_level")]
        public int? UrgencyLevel { get; set; }
        
        [Column("document_type")]
        public int? DocumentType { get; set; }
        
        [Column("field")]
        public int? Field { get; set; }
        
        [Column("signer")]
        public string? Signer { get; set; }
        
        [Column("summary")]
        public string? Summary { get; set; }
        
        [Column("status")]
        public int? Status { get; set; }
        
        [Column("created_at")]
        public DateTime? CreatedAt { get; set; }
        
        [Column("updated_at")]
        public DateTime? UpdatedAt { get; set; }
        
        [Column("document_status_old")]
        public int? DocumentStatusOld { get; set; }
    }
} 
