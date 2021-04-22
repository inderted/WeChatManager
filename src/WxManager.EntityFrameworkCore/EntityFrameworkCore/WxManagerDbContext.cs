using Microsoft.EntityFrameworkCore;
using WxManager.Users;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore.Modeling;
using Volo.Abp.Identity;
using Volo.Abp.Users.EntityFrameworkCore;
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
    /* This is your actual DbContext used on runtime.
     * It includes only your entities.
     * It does not include entities of the used modules, because each module has already
     * its own DbContext class. If you want to share some database tables with the used modules,
     * just create a structure like done for AppUser.
     *
     * Don't use this DbContext for database migrations since it does not contain tables of the
     * used modules (as explained above). See WxManagerMigrationsDbContext for migrations.
     */
    [ConnectionStringName("Default")]
    public class WxManagerDbContext : AbpDbContext<WxManagerDbContext>
    {
        #region DbSet

        /* Add DbSet properties for your Aggregate Roots / Entities here.
         * Also map them inside WxManagerDbContextModelCreatingExtensions.ConfigureWxManager
         */

        //public DbSet<AppUser> Users { get; set; }
        public DbSet<ApprovalDetail> ApprovalDetail { get; set; }
        public DbSet<ApprovalGroupInfo> ApprovalGroupInfo { get; set; }
        public DbSet<ApprovalGroup> ApprovalGroup { get; set; }
        public DbSet<ApprovalRule> ApprovalRule { get; set; }
        public DbSet<WeChatStatisticsArticleDetail> WeChatStatisticsArticleDetail { get; set; }
        public DbSet<WeChatStatisticsArticle> WeChatStatisticsArticle { get; set; }
        public DbSet<WeChatStatisticsInterface> WeChatStatisticsInterface { get; set; }
        public DbSet<WeChatStatisticsMsg> WeChatStatisticsMsg { get; set; }
        public DbSet<WeChatStatisticsUser> WeChatStatisticsUser { get; set; }
        public DbSet<WeChatAutoReply> WeChatAutoReply { get; set; }
        public DbSet<WeChatConfig> WeChatConfig { get; set; }
        public DbSet<WeChatMaterialNewsArticle> WeChatMaterialNewsArticle { get; set; }
        public DbSet<WeChatMaterialNews> WeChatMaterialNews { get; set; }
        public DbSet<WeChatMaterialNewsVersion> WeChatMaterialNewsVersion { get; set; }
        public DbSet<WeChatMedia> WeChatMedia { get; set; }
        public DbSet<WeChatNews> WeChatNews { get; set; }
        public DbSet<WeChatTempMedia> WeChatTempMedia { get; set; }
        public DbSet<WeChatMenu> WeChatMenu { get; set; }
        public DbSet<WeChatMessage> WeChatMessage { get; set; }
        public DbSet<WeChatMessageNotify> WeChatMessageNotify { get; set; }
        public DbSet<WeChatQrCode> WeChatQrCode { get; set; }
        public DbSet<WeChatQrCodeRecord> WeChatQrCodeRecord { get; set; }
        public DbSet<WeChatSendRecord> WeChatSendRecord { get; set; }
        public DbSet<WeChatSyncRecord> WeChatSyncRecord { get; set; }
        public DbSet<WeChatTag> WeChatTag { get; set; }
        public DbSet<WeChatToDoList> WeChatToDoList { get; set; }
        public DbSet<WeChatUser> WeChatUser { get; set; }
        public DbSet<WeChatUserTag> WeChatUserTag { get; set; }

        #endregion

        public WxManagerDbContext(DbContextOptions<WxManagerDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            /* Configure the shared tables (with included modules) here */

            builder.Entity<AppUser>(b =>
            {
                b.ToTable(AbpIdentityDbProperties.DbTablePrefix + "Users"); //Sharing the same table "AbpUsers" with the IdentityUser

                b.ConfigureByConvention();
                b.ConfigureAbpUser();

                /* Configure mappings for your additional properties
                 * Also see the WxManagerEfCoreEntityExtensionMappings class
                 */
            });

            /* Configure your own tables/entities inside the ConfigureWxManager method */

            builder.ConfigureWxManager();
        }
    }
}
