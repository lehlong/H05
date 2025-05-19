using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("document_proposals")]
    public class TblDocumentProposal 
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("incoming_document_id")]
        public long? IncomingDocumentId { get; set; }
        
        [Column("outgoing_document_id")]
        public long? OutgoingDocumentId { get; set; }
        
        [Column("created_by")]
        public int? CreatedBy { get; set; }
        
        [Column("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }
        
        [Column("commander_id")]
        public int? CommanderId { get; set; }
        
        [Column("main_handler_department_id")]
        public int? MainHandlerDepartmentId { get; set; }
        
        [Column("main_handler_person_id")]
        public int? MainHandlerPersonId { get; set; }
        
        [Column("cooperation_handler_departments")]
        public string? CooperationHandlerDepartments { get; set; }
        
        [Column("cooperation_handler_persons")]
        public string? CooperationHandlerPersons { get; set; }
        
        [Column("knowledge_handler_departments")]
        public string? KnowledgeHandlerDepartments { get; set; }
        
        [Column("knowledge_handler_persons")]
        public string? KnowledgeHandlerPersons { get; set; }
    }
} 
