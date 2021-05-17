using Volo.Abp.ObjectMapping;
using WxManager.Application.Contracts.WeChatManager.ApprovalGroups;
using WxManager.Application.Contracts.WeChatManager.WeChatConfigs;
using WxManager.Application.Contracts.WeChatManager.WeChatTags;
using WxManager.WeChatManager.ApprovalGroups;
using WxManager.WeChatManager.WeChatConfigs;
using WxManager.WeChatManager.WeChatTags;
using WxManager.WeChatManager.ApprovalRules;
using WxManager.WeChatManager.WeChatAnalysis;
using WxManager.WeChatManager.WeChatAutoReplys;
using WxManager.WeChatManager.WeChatMaterial;
using WxManager.WeChatManager.WeChatMedias;
using WxManager.WeChatManager.WeChatMenus;
using WxManager.WeChatManager.WeChatMessages;
using WxManager.WeChatManager.WeChatQrCodes;
using WxManager.WeChatManager.WeChatSendRecords;
using WxManager.WeChatManager.WeChatSyncRecords;
using WxManager.WeChatManager.WeChatToDoLists;
using WxManager.WeChatManager.WeChatUsers;
using WxManager.Application.Contracts.WeChatManager.WeChatSyncRecords;
using WxManager.Application.Contracts.WeChatManager.WeChatMessages;
using WxManager.Application.Contracts.WeChatManager.WeChatMenus;
using WxManager.Application.Contracts.WeChatManager.WeChatMedias;
using WxManager.Application.Contracts.WeChatManager.WeChatQrCodes;
using WxManager.Application.Contracts.WeChatManager.WeChatToDoLists;
using WxManager.Application.Contracts.WeChatManager.WeChatSendRecords;
using WxManager.Application.Contracts.WeChatManager.WeChatAutoReplys;
using WxManager.Application.Contracts.WeChatManager.ApprovalRules;
using WxManager.Application.Contracts.WeChatManager.WeChatMaterial;
using WxManager.Application.Contracts.WeChatManager.WeChatAnalysis;
using WxManager.Application.Contracts.WeChatManager.WeChatUsers;
using Senparc.Weixin.MP.AdvancedAPIs.UserTag;
using Senparc.Weixin.MP.AdvancedAPIs.User;

namespace WxManager.Application.Extensions
{
    public static class AutoMapperExtensions
    {

        public static TDestination MapTo<TSource, TDestination>(this TSource source, IObjectMapper ObjectMapper)
        {
            return ObjectMapper.Map<TSource, TDestination>(source);
        }

        public static TDestination MapTo<TSource, TDestination>(this TSource source, TDestination destination, IObjectMapper ObjectMapper)
        {
            return ObjectMapper.Map(source, destination);
        }


        #region ApprovalGroupInfo

        public static ApprovalGroupInfoModel ToModel(this ApprovalGroupInfo entity, IObjectMapper ObjectMapper)
        {
            return entity.MapTo<ApprovalGroupInfo, ApprovalGroupInfoModel>(ObjectMapper);
        }

        public static ApprovalGroupInfo ToEntity(this ApprovalGroupInfoModel model, ApprovalGroupInfo destination, IObjectMapper ObjectMapper)
        {
            return model.MapTo(destination, ObjectMapper);
        }

        #endregion ApprovalGroupInfo

        #region ApprovalGroup

        public static ApprovalGroupModel ToModel(this ApprovalGroup entity, IObjectMapper ObjectMapper)
        {
            return entity.MapTo<ApprovalGroup, ApprovalGroupModel>(ObjectMapper);
        }

        public static ApprovalGroup ToEntity(this ApprovalGroupModel model, ApprovalGroup destination, IObjectMapper ObjectMapper)
        {
            return model.MapTo(destination, ObjectMapper);
        }

        #endregion ApprovalGroup

        #region WeChatConfig

        public static WeChatConfigModel ToModel(this WeChatConfig entity, IObjectMapper ObjectMapper)
        {
            return entity.MapTo<WeChatConfig, WeChatConfigModel>(ObjectMapper);
        }

        public static WeChatConfig ToEntity(this WeChatConfigModel model, WeChatConfig destination, IObjectMapper ObjectMapper)
        {
            return model.MapTo(destination, ObjectMapper);
        }

        #endregion WeChatConfig

        #region WeChatTag

        public static WeChatTagModel ToModel(this WeChatTag entity, IObjectMapper ObjectMapper)
        {
            return entity.MapTo<WeChatTag, WeChatTagModel>(ObjectMapper);
        }

        public static WeChatTag ToEntity(this WeChatTagModel model, WeChatTag destination, IObjectMapper ObjectMapper)
        {
            return model.MapTo(destination, ObjectMapper);
        }

        public static WeChatTag ToEntity(this TagJson_Tag model, WeChatTag destination, IObjectMapper ObjectMapper)
        {
            return model.MapTo(destination, ObjectMapper);
        }

        #endregion WeChatTag

        #region WeChatUser

        public static WeChatUserModel ToModel(this WeChatUser entity, IObjectMapper ObjectMapper)
        {
            return entity.MapTo<WeChatUser, WeChatUserModel>(ObjectMapper);
        }

        public static WeChatUser ToEntity(this WeChatUserModel model, WeChatUser destination, IObjectMapper ObjectMapper)
        {
            return model.MapTo(destination, ObjectMapper);
        }

        public static WeChatUser ToEntity(this UserInfoJson model, WeChatUser destination, IObjectMapper ObjectMapper)
        {
            return model.MapTo(destination, ObjectMapper);
        }

        #endregion WeChatUser

        #region WeChatSyncRecord

        public static WeChatSyncRecordModel ToModel(this WeChatSyncRecord entity, IObjectMapper ObjectMapper)
        {
            return entity.MapTo<WeChatSyncRecord, WeChatSyncRecordModel>(ObjectMapper);
        }

        public static WeChatSyncRecord ToEntity(this WeChatSyncRecordModel model, WeChatSyncRecord destination, IObjectMapper ObjectMapper)
        {
            return model.MapTo(destination, ObjectMapper);
        }

        #endregion WeChatSyncRecord

        #region WeChatMessage

        public static WeChatMessageModel ToModel(this WeChatMessage entity, IObjectMapper ObjectMapper)
        {
            return entity.MapTo<WeChatMessage, WeChatMessageModel>(ObjectMapper);
        }

        public static WeChatMessage ToEntity(this WeChatMessageModel model, WeChatMessage destination, IObjectMapper ObjectMapper)
        {
            return model.MapTo(destination, ObjectMapper);
        }

        #endregion WeChatMessage

        #region WeChatMenu

        public static WeChatMenuModel ToModel(this WeChatMenu entity, IObjectMapper ObjectMapper)
        {
            return entity.MapTo<WeChatMenu, WeChatMenuModel>(ObjectMapper);
        }

        public static WeChatMenu ToEntity(this WeChatMenuModel model, WeChatMenu destination, IObjectMapper ObjectMapper)
        {
            return model.MapTo(destination, ObjectMapper);
        }

        #endregion WeChatMenu

        #region WeChatMedia

        public static WeChatMediaModel ToModel(this WeChatMedia entity, IObjectMapper ObjectMapper)
        {
            return entity.MapTo<WeChatMedia, WeChatMediaModel>(ObjectMapper);
        }

        public static WeChatMedia ToEntity(this WeChatMediaModel model, WeChatMedia destination, IObjectMapper ObjectMapper)
        {
            return model.MapTo(destination, ObjectMapper);
        }

        #endregion WeChatMedia

        #region WeChatNews

        public static WeChatNewsModel ToModel(this WeChatNews entity, IObjectMapper ObjectMapper)
        {
            return entity.MapTo<WeChatNews, WeChatNewsModel>(ObjectMapper);
        }

        public static WeChatNews ToEntity(this WeChatNewsModel model, WeChatNews destination, IObjectMapper ObjectMapper)
        {
            return model.MapTo(destination, ObjectMapper);
        }

        #endregion WeChatNews

        #region WeChatQrCode

        public static WeChatQrCodeModel ToModel(this WeChatQrCode entity, IObjectMapper ObjectMapper)
        {
            return entity.MapTo<WeChatQrCode, WeChatQrCodeModel>(ObjectMapper);
        }

        public static WeChatQrCode ToEntity(this WeChatQrCodeModel model, WeChatQrCode destination, IObjectMapper ObjectMapper)
        {
            return model.MapTo(destination, ObjectMapper);
        }

        #endregion WeChatQrCode

        #region WeChatQrCodeRecord

        public static WeChatQrCodeRecordModel ToModel(this WeChatQrCodeRecord entity, IObjectMapper ObjectMapper)
        {
            return entity.MapTo<WeChatQrCodeRecord, WeChatQrCodeRecordModel>(ObjectMapper);
        }

        public static WeChatQrCodeRecord ToEntity(this WeChatQrCodeRecordModel model, WeChatQrCodeRecord destination, IObjectMapper ObjectMapper)
        {
            return model.MapTo(destination, ObjectMapper);
        }

        #endregion WeChatQrCodeRecord

        #region WeChatToDoList

        public static WeChatToDoListModel ToModel(this WeChatToDoList entity, IObjectMapper ObjectMapper)
        {
            return entity.MapTo<WeChatToDoList, WeChatToDoListModel>(ObjectMapper);
        }

        public static WeChatToDoList ToEntity(this WeChatToDoListModel model, WeChatToDoList destination, IObjectMapper ObjectMapper)
        {
            return model.MapTo(destination, ObjectMapper);
        }

        #endregion WeChatToDoList

        #region WeChatSendRecord

        public static WeChatSendRecordModel ToModel(this WeChatSendRecord entity, IObjectMapper ObjectMapper)
        {
            return entity.MapTo<WeChatSendRecord, WeChatSendRecordModel>(ObjectMapper);
        }

        public static WeChatSendRecord ToEntity(this WeChatSendRecordModel model, WeChatSendRecord destination, IObjectMapper ObjectMapper)
        {
            return model.MapTo(destination, ObjectMapper);
        }

        #endregion WeChatSendRecord

        #region WeChatMessageNotify

        public static WeChatMessageNotifyModel ToModel(this WeChatMessageNotify entity, IObjectMapper ObjectMapper)
        {
            return entity.MapTo<WeChatMessageNotify, WeChatMessageNotifyModel>(ObjectMapper);
        }

        public static WeChatMessageNotify ToEntity(this WeChatMessageNotifyModel model, WeChatMessageNotify destination, IObjectMapper ObjectMapper)
        {
            return model.MapTo(destination, ObjectMapper);
        }

        #endregion WeChatMessageNotify

        #region WeChatAutoReplay

        public static WeChatAutoReplyModel ToModel(this WeChatAutoReply entity, IObjectMapper ObjectMapper)
        {
            return entity.MapTo<WeChatAutoReply, WeChatAutoReplyModel>(ObjectMapper);
        }

        public static WeChatAutoReply ToEntity(this WeChatAutoReplyModel model, WeChatAutoReply destination, IObjectMapper ObjectMapper)
        {
            return model.MapTo(destination, ObjectMapper);
        }

        #endregion WeChatAutoReplay
        #region ApprovalRule
        public static ApprovalRuleModel ToModel(this ApprovalRule entity, IObjectMapper ObjectMapper)
        {
            return entity.MapTo<ApprovalRule, ApprovalRuleModel>(ObjectMapper);
        }

        public static ApprovalRule ToEntity(this ApprovalRuleModel model, ApprovalRule destination, IObjectMapper ObjectMapper)
        {
            return model.MapTo(destination, ObjectMapper);
        }

        #endregion

        #region WeChatMaterialNews

        public static WeChatMaterialNewsModel ToModel(this WeChatMaterialNews entity, IObjectMapper ObjectMapper)
        {
            return entity.MapTo<WeChatMaterialNews, WeChatMaterialNewsModel>(ObjectMapper);
        }

        public static WeChatMaterialNews ToEntity(this WeChatMaterialNewsModel model, WeChatMaterialNews destination, IObjectMapper ObjectMapper)
        {
            return model.MapTo(destination, ObjectMapper);
        }

        public static WeChatMaterialNewsVersionModel ToModel(this WeChatMaterialNewsVersion entity, IObjectMapper ObjectMapper)
        {
            return entity.MapTo<WeChatMaterialNewsVersion, WeChatMaterialNewsVersionModel>(ObjectMapper);
        }

        public static WeChatMaterialNewsVersion ToEntity(this WeChatMaterialNewsVersionModel model, WeChatMaterialNewsVersion destination, IObjectMapper ObjectMapper)
        {
            return model.MapTo(destination, ObjectMapper);
        }

        public static WeChatMaterialNewsArticleModel ToModel(this WeChatMaterialNewsArticle entity, IObjectMapper ObjectMapper)
        {
            return entity.MapTo<WeChatMaterialNewsArticle, WeChatMaterialNewsArticleModel>(ObjectMapper);
        }

        public static WeChatMaterialNewsArticle ToEntity(this WeChatMaterialNewsArticleModel model, WeChatMaterialNewsArticle destination, IObjectMapper ObjectMapper)
        {
            return model.MapTo(destination, ObjectMapper);
        }

        #endregion

        #region WeChatAnalysis

        public static WeChatStatisticsArticleModel ToModel(this WeChatStatisticsArticle entity, IObjectMapper ObjectMapper)
        {
            return entity.MapTo<WeChatStatisticsArticle, WeChatStatisticsArticleModel>(ObjectMapper);
        }

        public static WeChatStatisticsArticleDetailModel ToModel(this WeChatStatisticsArticleDetail entity, IObjectMapper ObjectMapper)
        {
            return entity.MapTo<WeChatStatisticsArticleDetail, WeChatStatisticsArticleDetailModel>(ObjectMapper);
        }

        public static WeChatStatisticsInterfaceModel ToModel(this WeChatStatisticsInterface entity, IObjectMapper ObjectMapper)
        {
            return entity.MapTo<WeChatStatisticsInterface, WeChatStatisticsInterfaceModel>(ObjectMapper);
        }

        public static WeChatStatisticsMsgModel ToModel(this WeChatStatisticsMsg entity, IObjectMapper ObjectMapper)
        {
            return entity.MapTo<WeChatStatisticsMsg, WeChatStatisticsMsgModel>(ObjectMapper);
        }

        public static WeChatStatisticsUserModel ToModel(this WeChatStatisticsUser entity, IObjectMapper ObjectMapper)
        {
            return entity.MapTo<WeChatStatisticsUser, WeChatStatisticsUserModel>(ObjectMapper);
        }

        #endregion
    }
}
