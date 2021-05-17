using AutoMapper;
using Senparc.Weixin.MP.AdvancedAPIs.Analysis;
using Senparc.Weixin.MP.AdvancedAPIs.User;
using Senparc.Weixin.MP.AdvancedAPIs.UserTag;
using WxManager.Application.Contracts.Common;
using WxManager.Application.Contracts.WeChatManager.ApprovalGroups;
using WxManager.Application.Contracts.WeChatManager.ApprovalRules;
using WxManager.Application.Contracts.WeChatManager.WeChatAnalysis;
using WxManager.Application.Contracts.WeChatManager.WeChatAutoReplys;
using WxManager.Application.Contracts.WeChatManager.WeChatConfigs;
using WxManager.Application.Contracts.WeChatManager.WeChatMaterial;
using WxManager.Application.Contracts.WeChatManager.WeChatMedias;
using WxManager.Application.Contracts.WeChatManager.WeChatMenus;
using WxManager.Application.Contracts.WeChatManager.WeChatMessages;
using WxManager.Application.Contracts.WeChatManager.WeChatQrCodes;
using WxManager.Application.Contracts.WeChatManager.WeChatSendRecords;
using WxManager.Application.Contracts.WeChatManager.WeChatSyncRecords;
using WxManager.Application.Contracts.WeChatManager.WeChatTags;
using WxManager.Application.Contracts.WeChatManager.WeChatToDoLists;
using WxManager.Application.Contracts.WeChatManager.WeChatUsers;
using WxManager.Domain.Shared.WeChatMessages;
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

namespace WxManager
{
    public class WxManagerApplicationAutoMapperProfile : Profile
    {
        public WxManagerApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            //ApprovalGroupInfo
            CreateMap<ApprovalGroupInfo, ApprovalGroupInfoModel>();
            CreateMap<ApprovalGroupInfoModel, ApprovalGroupInfo>();
            //ApprovalGroup
            CreateMap<ApprovalGroup, ApprovalGroupModel>();
            CreateMap<ApprovalGroupModel, ApprovalGroup>();
            //WeChatConfig
            CreateMap<WeChatConfig, WeChatConfigModel>();
            CreateMap<WeChatConfigModel, WeChatConfig>();
            //WeChatTag
            CreateMap<TagJson_Tag, WeChatTag>()
                .ForMember(dest => dest.Id, mo => mo.Ignore())
                .ForMember(dest => dest.WeChatId, mo => mo.MapFrom(x => x.id))
                .ForMember(dest => dest.Name, mo => mo.MapFrom(x => x.name));
            CreateMap<WeChatTag, WeChatTagModel>()
                .ForMember(dest => dest.CreatedOn, mo => mo.Ignore())
                .ForMember(dest => dest.UpdatedOn, mo => mo.Ignore());
            CreateMap<WeChatTagModel, WeChatTag>()
                .ForMember(dest => dest.CreatedOnUtc, mo => mo.Ignore())
                .ForMember(dest => dest.UpdatedOnUtc, mo => mo.Ignore());
            //WeChatUser
            CreateMap<UserInfoJson, WeChatUser>()
                .ForMember(dest => dest.OpenId, mo => mo.MapFrom(x => x.openid))
                .ForMember(dest => dest.CustomerId, mo => mo.Ignore())
                .ForMember(dest => dest.Subscribe, mo => mo.MapFrom(x => x.subscribe != 0))
                .ForMember(dest => dest.NickName, mo => mo.MapFrom(x => x.nickname))
                .ForMember(dest => dest.Sex, mo => mo.MapFrom(x => x.sex))
                .ForMember(dest => dest.Country, mo => mo.MapFrom(x => x.country))
                .ForMember(dest => dest.Province, mo => mo.MapFrom(x => x.province))
                .ForMember(dest => dest.Language, mo => mo.MapFrom(x => x.language))
                .ForMember(dest => dest.HeadImgUrl, mo => mo.MapFrom(x => x.headimgurl))
                .ForMember(dest => dest.SubscribeTimeUtc,
                    mo => mo.MapFrom(x =>
                        x.subscribe_time != 0
                            ? WxCommonHelper.ConvertToDateTimeUtc(x.subscribe_time)
                            : null))
                .ForMember(dest => dest.UnionId, mo => mo.MapFrom(x => x.unionid))
                .ForMember(dest => dest.Remark, mo => mo.MapFrom(x => x.remark))
                .ForMember(dest => dest.WeChatGroupId, mo => mo.MapFrom(x => x.groupid))
                .ForMember(dest => dest.FirstSubscribeTimeUtc, mo => mo.Ignore());
            CreateMap<WeChatUser, WeChatUserModel>()
                .ForMember(dest => dest.UnSubscribeTime, mo => mo.Ignore())
                .ForMember(dest => dest.SubscribeTime, mo => mo.Ignore())
                .ForMember(dest => dest.CreatedOn, mo => mo.Ignore())
                .ForMember(dest => dest.UpdatedOn, mo => mo.Ignore())
                .ForMember(dest => dest.SelectedTagIds, mo => mo.Ignore())
                .ForMember(dest => dest.AvailableTagIds, mo => mo.Ignore());
            CreateMap<WeChatUserModel, WeChatUser>()
                .ForMember(dest => dest.UnSubscribeTimeUtc, mo => mo.Ignore())
                .ForMember(dest => dest.SubscribeTimeUtc, mo => mo.Ignore())
                .ForMember(dest => dest.CreatedOnUtc, mo => mo.Ignore())
                .ForMember(dest => dest.UpdatedOnUtc, mo => mo.Ignore())
                .ForMember(dest => dest.WeChatUserTags, mo => mo.Ignore());
            //WeChatSyncRecord
            CreateMap<WeChatSyncRecordModel, WeChatSyncRecord>()
                .ForMember(dest => dest.WeChatConfig, mo => mo.Ignore())
                .ForMember(dest => dest.StartTimeUtc, mo => mo.Ignore())
                .ForMember(dest => dest.EndTimeUtc, mo => mo.Ignore())
                .ForMember(dest => dest.RecordTypeId, mo => mo.Ignore())
                .ForMember(dest => dest.SyncStatusId, mo => mo.Ignore());
            CreateMap<WeChatSyncRecord, WeChatSyncRecordModel>()
                .ForMember(dest => dest.StartTime, mo => mo.Ignore())
                .ForMember(dest => dest.EndTime, mo => mo.Ignore())
                .ForMember(dest => dest.RecordTypeStr, mo => mo.Ignore())
                .ForMember(dest => dest.SyncStatusStr, mo => mo.Ignore())
                .ForMember(dest => dest.RecordType, mo => mo.MapFrom(entity => (int)entity.RecordType))
                .ForMember(dest => dest.SyncStatus, mo => mo.MapFrom(entity => (int)entity.SyncStatus));
            //WeChatMessage
            CreateMap<WeChatMessageModel, WeChatMessage>()
                .ForMember(dest => dest.WeChatConfig, mo => mo.Ignore())
                .ForMember(dest => dest.ContentType, mo => mo.MapFrom(x => (ContentType)x.ContentType))
                .ForMember(dest => dest.UserOpenId, mo => mo.Ignore())
                .ForMember(dest => dest.SendTimeUtc, mo => mo.Ignore());
            CreateMap<WeChatMessage, WeChatMessageModel>()
                .ForMember(dest => dest.SendTime, mo => mo.Ignore())
                .ForMember(dest => dest.CustomerName, mo => mo.Ignore())
                .ForMember(dest => dest.ContentType, mo => mo.MapFrom(x => x.ContentTypeId));
            //WeChatMenu
            CreateMap<WeChatMenu, WeChatMenuModel>()
                .ForMember(dest => dest.CreatedOn, mo => mo.Ignore())
                .ForMember(dest => dest.UpdatedOn, mo => mo.Ignore());
            CreateMap<WeChatMenuModel, WeChatMenu>()
                .ForMember(dest => dest.WeChatConfig, mo => mo.Ignore())
                .ForMember(dest => dest.CreatedOnUtc, mo => mo.Ignore())
                .ForMember(dest => dest.UpdatedOnUtc, mo => mo.Ignore());

            //WeChatMedia
            CreateMap<WeChatMedia, WeChatMediaModel>()
                .ForMember(dest => dest.NewsModels, mo => mo.Ignore())
                .ForMember(dest => dest.UploadMediaFileType, mo => mo.Ignore());
            CreateMap<WeChatMediaModel, WeChatMedia>()
                .ForMember(dest => dest.UploadMediaFileType, mo => mo.Ignore())
                .ForMember(dest => dest.Content, mo => mo.Ignore());
            //WeChatNews
            CreateMap<WeChatNews, WeChatNewsModel>()
                .ForMember(dest => dest.ThumbMediaUrl, mo => mo.Ignore());
            CreateMap<WeChatNewsModel, WeChatNews>();
            //WeChatQrCode
            CreateMap<WeChatQrCodeModel, WeChatQrCode>()
                .ForMember(dest => dest.ActionName, mo => mo.Ignore())
                .ForMember(dest => dest.WeChatConfig, mo => mo.Ignore());
            CreateMap<WeChatQrCode, WeChatQrCodeModel>()
                .ForMember(dest => dest.AutoMarkTag, mo => mo.MapFrom(x => x.WeChatTagId.HasValue))
                .ForMember(dest => dest.CreatedOn, mo => mo.Ignore())
                .ForMember(dest => dest.ActionName, mo => mo.Ignore());
            //WeChatQrCodeRecordModel
            CreateMap<WeChatQrCodeRecordModel, WeChatQrCodeRecord>();
            CreateMap<WeChatQrCodeRecord, WeChatQrCodeRecordModel>()
                .ForMember(dest => dest.CreatedOn, mo => mo.Ignore())
                .ForMember(dest => dest.UserName, mo => mo.Ignore())
                .ForMember(dest => dest.UserId, mo => mo.Ignore())
                .ForMember(dest => dest.ScanTypeStr, mo => mo.Ignore());
            //WeChatToDoList
            CreateMap<WeChatToDoListModel, WeChatToDoList>();
            CreateMap<WeChatToDoList, WeChatToDoListModel>();
            //WeChatSendRecordModel
            CreateMap<WeChatSendRecordModel, WeChatSendRecord>()
                .ForMember(dest => dest.CreatedOnUtc, mo => mo.Ignore())
                .ForMember(dest => dest.WeChatConfig, mo => mo.Ignore());
            CreateMap<WeChatSendRecord, WeChatSendRecordModel>()
                .ForMember(dest => dest.CreatedOn, mo => mo.Ignore());
            //WeChatMessageNotifyModel
            CreateMap<WeChatMessageNotify, WeChatMessageNotifyModel>();
            CreateMap<WeChatMessageNotifyModel, WeChatMessageNotify>()
                .ForMember(dest => dest.WeChatConfig, mo => mo.Ignore());

            CreateMap<WeChatAutoReply, WeChatAutoReplyModel>();
            CreateMap<WeChatAutoReplyModel, WeChatAutoReply>();
            //CreateMap<WeChatAutoReplyCaching, WeChatAutoReply>();
            //CreateMap<WeChatAutoReply, WeChatAutoReplyCaching>();
            //approval
            CreateMap<ApprovalRule, ApprovalRuleModel>()
                .ForMember(d => d.ApprovalGroupName, o => o.MapFrom(x => x.ApprovalGroup.ApprovalGroupName))
                .ForMember(d => d.ApprovalRuleStatusName, o => o.MapFrom(x => x.ApprovalRuleStatus))
                .ForMember(d => d.ApprovalRuleStatusId, o => o.MapFrom(x => x.ApprovalRuleStatus))
                .ForMember(d => d.ApprovalRuleTypeId, o => o.MapFrom(x => x.ApprovalRuleType))
                .ForMember(d => d.ApprovalRuleTypeName, o => o.MapFrom(x => x.ApprovalRuleType));
            CreateMap<ApprovalRuleModel, ApprovalRule>();
            //WeChatMaterialNewsArticle
            CreateMap<WeChatMaterialNews, WeChatMaterialNews>();
            CreateMap<WeChatMaterialNews, WeChatMaterialNewsModel>()
                .ForMember(dest => dest.WeChatMaterialNewsVersions, mo => mo.Ignore());
            CreateMap<WeChatMaterialNewsModel, WeChatMaterialNews>();
            CreateMap<WeChatMaterialNewsVersion, WeChatMaterialNewsVersion>();
            CreateMap<WeChatMaterialNewsVersion, WeChatMaterialNewsVersionModel>()
                .ForMember(dest => dest.WeChatMaterialNewsArticles, mo => mo.Ignore());
            CreateMap<WeChatMaterialNewsVersionModel, WeChatMaterialNewsVersion>();
            CreateMap<WeChatMaterialNewsArticle, WeChatMaterialNewsArticle>();
            CreateMap<WeChatMaterialNewsArticle, WeChatMaterialNewsArticleModel>();
            CreateMap<WeChatMaterialNewsArticleModel, WeChatMaterialNewsArticle>();

            //WeChatAnalysis
            CreateMap<WeChatStatisticsUser, WeChatStatisticsUserModel>();
            CreateMap<WeChatStatisticsArticle, WeChatStatisticsArticleModel>();
            CreateMap<WeChatStatisticsArticleDetail, WeChatStatisticsArticleDetailModel>();
            CreateMap<WeChatStatisticsMsg, WeChatStatisticsMsgModel>();
            CreateMap<WeChatStatisticsInterface, WeChatStatisticsInterfaceModel>();

            //WeChatStatisticsUser
            CreateMap<UserSummaryItem, WeChatStatisticsUser>()
                .ForMember(user => user.RefDate, conf => conf.MapFrom(wx => wx.ref_date))
                .ForMember(user => user.UserSource, conf => conf.MapFrom(wx => wx.user_source))
                .ForMember(user => user.NewUser, conf => conf.MapFrom(wx => wx.new_user))
                .ForMember(user => user.CancelUser, conf => conf.MapFrom(wx => wx.cancel_user))
                .ForMember(user => user.AnalysisDataSourseType, conf => conf.Ignore());

            CreateMap<UserCumulateItem, WeChatStatisticsUser>()
                .ForMember(user => user.CumulateUser, conf => conf.MapFrom(wx => wx.cumulate_user))
                .ForMember(user => user.RefDate, conf => conf.MapFrom(wx => wx.ref_date));

            //WeChatStatisticsArticle
            CreateMap<ArticleSummaryItem, WeChatStatisticsArticle>()
                .ForMember(art => art.RefDate, conf => conf.MapFrom(wx => wx.ref_date))
                .ForMember(art => art.MsgId, conf => conf.MapFrom(wx => wx.msgid))
                .ForMember(art => art.Title, conf => conf.MapFrom(wx => wx.title))
                .ForMember(art => art.IntPageReadUser, conf => conf.MapFrom(wx => wx.int_page_read_user))
                .ForMember(art => art.IntPageReadCount, conf => conf.MapFrom(wx => wx.int_page_read_count))
                .ForMember(art => art.OriPageReadUser, conf => conf.MapFrom(wx => wx.ori_page_read_user))
                .ForMember(art => art.OriPageReadCount, conf => conf.MapFrom(wx => wx.ori_page_read_count))
                .ForMember(art => art.ShareUser, conf => conf.MapFrom(wx => wx.share_user))
                .ForMember(art => art.ShareCount, conf => conf.MapFrom(wx => wx.share_count))
                .ForMember(art => art.AddToFavUser, conf => conf.MapFrom(wx => wx.add_to_fav_user))
                .ForMember(art => art.AddToFavCount, conf => conf.MapFrom(wx => wx.add_to_fav_count))
                .ForMember(art => art.AnalysisDataSourseType, conf => conf.Ignore());

            CreateMap<ArticleTotalItem, WeChatStatisticsArticle>()
                .ForMember(art => art.RefDate, conf => conf.MapFrom(wx => wx.ref_date))
                .ForMember(art => art.MsgId, conf => conf.MapFrom(wx => wx.msgid))
                .ForMember(art => art.Title, conf => conf.MapFrom(wx => wx.title))
                .ForMember(art => art.AnalysisDataSourseType, conf => conf.Ignore());

            CreateMap<ArticleTotal_Detail, WeChatStatisticsArticleDetail>()
                .ForMember(art => art.StatDate, conf => conf.MapFrom(wx => wx.stat_date))
                .ForMember(art => art.TargetUser, conf => conf.MapFrom(wx => wx.target_user))
                .ForMember(art => art.IntPageReadUser, conf => conf.MapFrom(wx => wx.int_page_read_user))
                .ForMember(art => art.IntPageReadCount, conf => conf.MapFrom(wx => wx.int_page_read_count))
                .ForMember(art => art.OriPageReadUser, conf => conf.MapFrom(wx => wx.ori_page_read_user))
                .ForMember(art => art.OriPageReadCount, conf => conf.MapFrom(wx => wx.ori_page_read_count))
                .ForMember(art => art.ShareUser, conf => conf.MapFrom(wx => wx.share_user))
                .ForMember(art => art.ShareCount, conf => conf.MapFrom(wx => wx.share_count))
                .ForMember(art => art.AddToFavUser, conf => conf.MapFrom(wx => wx.add_to_fav_user))
                .ForMember(art => art.AddToFavCount, conf => conf.MapFrom(wx => wx.add_to_fav_count))
                .ForMember(art => art.IntPageFromSessionReadUser, conf => conf.MapFrom(wx => wx.int_page_from_session_read_user))
                .ForMember(art => art.IntPageFromSessionReadCount, conf => conf.MapFrom(wx => wx.int_page_from_session_read_count))
                .ForMember(art => art.IntPageFromHistMsgReadUser, conf => conf.MapFrom(wx => wx.int_page_from_hist_msg_read_user))
                .ForMember(art => art.IntPageFromHistMsgReadCount, conf => conf.MapFrom(wx => wx.int_page_from_hist_msg_read_count))
                .ForMember(art => art.IntPageFromFeedReadUser, conf => conf.MapFrom(wx => wx.int_page_from_feed_read_user))
                .ForMember(art => art.IntPageFromFeedReadCount, conf => conf.MapFrom(wx => wx.int_page_from_feed_read_count))
                .ForMember(art => art.IntPageFromFriendsReadUser, conf => conf.MapFrom(wx => wx.int_page_from_friends_read_user))
                .ForMember(art => art.IntPageFromFriendsReadCount, conf => conf.MapFrom(wx => wx.int_page_from_friends_read_count))
                .ForMember(art => art.IntPageFromOtherReadUser, conf => conf.MapFrom(wx => wx.int_page_from_other_read_user))
                .ForMember(art => art.IntPageFromOtherReadCount, conf => conf.MapFrom(wx => wx.int_page_from_other_read_count))
                .ForMember(art => art.FeedShareFromSessionUser, conf => conf.MapFrom(wx => wx.feed_share_from_session_user))
                .ForMember(art => art.FeedShareFromSessionCnt, conf => conf.MapFrom(wx => wx.feed_share_from_session_cnt))
                .ForMember(art => art.FeedShareFromFeedUser, conf => conf.MapFrom(wx => wx.feed_share_from_feed_user))
                .ForMember(art => art.FeedShareFromFeedCnt, conf => conf.MapFrom(wx => wx.feed_share_from_feed_cnt))
                .ForMember(art => art.FeedShareFromOtherUser, conf => conf.MapFrom(wx => wx.feed_share_from_other_user))
                .ForMember(art => art.FeedShareFromOtherCnt, conf => conf.MapFrom(wx => wx.feed_share_from_other_cnt));

            CreateMap<UserReadHourItem, WeChatStatisticsArticle>()
                .ForMember(art => art.RefDate, conf => conf.MapFrom(wx => wx.ref_date))
                .ForMember(art => art.RefHour, conf => conf.MapFrom(wx => wx.ref_hour))
                .ForMember(art => art.UserSource, conf => conf.MapFrom(wx => wx.user_source))
                .ForMember(art => art.IntPageReadUser, conf => conf.MapFrom(wx => wx.int_page_read_user))
                .ForMember(art => art.IntPageReadCount, conf => conf.MapFrom(wx => wx.int_page_read_count))
                .ForMember(art => art.OriPageReadUser, conf => conf.MapFrom(wx => wx.ori_page_read_user))
                .ForMember(art => art.OriPageReadCount, conf => conf.MapFrom(wx => wx.ori_page_read_count))
                .ForMember(art => art.ShareUser, conf => conf.MapFrom(wx => wx.share_user))
                .ForMember(art => art.ShareCount, conf => conf.MapFrom(wx => wx.share_count))
                .ForMember(art => art.AddToFavUser, conf => conf.MapFrom(wx => wx.add_to_fav_user))
                .ForMember(art => art.AddToFavCount, conf => conf.MapFrom(wx => wx.add_to_fav_count))
                .ForMember(art => art.AnalysisDataSourseType, conf => conf.Ignore());

            CreateMap<UserShareHourItem, WeChatStatisticsArticle>()
                .ForMember(art => art.RefDate, conf => conf.MapFrom(wx => wx.ref_date))
                .ForMember(art => art.RefHour, conf => conf.MapFrom(wx => wx.ref_hour))
                .ForMember(art => art.ShareScene, conf => conf.MapFrom(wx => wx.share_scene))
                .ForMember(art => art.ShareUser, conf => conf.MapFrom(wx => wx.share_user))
                .ForMember(art => art.ShareCount, conf => conf.MapFrom(wx => wx.share_count))
                .ForMember(art => art.AnalysisDataSourseType, conf => conf.Ignore());

            CreateMap<UserReadItem, WeChatStatisticsArticle>()
                .ForMember(art => art.RefDate, conf => conf.MapFrom(wx => wx.ref_date))
                .ForMember(art => art.UserSource, conf => conf.MapFrom(wx => wx.user_source))
                .ForMember(art => art.IntPageReadUser, conf => conf.MapFrom(wx => wx.int_page_read_user))
                .ForMember(art => art.IntPageReadCount, conf => conf.MapFrom(wx => wx.int_page_read_count))
                .ForMember(art => art.OriPageReadUser, conf => conf.MapFrom(wx => wx.ori_page_read_user))
                .ForMember(art => art.OriPageReadCount, conf => conf.MapFrom(wx => wx.ori_page_read_count))
                .ForMember(art => art.ShareUser, conf => conf.MapFrom(wx => wx.share_user))
                .ForMember(art => art.ShareCount, conf => conf.MapFrom(wx => wx.share_count))
                .ForMember(art => art.AddToFavUser, conf => conf.MapFrom(wx => wx.add_to_fav_user))
                .ForMember(art => art.AddToFavCount, conf => conf.MapFrom(wx => wx.add_to_fav_count))
                .ForMember(art => art.AnalysisDataSourseType, conf => conf.Ignore());

            CreateMap<UserShareItem, WeChatStatisticsArticle>()
                .ForMember(art => art.RefDate, conf => conf.MapFrom(wx => wx.ref_date))
                .ForMember(art => art.ShareUser, conf => conf.MapFrom(wx => wx.share_user))
                .ForMember(art => art.ShareCount, conf => conf.MapFrom(wx => wx.share_count))
                .ForMember(art => art.ShareScene, conf => conf.MapFrom(wx => wx.share_scene))
                .ForMember(art => art.AnalysisDataSourseType, conf => conf.Ignore());

            //WeChatStatisticsMsg
            CreateMap<UpStreamMsgHourItem, WeChatStatisticsMsg>()
                .ForMember(msg => msg.RefDate, conf => conf.MapFrom(wx => wx.ref_date))
                .ForMember(msg => msg.RefHour, conf => conf.MapFrom(wx => wx.ref_hour))
                .ForMember(msg => msg.MsgType, conf => conf.MapFrom(wx => wx.msg_type))
                .ForMember(msg => msg.MsgUser, conf => conf.MapFrom(wx => wx.msg_user))
                .ForMember(msg => msg.MsgCount, conf => conf.MapFrom(wx => wx.msg_count))
                .ForMember(msg => msg.AnalysisDataSourseType, conf => conf.Ignore());

            CreateMap<UpStreamMsgItem, WeChatStatisticsMsg>()
                .ForMember(msg => msg.RefDate, conf => conf.MapFrom(wx => wx.ref_date))
                .ForMember(msg => msg.MsgType, conf => conf.MapFrom(wx => wx.msg_type))
                .ForMember(msg => msg.MsgUser, conf => conf.MapFrom(wx => wx.msg_user))
                .ForMember(msg => msg.MsgCount, conf => conf.MapFrom(wx => wx.msg_count))
                .ForMember(msg => msg.AnalysisDataSourseType, conf => conf.Ignore());

            CreateMap<UpStreamMsgDistItem, WeChatStatisticsMsg>()
                .ForMember(msg => msg.RefDate, conf => conf.MapFrom(wx => wx.ref_date))
                .ForMember(msg => msg.CountInterval, conf => conf.MapFrom(wx => wx.count_interval))
                .ForMember(msg => msg.MsgUser, conf => conf.MapFrom(wx => wx.msg_user))
                .ForMember(msg => msg.AnalysisDataSourseType, conf => conf.Ignore());

            CreateMap<UpStreamMsgWeekItem, WeChatStatisticsMsg>()
                .ForMember(msg => msg.RefDate, conf => conf.MapFrom(wx => wx.ref_date))
                .ForMember(msg => msg.MsgType, conf => conf.MapFrom(wx => wx.msg_type))
                .ForMember(msg => msg.MsgUser, conf => conf.MapFrom(wx => wx.msg_user))
                .ForMember(msg => msg.MsgCount, conf => conf.MapFrom(wx => wx.msg_count))
                .ForMember(msg => msg.AnalysisDataSourseType, conf => conf.Ignore());

            CreateMap<UpStreamMsgMonthItem, WeChatStatisticsMsg>()
               .ForMember(msg => msg.RefDate, conf => conf.MapFrom(wx => wx.ref_date))
               .ForMember(msg => msg.MsgType, conf => conf.MapFrom(wx => wx.msg_type))
               .ForMember(msg => msg.MsgUser, conf => conf.MapFrom(wx => wx.msg_user))
               .ForMember(msg => msg.MsgCount, conf => conf.MapFrom(wx => wx.msg_count))
               .ForMember(msg => msg.AnalysisDataSourseType, conf => conf.Ignore());

            CreateMap<UpStreamMsgDistWeekItem, WeChatStatisticsMsg>()
                .ForMember(msg => msg.RefDate, conf => conf.MapFrom(wx => wx.ref_date))
                .ForMember(msg => msg.MsgUser, conf => conf.MapFrom(wx => wx.msg_user))
                .ForMember(msg => msg.CountInterval, conf => conf.MapFrom(wx => wx.count_interval))
                .ForMember(msg => msg.AnalysisDataSourseType, conf => conf.Ignore());

            CreateMap<UpStreamMsgDistMonthItem, WeChatStatisticsMsg>()
                .ForMember(msg => msg.RefDate, conf => conf.MapFrom(wx => wx.ref_date))
                .ForMember(msg => msg.MsgUser, conf => conf.MapFrom(wx => wx.msg_user))
                .ForMember(msg => msg.CountInterval, conf => conf.MapFrom(wx => wx.count_interval))
                .ForMember(msg => msg.AnalysisDataSourseType, conf => conf.Ignore());

            //WeChatStatisticsInterface
            CreateMap<InterfaceSummaryHourItem, WeChatStatisticsInterface>()
                .ForMember(inf => inf.RefDate, conf => conf.MapFrom(wx => wx.ref_date))
                .ForMember(inf => inf.RefHour, conf => conf.MapFrom(wx => wx.ref_hour))
                .ForMember(inf => inf.CallbackCount, conf => conf.MapFrom(wx => wx.callback_count))
                .ForMember(inf => inf.FailCount, conf => conf.MapFrom(wx => wx.fail_count))
                .ForMember(inf => inf.TotalTimeCost, conf => conf.MapFrom(wx => wx.total_time_cost))
                .ForMember(inf => inf.MaxTimeCost, conf => conf.MapFrom(wx => wx.max_time_cost))
                .ForMember(inf => inf.AnalysisDataSourseType, conf => conf.Ignore());

            CreateMap<InterfaceSummaryItem, WeChatStatisticsInterface>()
                .ForMember(inf => inf.RefDate, conf => conf.MapFrom(wx => wx.ref_date))
                .ForMember(inf => inf.CallbackCount, conf => conf.MapFrom(wx => wx.callback_count))
                .ForMember(inf => inf.FailCount, conf => conf.MapFrom(wx => wx.fail_count))
                .ForMember(inf => inf.TotalTimeCost, conf => conf.MapFrom(wx => wx.total_time_cost))
                .ForMember(inf => inf.MaxTimeCost, conf => conf.MapFrom(wx => wx.max_time_cost))
                .ForMember(inf => inf.AnalysisDataSourseType, conf => conf.Ignore());
        }

    }
}
