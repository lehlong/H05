using H05.CORE.Common;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace H05.CORE.Entities
{
    [Table("files")]
    public class TblFile : BaseEntity
    {
        [Key]
        [Column("id")]
        public long Id { get; set; }
        
        [Column("code")]
        public string? Code { get; set; }
        
        [Column("file_name")]
        public string? FileName { get; set; }
        
        [Column("file_type")]
        public string? FileType { get; set; }
        
        [Column("file_size")]
        public int? FileSize { get; set; }
        
        [Column("full_text")]
        public string? FullText { get; set; }
        
        [Column("summary")]
        public string? Summary { get; set; }
        
        [Column("classification")]
        public string? Classification { get; set; }
        
        [Column("title")]
        public string? Title { get; set; }
        
        [Column("doc_date")]
        public string? DocDate { get; set; }
        
        [Column("doc_number")]
        public string? DocNumber { get; set; }
        
        [Column("signed_by")]
        public string? SignedBy { get; set; }
        
        [Column("department")]
        public string? Department { get; set; }
        
        [Column("upload_date")]
        public DateTimeOffset? UploadDate { get; set; }
        
        [Column("chunks")]
        public string? Chunks { get; set; }
    }
} 
