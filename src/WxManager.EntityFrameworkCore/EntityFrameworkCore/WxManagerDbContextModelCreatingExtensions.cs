using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using WxManager.WeChatManager.ApprovalDetails;
using WxManager.WeChatManager.ApprovalGroups;
using WxManager.WeChatManager.ApprovalRules;
using WxManager.WeChatManager.WeChatAnalysis;
using WxManager.WeChatManager.WeChatAutoReplys;
using WxManager.WeChatManager.WeChatConfigs;
using WxManager.WeChatManager.WeChatMaterial;
using WxManager.WeChatManager.WeChatMedias;
using WxManager.WeChatManager.WeChatMenus;
using WxManager.WeChatManager.WeChatMessages;
using WxManager.WeChatManager.WeChatQrCodes;
using WxManager.WeChatManager.WeChatSendRecords;
using WxManager.WeChatManager.WeChatSyncRecords;
using WxManager.WeChatManager.WeChatTags;
using WxManager.WeChatManager.WeChatToDoLists;
using WxManager.WeChatManager.WeChatUsers;

namespace WxManager.EntityFrameworkCore
{
    public static class WxManagerDbContextModelCreatingExtensions
    {
        public static void ConfigureWxManager(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            #region ApprovalDetail

            builder.Entity<ApprovalDetail>(builder =>
            {
                builder.ToTable(nameof(ApprovalDetail));
                builder.HasKey(r => r.Id);
                builder.Property(r => r.Name).IsRequired();
                builder.Property(r => r.CreatedOnUtc).IsRequired();
                builder.Property(r => r.UpdateOnUtc);
                builder.Property(r => r.CreatedByCustomerId);
                builder.Property(r => r.ApprovalDetailStatusId).IsRequired();

                builder.Property(r => r.NextApprovalDetailName).IsRequired();
                builder.Property(r => r.CurrentApproverId).IsRequired();
                builder.Property(r => r.ApprovalGroupId).IsRequired();
                builder.Property(r => r.BeforeApproverId);
                builder.Property(r => r.WeChatMaterialNewsId).IsRequired();
                builder.Property(r => r.WeChatMaterialNewsVersionId).IsRequired();
                builder.Property(r => r.NodeId).IsRequired();
                builder.Property(r => r.Extra);

                builder.Ignore(r => r.ApprovalDetailStatus);

                //规则
                builder.HasOne(r => r.ApprovalRule)
                    .WithMany(x => x.ApprovalDetails)
                    .HasForeignKey(r => r.ApprovalRuleId);
            });

            #endregion

            #region ApprovalGroupInfo

            builder.Entity<ApprovalGroupInfo>(builder =>
            {
                builder.ToTable(nameof(ApprovalGroupInfo));
                builder.HasKey(x => x.Id);

                builder.Property(x => x.ApprovalGroupId).IsRequired();
                builder.Property(x => x.UserId).IsRequired();
                builder.Property(x => x.CreatedById).IsRequired();
                builder.Property(x => x.CreatedTimeUtc).IsRequired();

                builder.HasOne(x => x.ApprovalGroup)
                    .WithMany(u => u.ApprovalGroupInfos)
                    .HasForeignKey(x => x.ApprovalGroupId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            #endregion

            #region ApprovalGroup

            builder.Entity<ApprovalGroup>(builder =>
            {
                builder.ToTable(nameof(ApprovalGroup));
                builder.HasKey(ag => ag.Id);

                builder.Property(ag => ag.ApprovalGroupName).IsRequired().HasMaxLength(200);
                builder.Property(ag => ag.CreatedById).IsRequired();
                builder.Property(ag => ag.CreatedTimeUtc).IsRequired();
                builder.Property(ag => ag.UpdatedById).IsRequired();
                builder.Property(ag => ag.UpdatedTimeUtc).IsRequired();
            });

            #endregion

            #region ApprovalRule

            builder.Entity<ApprovalRule>(builder =>
            {
                builder.ToTable(nameof(ApprovalRule));
                builder.HasKey(r => r.Id);
                builder.Property(r => r.Name).IsRequired();
                builder.Property(r => r.ApprovalRuleStatusId).IsRequired();
                builder.Property(r => r.CreatedOnUtc).IsRequired();
                builder.Property(r => r.CreatedByCustomerId).IsRequired();
                builder.Property(r => r.UpdateOnUtc);
                builder.Property(r => r.UpdateByCustomerId);
                builder.Property(r => r.ApprovalRuleTypeId).IsRequired();
                builder.Property(r => r.RuleJson);

                builder.Ignore(r => r.ApprovalRuleStatus);
                builder.Ignore(r => r.ApprovalRuleType);


                //审批组
                builder.HasOne(r => r.ApprovalGroup)
                    .WithMany()
                    .HasForeignKey(r => r.ApprovalGroupId);
                //审核明细
                builder.HasMany(r => r.ApprovalDetails)
                    .WithOne(x => x.ApprovalRule)
                    .HasForeignKey(r => r.ApprovalRuleId);
            });

            #endregion

            #region WeChatStatisticsArticleDetail

            builder.Entity<WeChatStatisticsArticleDetail>(builder =>
            {
                builder.ToTable(nameof(WeChatStatisticsArticleDetail));
                builder.HasKey(cm => cm.Id);

                builder.Property(d => d.WeChatStatisticsArticleId).IsRequired();
                builder.Property(d => d.AddToFavCount);
                builder.Property(d => d.AddToFavUser);
                builder.Property(d => d.IntPageReadCount);
                builder.Property(d => d.IntPageReadUser);
                builder.Property(d => d.OriPageReadCount);
                builder.Property(d => d.OriPageReadUser);
                builder.Property(d => d.ShareCount);
                builder.Property(d => d.StatDate).IsRequired();
                builder.Property(d => d.TargetUser);
                builder.Property(d => d.ShareUser);
                builder.Property(d => d.IntPageFromSessionReadUser);
                builder.Property(d => d.IntPageFromSessionReadCount);
                builder.Property(d => d.IntPageFromHistMsgReadUser);
                builder.Property(d => d.IntPageFromHistMsgReadCount);
                builder.Property(d => d.IntPageFromFeedReadUser);
                builder.Property(d => d.IntPageFromFeedReadCount);
                builder.Property(d => d.IntPageFromFriendsReadUser);
                builder.Property(d => d.IntPageFromFriendsReadCount);
                builder.Property(d => d.IntPageFromOtherReadUser);
                builder.Property(d => d.IntPageFromOtherReadCount);
                builder.Property(d => d.FeedShareFromSessionUser);
                builder.Property(d => d.FeedShareFromSessionCnt);
                builder.Property(d => d.FeedShareFromFeedUser);
                builder.Property(d => d.FeedShareFromFeedCnt);
                builder.Property(d => d.FeedShareFromOtherUser);
                builder.Property(d => d.FeedShareFromOtherCnt);

                //规则
                builder.HasOne(d => d.WeChatStatisticsArticle)
                    .WithMany(t => t.StatisticsArticleDetails)
                    .HasForeignKey(d => d.WeChatStatisticsArticleId);
            });

            #endregion

            #region WeChatStatisticsArticle

            builder.Entity<WeChatStatisticsArticle>(builder =>
            {
                builder.ToTable(nameof(WeChatStatisticsArticle));
                builder.HasKey(cm => cm.Id);

                builder.Property(u => u.DataSourceId).IsRequired();
                builder.Property(u => u.WeChatConfigId).IsRequired();
                builder.Property(u => u.RefDate).IsRequired();
                builder.Property(u => u.UserSource);
                builder.Property(u => u.AddToFavCount);
                builder.Property(u => u.AddToFavUser);
                builder.Property(u => u.IntPageReadCount);
                builder.Property(u => u.IntPageReadUser);
                builder.Property(u => u.MsgId).HasMaxLength(45);
                builder.Property(u => u.OriPageReadCount);
                builder.Property(u => u.OriPageReadUser);
                builder.Property(u => u.RefHour);
                builder.Property(u => u.ShareCount);
                builder.Property(u => u.ShareScene);
                builder.Property(u => u.Title).HasMaxLength(45);
                builder.Property(u => u.ShareUser);

                builder.Ignore(r => r.AnalysisDataSourseType);
            });

            #endregion

            #region WeChatStatisticsInterface

            builder.Entity<WeChatStatisticsInterface>(builder =>
            {
                builder.ToTable(nameof(WeChatStatisticsInterface));
                builder.HasKey(cm => cm.Id);

                builder.Property(u => u.DataSourceId).IsRequired();
                builder.Property(u => u.WeChatConfigId).IsRequired();
                builder.Property(u => u.RefDate).IsRequired();
                builder.Property(u => u.CallbackCount);
                builder.Property(u => u.FailCount);
                builder.Property(u => u.TotalTimeCost);
                builder.Property(u => u.MaxTimeCost);
                builder.Property(u => u.RefHour);

                builder.Ignore(r => r.AnalysisDataSourseType);
            });

            #endregion

            #region WeChatStatisticsMsg

            builder.Entity<WeChatStatisticsMsg>(builder =>
            {
                builder.ToTable(nameof(WeChatStatisticsMsg));
                builder.HasKey(cm => cm.Id);

                builder.Property(u => u.DataSourceId).IsRequired();
                builder.Property(u => u.WeChatConfigId).IsRequired();
                builder.Property(u => u.RefDate).IsRequired();
                builder.Property(u => u.RefHour);
                builder.Property(u => u.MsgType);
                builder.Property(u => u.MsgUser);
                builder.Property(u => u.MsgCount);
                builder.Property(u => u.CountInterval);
                builder.Property(u => u.IntPageReadCount);
                builder.Property(u => u.OriPageReadUser);

                builder.Ignore(r => r.AnalysisDataSourseType);
            });

            #endregion

            #region WeChatStatisticsUser

            builder.Entity<WeChatStatisticsUser>(builder =>
            {
                builder.ToTable(nameof(WeChatStatisticsUser));
                builder.HasKey(cm => cm.Id);

                builder.Property(u => u.DataSourceId).IsRequired();
                builder.Property(u => u.WeChatConfigId).IsRequired();
                builder.Property(u => u.RefDate).IsRequired();
                builder.Property(u => u.CancelUser);
                builder.Property(u => u.CumulateUser);
                builder.Property(u => u.NewUser);
                builder.Property(u => u.UserSource);

                builder.Ignore(r => r.AnalysisDataSourseType);
            });

            #endregion

            #region WeChatAutoReply

            builder.Entity<WeChatAutoReply>(builder =>
            {
                builder.ToTable(nameof(WeChatAutoReply));
                builder.HasKey(wcs => wcs.Id);
                builder.Property(wcs => wcs.Name).HasMaxLength(200).IsRequired();
                builder.Property(wcs => wcs.HalfKeyWords);
                builder.Property(wcs => wcs.FullKeyWords);
                builder.Property(wcs => wcs.ReplayTypeId);
                builder.Property(wcs => wcs.Content);
                builder.Ignore(wcs => wcs.ReplyType);

                builder.Property(x => x.CreatedOnUtc);
                builder.Property(x => x.UpdatedOnUtc);

                builder.Property(x => x.IsPublish);

                builder.HasOne(x => x.WeChatConfig)
                    .WithMany()
                    .HasForeignKey(x => x.WeChatConfigId)
                    .OnDelete(deleteBehavior: Microsoft.EntityFrameworkCore.DeleteBehavior.Cascade);
            });

            #endregion

            #region WeChatConfig

            builder.Entity<WeChatConfig>(builder =>
            {
                builder.ToTable(nameof(WeChatConfig));
                builder.HasKey(wcs => wcs.Id);
                builder.Property(wcs => wcs.WeChatId).HasMaxLength(200).IsRequired();
                builder.Property(wcs => wcs.WeChatAppId).HasMaxLength(200).IsRequired();
                builder.Property(wcs => wcs.WeChatAppSecret).HasMaxLength(200).IsRequired();
                builder.Property(wcs => wcs.EncodingAESKey).HasMaxLength(512).IsRequired();
                builder.Property(wcs => wcs.WeChatName).HasMaxLength(200).IsRequired();
                builder.Property(wcs => wcs.WeChatToken).HasMaxLength(200).IsRequired();
                builder.Property(wcs => wcs.LanguageId).IsRequired();
                builder.Property(wcs => wcs.Deleted).IsRequired();
                builder.Property(wcs => wcs.NotifyTemplateId).HasMaxLength(200);
                builder.Ignore(wcs => wcs.Language);
            });

            #endregion

            #region WeChatMaterialNewsArticle

            builder.Entity<WeChatMaterialNewsArticle>(builder =>
            {
                builder.ToTable(nameof(WeChatMaterialNewsArticle));
                builder.HasKey(x => x.Id);
                builder.Property(x => x.WeChatMaterialNewsVersionId);
                builder.Property(x => x.WeChatMaterialNewsId);
                builder.Property(x => x.Index);
                builder.Property(x => x.Title).HasMaxLength(200);
                builder.Property(x => x.ThumbMediaId).HasMaxLength(200);
                builder.Property(x => x.ShowCoverPic);
                builder.Property(x => x.Author).HasMaxLength(200);
                builder.Property(x => x.Digest).HasMaxLength(200);
                builder.Property(x => x.Content);
                builder.Property(x => x.Url);
                builder.Property(x => x.ContentSourceUrl);
                builder.Property(x => x.NeedOpenComment);
                builder.Property(x => x.OnlyFansCanComment);

                builder.Property(x => x.WeChatMaterialNewsId);
                builder.HasOne(x => x.WeChatMaterialNewsVersion)
                    .WithMany(x => x.WeChatMaterialNewsArticles)
                    .HasForeignKey(x => x.WeChatMaterialNewsVersionId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            #endregion

            #region WeChatMaterialNews

            builder.Entity<WeChatMaterialNews>(builder =>
            {
                builder.ToTable(nameof(WeChatMaterialNews));
                builder.HasKey(x => x.Id);
                builder.Property(x => x.WeChatMediaId)
                    .HasMaxLength(200);
                builder.Property(x => x.WeChatConfigId);
                builder.Ignore(wcs => wcs.WeChatMaterialNewsStatus);
                builder.HasMany(x => x.WeChatMaterialNewsVersions)
                    .WithOne(t => t.WeChatMaterialNews)
                    .HasForeignKey(x => x.WeChatMaterialNewsId)
                    .OnDelete(DeleteBehavior.Cascade);
                builder.HasOne(x => x.ApprovalRule)
                    .WithMany()
                    .HasForeignKey(x => x.ApprovalRuleId);
            });

            #endregion

            #region WeChatMaterialNewsVersion

            builder.Entity<WeChatMaterialNewsVersion>(builder =>
            {
                builder.ToTable(nameof(WeChatMaterialNewsVersion));
                builder.HasKey(x => x.Id);
                builder.Property(x => x.VersionNumber)
                    .IsRequired();
                builder.Property(x => x.CreatedOnUtc);
                builder.Property(x => x.WeChatMaterialNewsId);
                builder.HasOne(t => t.WeChatMaterialNews)
                    .WithMany(x => x.WeChatMaterialNewsVersions)
                    .HasForeignKey(x => x.WeChatMaterialNewsId);
                builder.HasMany(x => x.WeChatMaterialNewsArticles)
                    .WithOne(x => x.WeChatMaterialNewsVersion)
                    .HasForeignKey(x => x.WeChatMaterialNewsVersionId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            #endregion

            #region WeChatMedia

            builder.Entity<WeChatMedia>(builder =>
            {
                builder.ToTable(nameof(WeChatMedia));
                builder.HasKey(wcm => wcm.Id);

                builder.Property(wcm => wcm.MediaId).HasMaxLength(100);
                builder.Property(wcm => wcm.FileName).HasMaxLength(200);
                builder.Property(wcm => wcm.Title).HasMaxLength(200);
                builder.Property(wcm => wcm.Introduction).HasMaxLength(200);
                builder.Property(wcm => wcm.Content);
                builder.Property(wcm => wcm.Url).HasMaxLength(1000);
                builder.Property(wcm => wcm.UpdateTimeUtc);

                builder.Ignore(wcm => wcm.UploadMediaFileType);

                // Relationships
                builder.HasOne(t => t.WeChatConfig)
                    .WithMany()
                    .HasForeignKey(t => t.WeChatConfigId)
                    .OnDelete(DeleteBehavior.Cascade);


                builder.HasMany(t => t.WeChatNewsItems)
                    .WithOne(news => news.WeChatMedia)
                    .HasForeignKey(news => news.WeChatMediaId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            #endregion

            #region WeChatNews

            builder.Entity<WeChatNews>(builder =>
            {
                builder.ToTable(nameof(WeChatNews));
                builder.HasKey(wcm => wcm.Id);

                builder.Property(wcm => wcm.Title).HasMaxLength(100).IsRequired();
                builder.Property(wcm => wcm.ThumbMediaId).HasMaxLength(100);
                builder.Property(wcm => wcm.Title).HasMaxLength(200);
                builder.Property(wcm => wcm.Author).HasMaxLength(100);
                builder.Property(wcm => wcm.Digest).HasMaxLength(200);
                builder.Property(wcm => wcm.ShowCoverPic);
                builder.Property(wcm => wcm.Content).IsRequired();
                builder.Property(wcm => wcm.Url).HasMaxLength(1000);
                builder.Property(wcm => wcm.ConetntSourceUrl).HasMaxLength(1000);
            });

            #endregion

            #region WeChatTempMedia

            builder.Entity<WeChatTempMedia>(builder =>
            {
                builder.ToTable(nameof(WeChatTempMedia));
                builder.HasKey(wcm => wcm.Id);

                builder.Property(wcm => wcm.MediaId).HasMaxLength(100);
                builder.Property(wcm => wcm.FileName).HasMaxLength(200);
                builder.Property(wcm => wcm.Content).IsRequired();
                builder.Property(wcm => wcm.UploadMediaFileTypeId).IsRequired();
                builder.Property(wcm => wcm.Url).HasMaxLength(1000);
                builder.Property(wcm => wcm.WeChatMessageId);
                builder.Property(wcm => wcm.FromUserOpenId).HasMaxLength(100);
                builder.Property(wcm => wcm.CreatedOnUtc).IsRequired();

                builder.Ignore(wm => wm.UploadMediaFileType);

                // Relationships
                builder.HasOne(t => t.WeChatConfig)
                    .WithMany()
                    .HasForeignKey(t => t.WeChatConfigId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            #endregion

            #region WeChatMenu

            builder.Entity<WeChatMenu>(builder =>
            {
                builder.ToTable(nameof(WeChatMenu));
                builder.HasKey(wcm => wcm.Id);
                builder.Property(wm => wm.CreatedOnUtc).IsRequired();
                builder.Property(wm => wm.UpdatedOnUtc).IsRequired();
                builder.Property(wm => wm.PersonaliseMenu).IsRequired();
                builder.Property(wm => wm.MenuId).HasMaxLength(200);
                builder.Property(wm => wm.Content).IsRequired();
                builder.Property(wm => wm.Name).HasMaxLength(200).IsRequired();
                builder.Property(wm => wm.Published).IsRequired();

                // Relationships
                builder.HasOne(t => t.WeChatConfig)
                    .WithMany()
                    .HasForeignKey(t => t.WeChatConfigId)
                     .OnDelete(DeleteBehavior.Cascade);
            });

            #endregion

            #region WeChatMessage

            builder.Entity<WeChatMessage>(builder =>
            {
                builder.ToTable(nameof(WeChatMessage));
                builder.HasKey(wcm => wcm.Id);

                builder.Property(wm => wm.IsRead).IsRequired();
                builder.Property(wm => wm.MsgType).IsRequired();
                builder.Property(wm => wm.ContentTypeId).IsRequired();
                builder.Property(wm => wm.UserOpenId).HasMaxLength(100).IsRequired();
                builder.Property(wm => wm.WeChatUserId).IsRequired();
                builder.Property(wm => wm.Content).IsRequired();
                builder.Property(wm => wm.SendTimeUtc).IsRequired();
                builder.Property(wm => wm.CustomerId);
                builder.Ignore(wm => wm.ContentType);
                // Relationships
                builder.HasOne(t => t.WeChatUser)
                    .WithMany(x => x.WeChatMessages)
                    .HasForeignKey(t => t.WeChatUserId)
                   .OnDelete(DeleteBehavior.Cascade);

                builder.HasOne(t => t.WeChatConfig)
                    .WithMany()
                    .HasForeignKey(t => t.WeChatConfigId)
                     .OnDelete(DeleteBehavior.Cascade);
            });

            #endregion

            #region WeChatMessageNotify

            builder.Entity<WeChatMessageNotify>(builder =>
            {
                builder.ToTable(nameof(WeChatMessageNotify));
                builder.HasKey(wcm => wcm.Id);

                builder.Property(wm => wm.WeChatConfigId).IsRequired();
                builder.Property(wm => wm.CustomerId).IsRequired();
                builder.Property(wm => wm.CustomerOpenId).HasMaxLength(100);
                builder.Property(wm => wm.Interval).IsRequired();
                builder.Property(wm => wm.Enable).IsRequired();
                // Relationships

                builder.HasOne(t => t.WeChatConfig)
                    .WithMany()
                    .HasForeignKey(t => t.WeChatConfigId)
                     .OnDelete(DeleteBehavior.Cascade);
            });

            #endregion

            #region WeChatQrCode

            builder.Entity<WeChatQrCode>(builder =>
            {
                builder.ToTable(nameof(WeChatQrCode));
                builder.HasKey(wcm => wcm.Id);

                builder.Property(wm => wm.Ticket).HasMaxLength(200);
                builder.Property(wm => wm.SceneStr).HasMaxLength(100);
                builder.Property(wm => wm.SceneId);
                builder.Property(wm => wm.Url).HasMaxLength(1000);
                builder.Property(wm => wm.Name).HasMaxLength(500).IsRequired();
                builder.Property(wm => wm.Type).HasMaxLength(200);
                builder.Property(wm => wm.CreatedOnUtc).IsRequired();
                builder.Property(wm => wm.WeChatConfigId).IsRequired();
                builder.Ignore(wm => wm.ActionName);

                // Relationships
                builder.HasOne(t => t.WeChatTag)
                    .WithMany()
                    .HasForeignKey(t => t.WeChatTagId)
                    .OnDelete(DeleteBehavior.Cascade);
                builder.HasOne(t => t.WeChatConfig)
                    .WithMany()
                    .HasForeignKey(t => t.WeChatConfigId)
                     .OnDelete(DeleteBehavior.Cascade);
            });

            #endregion

            #region WeChatQrCodeRecord

            builder.Entity<WeChatQrCodeRecord>(builder =>
            {
                builder.ToTable(nameof(WeChatQrCodeRecord));
                builder.HasKey(wcm => wcm.Id);

                builder.Property(wm => wm.WeChatConfigId).IsRequired();
                builder.Property(wm => wm.OpenId).HasMaxLength(100).IsRequired();
                builder.Property(wm => wm.ScanTypeId).IsRequired();
                builder.Property(wm => wm.CreatedOnUtc).IsRequired();
                builder.Ignore(wm => wm.ScanType);

                builder.HasOne(t => t.WeChatQrCode)
                    .WithMany()
                    .HasForeignKey(t => t.WeChatQrCodeId)
                     .OnDelete(DeleteBehavior.Cascade);
            });

            #endregion

            #region WeChatSendRecord

            builder.Entity<WeChatSendRecord>(builder =>
            {
                builder.ToTable(nameof(WeChatSendRecord));
                builder.HasKey(wcm => wcm.Id);

                builder.Property(wm => wm.ErrorMsg);
                builder.Property(wm => wm.MsgDataId).HasMaxLength(50);
                builder.Property(wm => wm.MsgStatus).HasMaxLength(100);
                builder.Property(wm => wm.WeChatConfigId).IsRequired();
                builder.Property(wm => wm.MsgId).HasMaxLength(50);
                builder.Property(wm => wm.MsgTypeId);
                builder.Property(wm => wm.MediaId).HasMaxLength(200);
                builder.Property(wm => wm.CreatedOnUtc).IsRequired();
                builder.Property(wm => wm.WeChatTagId);
                builder.Ignore(wm => wm.MsgType);

                builder.HasOne(t => t.WeChatConfig)
                    .WithMany()
                    .HasForeignKey(t => t.WeChatConfigId)
                     .OnDelete(DeleteBehavior.Cascade);
            });

            #endregion

            #region WeChatSyncRecord

            builder.Entity<WeChatSyncRecord>(builder =>
            {
                builder.ToTable(nameof(WeChatSyncRecord));
                builder.HasKey(wcm => wcm.Id);

                builder.Ignore(sr => sr.RecordType);
                builder.Ignore(sr => sr.SyncStatus);

                builder.HasOne(t => t.WeChatConfig)
                    .WithMany()
                    .HasForeignKey(t => t.WeChatConfigId)
                     .OnDelete(DeleteBehavior.Cascade);
            });

            #endregion

            #region WeChatTag

            builder.Entity<WeChatTag>(builder =>
            {
                builder.ToTable(nameof(WeChatTag));
                builder.HasKey(wcm => wcm.Id);

                builder.Property(u => u.WeChatId).IsRequired();
                builder.Property(u => u.Name).IsRequired().HasMaxLength(30);
            });

            #endregion

            #region WeChatToDoList

            builder.Entity<WeChatToDoList>(builder =>
            {
                builder.ToTable(nameof(WeChatToDoList));
                builder.HasKey(wcm => wcm.Id);

                builder.Property(u => u.Name).IsRequired().HasMaxLength(200);
                builder.Property(u => u.CreatedOnUtc).IsRequired();
                builder.Property(u => u.CreatedByCustomerId).IsRequired();
                builder.Property(u => u.ToDoStatusId).IsRequired();
                builder.Property(u => u.Description);
                builder.Property(u => u.Important).IsRequired();
                builder.Property(u => u.WeChatConfigId).IsRequired();
                builder.Property(u => u.OverTimeUtc).IsRequired();
                builder.Property(u => u.ClosedOnUtc);
                builder.Property(u => u.ClosedNote);
                builder.Property(u => u.ClosedByCustomerId);
                builder.Property(u => u.WeChatUserId).IsRequired();
                builder.Ignore(u => u.ToDoStatus);
            });

            #endregion

            #region WeChatUser

            builder.Entity<WeChatUser>(builder =>
            {
                builder.ToTable(nameof(WeChatUser));
                builder.HasKey(wcm => wcm.Id);

                builder.Property(u => u.OpenId).IsRequired().HasMaxLength(200);
                builder.Property(u => u.CustomerId).IsRequired();
                builder.Property(u => u.Subscribe).IsRequired();
                builder.Property(u => u.NickName).HasMaxLength(200);
                builder.Property(u => u.Sex);
                builder.Property(u => u.City).HasMaxLength(50);
                builder.Property(u => u.Country).HasMaxLength(50);
                builder.Property(u => u.Province).HasMaxLength(50);
                builder.Property(u => u.Language).HasMaxLength(30);
                builder.Property(u => u.HeadImgUrl).HasMaxLength(500);
                builder.Property(u => u.FirstSubscribeTimeUtc);
                builder.Property(u => u.SubscribeTimeUtc);
                builder.Property(u => u.UnSubscribeTimeUtc);
                builder.Property(u => u.UnionId).HasMaxLength(200);
                builder.Property(u => u.Remark).HasMaxLength(30);
                builder.Property(u => u.WeChatGroupId);
                builder.Property(u => u.BlackUser);
            });

            #endregion

            #region WeChatUserTag

            builder.Entity<WeChatUserTag>(builder =>
            {
                builder.ToTable("WeChatUser_WeChatTag_Mapping");
                //builder.HasKey(x => x.Id);

                builder.HasKey(x => new { x.WeChatTagId, x.WeChatUserId });

                builder.Property(x => x.WeChatTagId);
                builder.Property(x => x.WeChatUserId);

                builder.HasOne(x => x.WeChatUser)
                    .WithMany(u => u.WeChatUserTags)
                    .HasForeignKey(x => x.WeChatUserId)
                    .OnDelete(DeleteBehavior.Cascade);
                builder.HasOne(x => x.WeChatTag)
                    .WithMany(u => u.WeChatUserTags)
                    .HasForeignKey(x => x.WeChatTagId)
                    .OnDelete(DeleteBehavior.Cascade);
            });

            #endregion
        }
    }
}