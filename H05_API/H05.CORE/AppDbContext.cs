using H05.CORE.Common;
using H05.CORE.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace H05.CORE
{
    public class AppDbContext(DbContextOptions<AppDbContext> options, IHttpContextAccessor httpContextAccessor) : DbContext(options)
    {
        public IHttpContextAccessor _httpContextAccessor = httpContextAccessor;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyAllConfigurations();
            foreach (var type in modelBuilder.Model.GetEntityTypes())
            {
                if (typeof(ISoftDeleteEntity).IsAssignableFrom(type.ClrType))
                    modelBuilder.SetSoftDeleteFilter(type.ClrType);
            }

            modelBuilder.HasSequence<int>("ORDER_SEQUENCE")
                    .StartsAt(1)
                    .IncrementsBy(1);

            base.OnModelCreating(modelBuilder);
        }

        public Func<DateTime> TimestampProvider { get; set; } = ()
            => DateTime.Now;

        public override int SaveChanges()
        {
            TrackChanges();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            TrackChanges();
            return await base.SaveChangesAsync(cancellationToken);
        }
        public string GetUserRequest()
        {
            var tokens = _httpContextAccessor?.HttpContext?.Request?.Headers.Authorization.ToString()?.Split(" ")?.ToList();
            string? user = null;
            if (tokens != null)
            {
                var token = tokens.FirstOrDefault(x => x != "Bearer");
                if (!string.IsNullOrWhiteSpace(token) && token != "null")
                {
                    JwtSecurityTokenHandler tokenHandler = new();
                    JwtSecurityToken securityToken = tokenHandler.ReadToken(token) as JwtSecurityToken;
                    var claim = securityToken.Claims;
                    var result = claim.FirstOrDefault(x => x.Type == ClaimTypes.Name);
                    user = result?.Value;
                }
            }
            return user;
        }

        private void TrackChanges()
        {
            var user = GetUserRequest();

        }

        public async Task<int> GetNextSequenceValue(string sequence)
        {
            using var command = Database.GetDbConnection().CreateCommand();
            command.CommandText = $"SELECT {sequence}.NEXTVAL FROM DUAL";
            await Database.OpenConnectionAsync();
            using var result = await command.ExecuteReaderAsync();
            await result.ReadAsync();
            return result.GetInt32(0);
        }
        
        public DbSet<TblBusinessUnit> TblBusinessUnit { get; set; }
        public DbSet<TblBusinessUnitAction> TblBusinessUnitAction { get; set; }
        public DbSet<TblBusinessUnitsPermission> TblBusinessUnitsPermission { get; set; }
        public DbSet<TblDelegation> TblDelegation { get; set; }
        public DbSet<TblDepartment> TblDepartment { get; set; }
        public DbSet<TblDepartmentAction> TblDepartmentAction { get; set; }
        public DbSet<TblDepartmentPlan> TblDepartmentPlan { get; set; }
        public DbSet<TblDepartmentPlanAttachment> TblDepartmentPlanAttachment { get; set; }
        public DbSet<TblDepartmentPlanComment> TblDepartmentPlanComment { get; set; }
        public DbSet<TblDepartmentPlanCommentAttachment> TblDepartmentPlanCommentAttachment { get; set; }
        public DbSet<TblDepartmentPlanResult> TblDepartmentPlanResult { get; set; }
        public DbSet<TblDepartmentPlansEmployee> TblDepartmentPlansEmployee { get; set; }
        public DbSet<TblDepartmentPlanTransfer> TblDepartmentPlanTransfer { get; set; }
        public DbSet<TblDepartmentsPermission> TblDepartmentsPermission { get; set; }
        public DbSet<TblDepartmentType> TblDepartmentType { get; set; }
        public DbSet<TblDocumentAttachment> TblDocumentAttachment { get; set; }
        public DbSet<TblDocumentBook> TblDocumentBook { get; set; }
        public DbSet<TblDocumentHandler> TblDocumentHandler { get; set; }
        public DbSet<TblDocumentHandlerOpinion> TblDocumentHandlerOpinion { get; set; }
        public DbSet<TblDocumentHistory> TblDocumentHistory { get; set; }
        public DbSet<TblDocumentNumber> TblDocumentNumber { get; set; }
        public DbSet<TblDocumentOpinion> TblDocumentOpinion { get; set; }
        public DbSet<TblDocumentProposal> TblDocumentProposal { get; set; }
        public DbSet<TblDocumentType> TblDocumentType { get; set; }
        public DbSet<TblDocumentViewer> TblDocumentViewer { get; set; }
        public DbSet<TblEmployee> TblEmployee { get; set; }
        public DbSet<TblEmployeeRoleAssignment> TblEmployeeRoleAssignment { get; set; }
        public DbSet<TblExternalOrganization> TblExternalOrganization { get; set; }
        public DbSet<TblFeature> TblFeature { get; set; }
        public DbSet<TblFieldGroup> TblFieldGroup { get; set; }
        public DbSet<TblFile> TblFile { get; set; }
        public DbSet<TblIncomingDocument> TblIncomingDocument { get; set; }
        public DbSet<TblIncomingDocumentsRoleProcessing> TblIncomingDocumentsRoleProcessing { get; set; }
        public DbSet<TblIncomingDocumentsRolePropose> TblIncomingDocumentsRolePropose { get; set; }
        public DbSet<TblInternalOrganization> TblInternalOrganization { get; set; }
        public DbSet<TblLeader> TblLeader { get; set; }
        public DbSet<TblMdAccountType> TblMdAccountType { get; set; }
        public DbSet<TblMdKeyValue> TblMdKeyValue { get; set; }
        public DbSet<TblMdStatus> TblMdStatus { get; set; }
        public DbSet<TblMeetingDevice> TblMeetingDevice { get; set; }
        public DbSet<TblMeetingResource> TblMeetingResource { get; set; }
        public DbSet<TblMeetingsDepartment> TblMeetingsDepartment { get; set; }
        public DbSet<TblMeetingsDepartmentComment> TblMeetingsDepartmentComment { get; set; }
        public DbSet<TblMeetingsDepartmentCommentAttachment> TblMeetingsDepartmentCommentAttachment { get; set; }
        public DbSet<TblMeetingsDepartmentResourceBooking> TblMeetingsDepartmentResourceBooking { get; set; }
        public DbSet<TblMeetingsDepartmentTransfer> TblMeetingsDepartmentTransfer { get; set; }
        public DbSet<TblMeetingsPersonal> TblMeetingsPersonal { get; set; }
        public DbSet<TblMeetingsPersonalMinute> TblMeetingsPersonalMinute { get; set; }
        public DbSet<TblMeetingsPersonalParticipant> TblMeetingsPersonalParticipant { get; set; }
        public DbSet<TblMeetingType> TblMeetingType { get; set; }
        public DbSet<TblMenuItem> TblMenuItem { get; set; }
        public DbSet<TblMinistryDepartment> TblMinistryDepartment { get; set; }
        public DbSet<TblMinistryWorkRecordHistory> TblMinistryWorkRecordHistory { get; set; }
        public DbSet<TblOrganization> TblOrganization { get; set; }
        public DbSet<TblOutgoingDocument> TblOutgoingDocument { get; set; }
        public DbSet<TblOutgoingDocumentExternalRecipient> TblOutgoingDocumentExternalRecipient { get; set; }
        public DbSet<TblOutgoingDocumentInternalRecipient> TblOutgoingDocumentInternalRecipient { get; set; }
        public DbSet<TblOutgoingDocumentInternalUnitRecipient> TblOutgoingDocumentInternalUnitRecipient { get; set; }
        public DbSet<TblOutgoingDocumentProcessingHistory> TblOutgoingDocumentProcessingHistory { get; set; }
        public DbSet<TblOutgoingDocumentReplacement> TblOutgoingDocumentReplacement { get; set; }
        public DbSet<TblOutgoingDocumentResponse> TblOutgoingDocumentResponse { get; set; }
        public DbSet<TblOutgoingDocumentStatusHistory> TblOutgoingDocumentStatusHistory { get; set; }
        public DbSet<TblOutgoingDocumentTask> TblOutgoingDocumentTask { get; set; }
        public DbSet<TblOutgoingDocumentWithdrawal> TblOutgoingDocumentWithdrawal { get; set; }
        public DbSet<TblParticipant> TblParticipant { get; set; }
        public DbSet<TblPermission> TblPermission { get; set; }
        public DbSet<TblPermissionAction> TblPermissionAction { get; set; }
        public DbSet<TblPersonalPlan> TblPersonalPlan { get; set; }
        public DbSet<TblPersonalPlanApproverTransfer> TblPersonalPlanApproverTransfer { get; set; }
        public DbSet<TblPersonalPlanComment> TblPersonalPlanComment { get; set; }
        public DbSet<TblPersonalPlanCommentAttachment> TblPersonalPlanCommentAttachment { get; set; }
        public DbSet<TblPersonalPlanReviewerTransfer> TblPersonalPlanReviewerTransfer { get; set; }
        public DbSet<TblRelatedDocument> TblRelatedDocument { get; set; }
        public DbSet<TblRelatedIncomingDocument> TblRelatedIncomingDocument { get; set; }
        public DbSet<TblRelatedOutgoingDocument> TblRelatedOutgoingDocument { get; set; }
        public DbSet<TblRelatedWorkRecord> TblRelatedWorkRecord { get; set; }
        public DbSet<TblResourcePermission> TblResourcePermission { get; set; }
        public DbSet<TblResourceType> TblResourceType { get; set; }
        public DbSet<TblRole> TblRole { get; set; }
        public DbSet<TblRolePermission> TblRolePermission { get; set; }
        public DbSet<TblStorageBox> TblStorageBox { get; set; }
        public DbSet<TblStorageDocumentDetail> TblStorageDocumentDetail { get; set; }
        public DbSet<TblStorageRecord> TblStorageRecord { get; set; }
        public DbSet<TblTask> TblTask { get; set; }
        public DbSet<TblTaskAssignment> TblTaskAssignment { get; set; }
        public DbSet<TblTaskCategory> TblTaskCategory { get; set; }
        public DbSet<TblTaskProgressLog> TblTaskProgressLog { get; set; }
        public DbSet<TblTaskType> TblTaskType { get; set; }
        public DbSet<TblUserBusinessUnitsPermission> TblUserBusinessUnitsPermission { get; set; }
        public DbSet<TblUserDepartmentsPermission> TblUserDepartmentsPermission { get; set; }
        public DbSet<TblUserPermission> TblUserPermission { get; set; }
        public DbSet<TblUserRole> TblUserRole { get; set; }
        public DbSet<TblUserSession> TblUserSession { get; set; }
        public DbSet<TblWorkflow> TblWorkflow { get; set; }
        public DbSet<TblWorkflowStep> TblWorkflowStep { get; set; }
        public DbSet<TblWorkRecord> TblWorkRecord { get; set; }
        public DbSet<TblWorkRecordAttachment> TblWorkRecordAttachment { get; set; }
        public DbSet<TblWorkRecordProgressAttachment> TblWorkRecordProgressAttachment { get; set; }
        public DbSet<TblWorkRecordProgressLog> TblWorkRecordProgressLog { get; set; }
        public DbSet<TblWorkRecordReport> TblWorkRecordReport { get; set; }
        public DbSet<TblWorkRecordReportAttachment> TblWorkRecordReportAttachment { get; set; }
        public DbSet<TblWorkRecordReportStatus> TblWorkRecordReportStatus { get; set; }
        public DbSet<TblWorkRecordTask> TblWorkRecordTask { get; set; }
        public DbSet<TblWorkRecordTaskGroup> TblWorkRecordTaskGroup { get; set; }
    }
}
