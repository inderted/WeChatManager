using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WxManager.Migrations
{
    public partial class init_WeChatManager : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AbpAuditLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    ApplicationName = table.Column<string>(type: "varchar(96)", maxLength: 96, nullable: true),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true),
                    TenantName = table.Column<string>(type: "longtext", nullable: true),
                    ImpersonatorUserId = table.Column<Guid>(type: "char(36)", nullable: true),
                    ImpersonatorTenantId = table.Column<Guid>(type: "char(36)", nullable: true),
                    ExecutionTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ExecutionDuration = table.Column<int>(type: "int", nullable: false),
                    ClientIpAddress = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    ClientName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true),
                    ClientId = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    CorrelationId = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    BrowserInfo = table.Column<string>(type: "varchar(512)", maxLength: 512, nullable: true),
                    HttpMethod = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: true),
                    Url = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    Exceptions = table.Column<string>(type: "longtext", maxLength: 4000, nullable: true),
                    Comments = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    HttpStatusCode = table.Column<int>(type: "int", nullable: true),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpAuditLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpBackgroundJobs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    JobName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    JobArgs = table.Column<string>(type: "longtext", maxLength: 1048576, nullable: false),
                    TryCount = table.Column<short>(type: "smallint", nullable: false, defaultValue: (short)0),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    NextTryTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    LastTryTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    IsAbandoned = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    Priority = table.Column<byte>(type: "tinyint unsigned", nullable: false, defaultValue: (byte)15),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpBackgroundJobs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpClaimTypes",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false),
                    Required = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsStatic = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Regex = table.Column<string>(type: "varchar(512)", maxLength: 512, nullable: true),
                    RegexDescription = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true),
                    Description = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    ValueType = table.Column<int>(type: "int", nullable: false),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpClaimTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpFeatureValues",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    ProviderName = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    ProviderKey = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpFeatureValues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpLinkUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    SourceUserId = table.Column<Guid>(type: "char(36)", nullable: false),
                    SourceTenantId = table.Column<Guid>(type: "char(36)", nullable: true),
                    TargetUserId = table.Column<Guid>(type: "char(36)", nullable: false),
                    TargetTenantId = table.Column<Guid>(type: "char(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpLinkUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpOrganizationUnits",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true),
                    ParentId = table.Column<Guid>(type: "char(36)", nullable: true),
                    Code = table.Column<string>(type: "varchar(95)", maxLength: 95, nullable: false),
                    DisplayName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "char(36)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "char(36)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpOrganizationUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpOrganizationUnits_AbpOrganizationUnits_ParentId",
                        column: x => x.ParentId,
                        principalTable: "AbpOrganizationUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AbpPermissionGrants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    ProviderName = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    ProviderKey = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpPermissionGrants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false),
                    IsDefault = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsStatic = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsPublic = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpSecurityLogs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true),
                    ApplicationName = table.Column<string>(type: "varchar(96)", maxLength: 96, nullable: true),
                    Identity = table.Column<string>(type: "varchar(96)", maxLength: 96, nullable: true),
                    Action = table.Column<string>(type: "varchar(96)", maxLength: 96, nullable: true),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: true),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    TenantName = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    ClientId = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    CorrelationId = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    ClientIpAddress = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    BrowserInfo = table.Column<string>(type: "varchar(512)", maxLength: 512, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpSecurityLogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpSettings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    Value = table.Column<string>(type: "longtext", maxLength: 2048, nullable: false),
                    ProviderName = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    ProviderKey = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpTenants",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "char(36)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "char(36)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpTenants", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpUsers",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true),
                    UserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false),
                    NormalizedUserName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false),
                    Name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    Surname = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: true),
                    Email = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    PasswordHash = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    SecurityStamp = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false),
                    IsExternal = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    PhoneNumber = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    TwoFactorEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetime(6)", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "varchar(40)", maxLength: 40, nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "char(36)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "tinyint(1)", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "char(36)", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApprovalGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ApprovalGroupName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    CreatedTimeUtc = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedById = table.Column<int>(type: "int", nullable: false),
                    UpdatedTimeUtc = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprovalGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeChatConfig",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WeChatName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    WeChatId = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    WeChatToken = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    WeChatAppId = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    WeChatAppSecret = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    EncodingAESKey = table.Column<string>(type: "varchar(512)", maxLength: 512, nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false),
                    Deleted = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NotifyTemplateId = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatConfig", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeChatStatisticsArticle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    DataSourceId = table.Column<int>(type: "int", nullable: false),
                    WeChatConfigId = table.Column<int>(type: "int", nullable: false),
                    RefDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    RefHour = table.Column<int>(type: "int", nullable: true),
                    MsgId = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
                    Title = table.Column<string>(type: "varchar(45)", maxLength: 45, nullable: true),
                    IntPageReadUser = table.Column<int>(type: "int", nullable: true),
                    IntPageReadCount = table.Column<int>(type: "int", nullable: true),
                    OriPageReadUser = table.Column<int>(type: "int", nullable: true),
                    OriPageReadCount = table.Column<int>(type: "int", nullable: true),
                    ShareScene = table.Column<int>(type: "int", nullable: true),
                    ShareUser = table.Column<int>(type: "int", nullable: true),
                    ShareCount = table.Column<int>(type: "int", nullable: true),
                    AddToFavUser = table.Column<int>(type: "int", nullable: true),
                    AddToFavCount = table.Column<int>(type: "int", nullable: true),
                    UserSource = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatStatisticsArticle", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeChatStatisticsInterface",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RefDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    WeChatConfigId = table.Column<int>(type: "int", nullable: false),
                    DataSourceId = table.Column<int>(type: "int", nullable: false),
                    RefHour = table.Column<int>(type: "int", nullable: true),
                    CallbackCount = table.Column<int>(type: "int", nullable: true),
                    FailCount = table.Column<int>(type: "int", nullable: true),
                    TotalTimeCost = table.Column<int>(type: "int", nullable: true),
                    MaxTimeCost = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatStatisticsInterface", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeChatStatisticsMsg",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RefDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    WeChatConfigId = table.Column<int>(type: "int", nullable: false),
                    DataSourceId = table.Column<int>(type: "int", nullable: false),
                    RefHour = table.Column<int>(type: "int", nullable: true),
                    MsgType = table.Column<int>(type: "int", nullable: true),
                    MsgUser = table.Column<int>(type: "int", nullable: true),
                    MsgCount = table.Column<int>(type: "int", nullable: true),
                    CountInterval = table.Column<int>(type: "int", nullable: true),
                    IntPageReadCount = table.Column<int>(type: "int", nullable: true),
                    OriPageReadUser = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatStatisticsMsg", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeChatStatisticsUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    RefDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    WeChatConfigId = table.Column<int>(type: "int", nullable: false),
                    DataSourceId = table.Column<int>(type: "int", nullable: false),
                    UserSource = table.Column<int>(type: "int", nullable: true),
                    NewUser = table.Column<int>(type: "int", nullable: true),
                    CancelUser = table.Column<int>(type: "int", nullable: true),
                    CumulateUser = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatStatisticsUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeChatTag",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WeChatConfigId = table.Column<int>(type: "int", nullable: false),
                    WeChatId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: false),
                    Count = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatTag", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeChatToDoList",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    OverTimeUtc = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Important = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Description = table.Column<string>(type: "longtext", nullable: true),
                    WeChatUserId = table.Column<int>(type: "int", nullable: false),
                    CreatedByCustomerId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ClosedByCustomerId = table.Column<int>(type: "int", nullable: true),
                    ClosedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    ClosedNote = table.Column<string>(type: "longtext", nullable: true),
                    ToDoStatusId = table.Column<int>(type: "int", nullable: false),
                    WeChatConfigId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatToDoList", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeChatUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    WeChatConfigId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    OpenId = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    Subscribe = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    NickName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    City = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Country = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Province = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    Language = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    HeadImgUrl = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true),
                    FirstSubscribeTimeUtc = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    SubscribeTimeUtc = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UnSubscribeTimeUtc = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UnionId = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Remark = table.Column<string>(type: "varchar(30)", maxLength: 30, nullable: true),
                    WeChatGroupId = table.Column<int>(type: "int", nullable: false),
                    BlackUser = table.Column<bool>(type: "tinyint(1)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AbpAuditLogActions",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true),
                    AuditLogId = table.Column<Guid>(type: "char(36)", nullable: false),
                    ServiceName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: true),
                    MethodName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true),
                    Parameters = table.Column<string>(type: "varchar(2000)", maxLength: 2000, nullable: true),
                    ExecutionTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ExecutionDuration = table.Column<int>(type: "int", nullable: false),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpAuditLogActions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpAuditLogActions_AbpAuditLogs_AuditLogId",
                        column: x => x.AuditLogId,
                        principalTable: "AbpAuditLogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpEntityChanges",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    AuditLogId = table.Column<Guid>(type: "char(36)", nullable: false),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true),
                    ChangeTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ChangeType = table.Column<byte>(type: "tinyint unsigned", nullable: false),
                    EntityTenantId = table.Column<Guid>(type: "char(36)", nullable: true),
                    EntityId = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    EntityTypeFullName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    ExtraProperties = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpEntityChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpEntityChanges_AbpAuditLogs_AuditLogId",
                        column: x => x.AuditLogId,
                        principalTable: "AbpAuditLogs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpOrganizationUnitRoles",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(type: "char(36)", nullable: false),
                    OrganizationUnitId = table.Column<Guid>(type: "char(36)", nullable: false),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpOrganizationUnitRoles", x => new { x.OrganizationUnitId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AbpOrganizationUnitRoles_AbpOrganizationUnits_OrganizationUn~",
                        column: x => x.OrganizationUnitId,
                        principalTable: "AbpOrganizationUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AbpOrganizationUnitRoles_AbpRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AbpRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpRoleClaims",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    RoleId = table.Column<Guid>(type: "char(36)", nullable: false),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true),
                    ClaimType = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false),
                    ClaimValue = table.Column<string>(type: "varchar(1024)", maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpRoleClaims_AbpRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AbpRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpTenantConnectionStrings",
                columns: table => new
                {
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: false),
                    Name = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    Value = table.Column<string>(type: "varchar(1024)", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpTenantConnectionStrings", x => new { x.TenantId, x.Name });
                    table.ForeignKey(
                        name: "FK_AbpTenantConnectionStrings_AbpTenants_TenantId",
                        column: x => x.TenantId,
                        principalTable: "AbpTenants",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpUserClaims",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true),
                    ClaimType = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false),
                    ClaimValue = table.Column<string>(type: "varchar(1024)", maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpUserClaims_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true),
                    ProviderKey = table.Column<string>(type: "varchar(196)", maxLength: 196, nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUserLogins", x => new { x.UserId, x.LoginProvider });
                    table.ForeignKey(
                        name: "FK_AbpUserLogins_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpUserOrganizationUnits",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false),
                    OrganizationUnitId = table.Column<Guid>(type: "char(36)", nullable: false),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true),
                    CreationTime = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatorId = table.Column<Guid>(type: "char(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUserOrganizationUnits", x => new { x.OrganizationUnitId, x.UserId });
                    table.ForeignKey(
                        name: "FK_AbpUserOrganizationUnits_AbpOrganizationUnits_OrganizationUn~",
                        column: x => x.OrganizationUnitId,
                        principalTable: "AbpOrganizationUnits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AbpUserOrganizationUnits_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false),
                    RoleId = table.Column<Guid>(type: "char(36)", nullable: false),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AbpUserRoles_AbpRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AbpRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AbpUserRoles_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "char(36)", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false),
                    Name = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true),
                    Value = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AbpUserTokens_AbpUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AbpUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApprovalGroupInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ApprovalGroupId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    CreatedTimeUtc = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprovalGroupInfo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApprovalGroupInfo_ApprovalGroup_ApprovalGroupId",
                        column: x => x.ApprovalGroupId,
                        principalTable: "ApprovalGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApprovalRule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    ApprovalRuleStatusId = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedByCustomerId = table.Column<int>(type: "int", nullable: false),
                    UpdateOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    UpdateByCustomerId = table.Column<int>(type: "int", nullable: true),
                    ApprovalRuleTypeId = table.Column<int>(type: "int", nullable: false),
                    RuleJson = table.Column<string>(type: "longtext", nullable: true),
                    ApprovalGroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprovalRule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApprovalRule_ApprovalGroup_ApprovalGroupId",
                        column: x => x.ApprovalGroupId,
                        principalTable: "ApprovalGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeChatAutoReply",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    HalfKeyWords = table.Column<string>(type: "longtext", nullable: true),
                    FullKeyWords = table.Column<string>(type: "longtext", nullable: true),
                    ReplayTypeId = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "longtext", nullable: true),
                    IsSubscribe = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    IsDefault = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    WeChatConfigId = table.Column<int>(type: "int", nullable: false),
                    IsPublish = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatAutoReply", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeChatAutoReply_WeChatConfig_WeChatConfigId",
                        column: x => x.WeChatConfigId,
                        principalTable: "WeChatConfig",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeChatMedia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WeChatConfigId = table.Column<int>(type: "int", nullable: false),
                    MediaId = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    FileName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    MediaTypeId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Introduction = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Content = table.Column<string>(type: "longtext", nullable: true),
                    Url = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    UpdateTimeUtc = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeChatMedia_WeChatConfig_WeChatConfigId",
                        column: x => x.WeChatConfigId,
                        principalTable: "WeChatConfig",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeChatMenu",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WeChatConfigId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    PersonaliseMenu = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MenuId = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Published = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Content = table.Column<string>(type: "longtext", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatMenu", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeChatMenu_WeChatConfig_WeChatConfigId",
                        column: x => x.WeChatConfigId,
                        principalTable: "WeChatConfig",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeChatMessageNotify",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WeChatConfigId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CustomerOpenId = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Interval = table.Column<int>(type: "int", nullable: false),
                    Enable = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatMessageNotify", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeChatMessageNotify_WeChatConfig_WeChatConfigId",
                        column: x => x.WeChatConfigId,
                        principalTable: "WeChatConfig",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeChatSendRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WeChatConfigId = table.Column<int>(type: "int", nullable: false),
                    MsgId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    MsgDataId = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: true),
                    MsgTypeId = table.Column<int>(type: "int", nullable: false),
                    MediaId = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    WeChatTagId = table.Column<int>(type: "int", nullable: true),
                    MsgStatus = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    ErrorMsg = table.Column<string>(type: "longtext", nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatSendRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeChatSendRecord_WeChatConfig_WeChatConfigId",
                        column: x => x.WeChatConfigId,
                        principalTable: "WeChatConfig",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeChatSyncRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WeChatConfigId = table.Column<int>(type: "int", nullable: false),
                    RecordTypeId = table.Column<int>(type: "int", nullable: false),
                    SyncQuantity = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "longtext", nullable: true),
                    SyncStatusId = table.Column<int>(type: "int", nullable: false),
                    StartTimeUtc = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    EndTimeUtc = table.Column<DateTime>(type: "datetime(6)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatSyncRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeChatSyncRecord_WeChatConfig_WeChatConfigId",
                        column: x => x.WeChatConfigId,
                        principalTable: "WeChatConfig",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeChatTempMedia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WeChatConfigId = table.Column<int>(type: "int", nullable: false),
                    FileName = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Content = table.Column<byte[]>(type: "longblob", nullable: false),
                    UploadMediaFileTypeId = table.Column<int>(type: "int", nullable: false),
                    WeChatMessageId = table.Column<int>(type: "int", nullable: true),
                    FromUserOpenId = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    MediaId = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Url = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatTempMedia", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeChatTempMedia_WeChatConfig_WeChatConfigId",
                        column: x => x.WeChatConfigId,
                        principalTable: "WeChatConfig",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeChatStatisticsArticleDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WeChatStatisticsArticleId = table.Column<int>(type: "int", nullable: false),
                    StatDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    IntPageReadUser = table.Column<int>(type: "int", nullable: true),
                    IntPageReadCount = table.Column<int>(type: "int", nullable: true),
                    OriPageReadUser = table.Column<int>(type: "int", nullable: true),
                    OriPageReadCount = table.Column<int>(type: "int", nullable: true),
                    ShareUser = table.Column<int>(type: "int", nullable: true),
                    ShareCount = table.Column<int>(type: "int", nullable: true),
                    AddToFavUser = table.Column<int>(type: "int", nullable: true),
                    AddToFavCount = table.Column<int>(type: "int", nullable: true),
                    TargetUser = table.Column<int>(type: "int", nullable: true),
                    IntPageFromSessionReadUser = table.Column<int>(type: "int", nullable: true),
                    IntPageFromSessionReadCount = table.Column<int>(type: "int", nullable: true),
                    IntPageFromHistMsgReadUser = table.Column<int>(type: "int", nullable: true),
                    IntPageFromHistMsgReadCount = table.Column<int>(type: "int", nullable: true),
                    IntPageFromFeedReadUser = table.Column<int>(type: "int", nullable: true),
                    IntPageFromFeedReadCount = table.Column<int>(type: "int", nullable: true),
                    IntPageFromFriendsReadUser = table.Column<int>(type: "int", nullable: true),
                    IntPageFromFriendsReadCount = table.Column<int>(type: "int", nullable: true),
                    IntPageFromOtherReadUser = table.Column<int>(type: "int", nullable: true),
                    IntPageFromOtherReadCount = table.Column<int>(type: "int", nullable: true),
                    FeedShareFromSessionUser = table.Column<int>(type: "int", nullable: true),
                    FeedShareFromSessionCnt = table.Column<int>(type: "int", nullable: true),
                    FeedShareFromFeedUser = table.Column<int>(type: "int", nullable: true),
                    FeedShareFromFeedCnt = table.Column<int>(type: "int", nullable: true),
                    FeedShareFromOtherUser = table.Column<int>(type: "int", nullable: true),
                    FeedShareFromOtherCnt = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatStatisticsArticleDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeChatStatisticsArticleDetail_WeChatStatisticsArticle_WeChat~",
                        column: x => x.WeChatStatisticsArticleId,
                        principalTable: "WeChatStatisticsArticle",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeChatQrCode",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Expire = table.Column<int>(type: "int", nullable: true),
                    ActionNameId = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    SceneId = table.Column<int>(type: "int", nullable: false),
                    SceneStr = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Url = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    Ticket = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Name = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    WeChatTagId = table.Column<int>(type: "int", nullable: true),
                    WeChatConfigId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatQrCode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeChatQrCode_WeChatConfig_WeChatConfigId",
                        column: x => x.WeChatConfigId,
                        principalTable: "WeChatConfig",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeChatQrCode_WeChatTag_WeChatTagId",
                        column: x => x.WeChatTagId,
                        principalTable: "WeChatTag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeChatMessage",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WeChatConfigId = table.Column<int>(type: "int", nullable: false),
                    UserOpenId = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    WeChatUserId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    Content = table.Column<string>(type: "longtext", nullable: false),
                    IsRead = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    MsgType = table.Column<int>(type: "int", nullable: false),
                    ContentTypeId = table.Column<int>(type: "int", nullable: false),
                    SendTimeUtc = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatMessage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeChatMessage_WeChatConfig_WeChatConfigId",
                        column: x => x.WeChatConfigId,
                        principalTable: "WeChatConfig",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeChatMessage_WeChatUser_WeChatUserId",
                        column: x => x.WeChatUserId,
                        principalTable: "WeChatUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeChatUser_WeChatTag_Mapping",
                columns: table => new
                {
                    WeChatUserId = table.Column<int>(type: "int", nullable: false),
                    WeChatTagId = table.Column<int>(type: "int", nullable: false),
                    Id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatUser_WeChatTag_Mapping", x => new { x.WeChatTagId, x.WeChatUserId });
                    table.ForeignKey(
                        name: "FK_WeChatUser_WeChatTag_Mapping_WeChatTag_WeChatTagId",
                        column: x => x.WeChatTagId,
                        principalTable: "WeChatTag",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_WeChatUser_WeChatTag_Mapping_WeChatUser_WeChatUserId",
                        column: x => x.WeChatUserId,
                        principalTable: "WeChatUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AbpEntityPropertyChanges",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false),
                    TenantId = table.Column<Guid>(type: "char(36)", nullable: true),
                    EntityChangeId = table.Column<Guid>(type: "char(36)", nullable: false),
                    NewValue = table.Column<string>(type: "varchar(512)", maxLength: 512, nullable: true),
                    OriginalValue = table.Column<string>(type: "varchar(512)", maxLength: 512, nullable: true),
                    PropertyName = table.Column<string>(type: "varchar(128)", maxLength: 128, nullable: false),
                    PropertyTypeFullName = table.Column<string>(type: "varchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AbpEntityPropertyChanges", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AbpEntityPropertyChanges_AbpEntityChanges_EntityChangeId",
                        column: x => x.EntityChangeId,
                        principalTable: "AbpEntityChanges",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ApprovalDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdateOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: true),
                    CreatedByCustomerId = table.Column<int>(type: "int", nullable: false),
                    ApprovalDetailStatusId = table.Column<int>(type: "int", nullable: false),
                    NextApprovalDetailName = table.Column<string>(type: "longtext", nullable: false),
                    CurrentApproverId = table.Column<int>(type: "int", nullable: false),
                    ApprovalGroupId = table.Column<int>(type: "int", nullable: false),
                    BeforeApproverId = table.Column<int>(type: "int", nullable: true),
                    WeChatMaterialNewsId = table.Column<int>(type: "int", nullable: false),
                    ApprovalRuleId = table.Column<int>(type: "int", nullable: false),
                    WeChatMaterialNewsVersionId = table.Column<int>(type: "int", nullable: false),
                    NodeId = table.Column<int>(type: "int", nullable: false),
                    Extra = table.Column<string>(type: "longtext", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApprovalDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ApprovalDetail_ApprovalRule_ApprovalRuleId",
                        column: x => x.ApprovalRuleId,
                        principalTable: "ApprovalRule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeChatMaterialNews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WeChatMaterialNewsStatusId = table.Column<int>(type: "int", nullable: false),
                    WeChatConfigId = table.Column<int>(type: "int", nullable: true),
                    WeChatMediaId = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    CreatedById = table.Column<int>(type: "int", nullable: false),
                    UpdatedById = table.Column<int>(type: "int", nullable: false),
                    ApprovalRuleId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatMaterialNews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeChatMaterialNews_ApprovalRule_ApprovalRuleId",
                        column: x => x.ApprovalRuleId,
                        principalTable: "ApprovalRule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WeChatNews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WeChatMediaId = table.Column<int>(type: "int", nullable: false),
                    Index = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: false),
                    ThumbMediaId = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    ShowCoverPic = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Author = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: true),
                    Digest = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Content = table.Column<string>(type: "longtext", nullable: false),
                    Url = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    ConetntSourceUrl = table.Column<string>(type: "varchar(1000)", maxLength: 1000, nullable: true),
                    NeedOpenComment = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    OnlyFansCanComment = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatNews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeChatNews_WeChatMedia_WeChatMediaId",
                        column: x => x.WeChatMediaId,
                        principalTable: "WeChatMedia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeChatQrCodeRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WeChatQrCodeId = table.Column<int>(type: "int", nullable: false),
                    OpenId = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    WeChatConfigId = table.Column<int>(type: "int", nullable: false),
                    ScanTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatQrCodeRecord", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeChatQrCodeRecord_WeChatQrCode_WeChatQrCodeId",
                        column: x => x.WeChatQrCodeId,
                        principalTable: "WeChatQrCode",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeChatMaterialNewsVersion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    VersionNumber = table.Column<int>(type: "int", nullable: false),
                    CreatedOnUtc = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    WeChatMaterialNewsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatMaterialNewsVersion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeChatMaterialNewsVersion_WeChatMaterialNews_WeChatMaterialN~",
                        column: x => x.WeChatMaterialNewsId,
                        principalTable: "WeChatMaterialNews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WeChatMaterialNewsArticle",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    WeChatMaterialNewsVersionId = table.Column<int>(type: "int", nullable: false),
                    WeChatMaterialNewsId = table.Column<int>(type: "int", nullable: false),
                    Index = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    ThumbMediaId = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    ShowCoverPic = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    Author = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Digest = table.Column<string>(type: "varchar(200)", maxLength: 200, nullable: true),
                    Content = table.Column<string>(type: "longtext", nullable: true),
                    Url = table.Column<string>(type: "longtext", nullable: true),
                    ContentSourceUrl = table.Column<string>(type: "longtext", nullable: true),
                    NeedOpenComment = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    OnlyFansCanComment = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeChatMaterialNewsArticle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WeChatMaterialNewsArticle_WeChatMaterialNewsVersion_WeChatMa~",
                        column: x => x.WeChatMaterialNewsVersionId,
                        principalTable: "WeChatMaterialNewsVersion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AbpAuditLogActions_AuditLogId",
                table: "AbpAuditLogActions",
                column: "AuditLogId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpAuditLogActions_TenantId_ServiceName_MethodName_Execution~",
                table: "AbpAuditLogActions",
                columns: new[] { "TenantId", "ServiceName", "MethodName", "ExecutionTime" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpAuditLogs_TenantId_ExecutionTime",
                table: "AbpAuditLogs",
                columns: new[] { "TenantId", "ExecutionTime" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpAuditLogs_TenantId_UserId_ExecutionTime",
                table: "AbpAuditLogs",
                columns: new[] { "TenantId", "UserId", "ExecutionTime" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpBackgroundJobs_IsAbandoned_NextTryTime",
                table: "AbpBackgroundJobs",
                columns: new[] { "IsAbandoned", "NextTryTime" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpEntityChanges_AuditLogId",
                table: "AbpEntityChanges",
                column: "AuditLogId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpEntityChanges_TenantId_EntityTypeFullName_EntityId",
                table: "AbpEntityChanges",
                columns: new[] { "TenantId", "EntityTypeFullName", "EntityId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpEntityPropertyChanges_EntityChangeId",
                table: "AbpEntityPropertyChanges",
                column: "EntityChangeId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpFeatureValues_Name_ProviderName_ProviderKey",
                table: "AbpFeatureValues",
                columns: new[] { "Name", "ProviderName", "ProviderKey" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpLinkUsers_SourceUserId_SourceTenantId_TargetUserId_Target~",
                table: "AbpLinkUsers",
                columns: new[] { "SourceUserId", "SourceTenantId", "TargetUserId", "TargetTenantId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AbpOrganizationUnitRoles_RoleId_OrganizationUnitId",
                table: "AbpOrganizationUnitRoles",
                columns: new[] { "RoleId", "OrganizationUnitId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpOrganizationUnits_Code",
                table: "AbpOrganizationUnits",
                column: "Code");

            migrationBuilder.CreateIndex(
                name: "IX_AbpOrganizationUnits_ParentId",
                table: "AbpOrganizationUnits",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpPermissionGrants_Name_ProviderName_ProviderKey",
                table: "AbpPermissionGrants",
                columns: new[] { "Name", "ProviderName", "ProviderKey" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpRoleClaims_RoleId",
                table: "AbpRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpRoles_NormalizedName",
                table: "AbpRoles",
                column: "NormalizedName");

            migrationBuilder.CreateIndex(
                name: "IX_AbpSecurityLogs_TenantId_Action",
                table: "AbpSecurityLogs",
                columns: new[] { "TenantId", "Action" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpSecurityLogs_TenantId_ApplicationName",
                table: "AbpSecurityLogs",
                columns: new[] { "TenantId", "ApplicationName" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpSecurityLogs_TenantId_Identity",
                table: "AbpSecurityLogs",
                columns: new[] { "TenantId", "Identity" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpSecurityLogs_TenantId_UserId",
                table: "AbpSecurityLogs",
                columns: new[] { "TenantId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpSettings_Name_ProviderName_ProviderKey",
                table: "AbpSettings",
                columns: new[] { "Name", "ProviderName", "ProviderKey" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpTenants_Name",
                table: "AbpTenants",
                column: "Name");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserClaims_UserId",
                table: "AbpUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserLogins_LoginProvider_ProviderKey",
                table: "AbpUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserOrganizationUnits_UserId_OrganizationUnitId",
                table: "AbpUserOrganizationUnits",
                columns: new[] { "UserId", "OrganizationUnitId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUserRoles_RoleId_UserId",
                table: "AbpUserRoles",
                columns: new[] { "RoleId", "UserId" });

            migrationBuilder.CreateIndex(
                name: "IX_AbpUsers_Email",
                table: "AbpUsers",
                column: "Email");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUsers_NormalizedEmail",
                table: "AbpUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUsers_NormalizedUserName",
                table: "AbpUsers",
                column: "NormalizedUserName");

            migrationBuilder.CreateIndex(
                name: "IX_AbpUsers_UserName",
                table: "AbpUsers",
                column: "UserName");

            migrationBuilder.CreateIndex(
                name: "IX_ApprovalDetail_ApprovalRuleId",
                table: "ApprovalDetail",
                column: "ApprovalRuleId");

            migrationBuilder.CreateIndex(
                name: "IX_ApprovalGroupInfo_ApprovalGroupId",
                table: "ApprovalGroupInfo",
                column: "ApprovalGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_ApprovalRule_ApprovalGroupId",
                table: "ApprovalRule",
                column: "ApprovalGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_WeChatAutoReply_WeChatConfigId",
                table: "WeChatAutoReply",
                column: "WeChatConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_WeChatMaterialNews_ApprovalRuleId",
                table: "WeChatMaterialNews",
                column: "ApprovalRuleId");

            migrationBuilder.CreateIndex(
                name: "IX_WeChatMaterialNewsArticle_WeChatMaterialNewsVersionId",
                table: "WeChatMaterialNewsArticle",
                column: "WeChatMaterialNewsVersionId");

            migrationBuilder.CreateIndex(
                name: "IX_WeChatMaterialNewsVersion_WeChatMaterialNewsId",
                table: "WeChatMaterialNewsVersion",
                column: "WeChatMaterialNewsId");

            migrationBuilder.CreateIndex(
                name: "IX_WeChatMedia_WeChatConfigId",
                table: "WeChatMedia",
                column: "WeChatConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_WeChatMenu_WeChatConfigId",
                table: "WeChatMenu",
                column: "WeChatConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_WeChatMessage_WeChatConfigId",
                table: "WeChatMessage",
                column: "WeChatConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_WeChatMessage_WeChatUserId",
                table: "WeChatMessage",
                column: "WeChatUserId");

            migrationBuilder.CreateIndex(
                name: "IX_WeChatMessageNotify_WeChatConfigId",
                table: "WeChatMessageNotify",
                column: "WeChatConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_WeChatNews_WeChatMediaId",
                table: "WeChatNews",
                column: "WeChatMediaId");

            migrationBuilder.CreateIndex(
                name: "IX_WeChatQrCode_WeChatConfigId",
                table: "WeChatQrCode",
                column: "WeChatConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_WeChatQrCode_WeChatTagId",
                table: "WeChatQrCode",
                column: "WeChatTagId");

            migrationBuilder.CreateIndex(
                name: "IX_WeChatQrCodeRecord_WeChatQrCodeId",
                table: "WeChatQrCodeRecord",
                column: "WeChatQrCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_WeChatSendRecord_WeChatConfigId",
                table: "WeChatSendRecord",
                column: "WeChatConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_WeChatStatisticsArticleDetail_WeChatStatisticsArticleId",
                table: "WeChatStatisticsArticleDetail",
                column: "WeChatStatisticsArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_WeChatSyncRecord_WeChatConfigId",
                table: "WeChatSyncRecord",
                column: "WeChatConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_WeChatTempMedia_WeChatConfigId",
                table: "WeChatTempMedia",
                column: "WeChatConfigId");

            migrationBuilder.CreateIndex(
                name: "IX_WeChatUser_WeChatTag_Mapping_WeChatUserId",
                table: "WeChatUser_WeChatTag_Mapping",
                column: "WeChatUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AbpAuditLogActions");

            migrationBuilder.DropTable(
                name: "AbpBackgroundJobs");

            migrationBuilder.DropTable(
                name: "AbpClaimTypes");

            migrationBuilder.DropTable(
                name: "AbpEntityPropertyChanges");

            migrationBuilder.DropTable(
                name: "AbpFeatureValues");

            migrationBuilder.DropTable(
                name: "AbpLinkUsers");

            migrationBuilder.DropTable(
                name: "AbpOrganizationUnitRoles");

            migrationBuilder.DropTable(
                name: "AbpPermissionGrants");

            migrationBuilder.DropTable(
                name: "AbpRoleClaims");

            migrationBuilder.DropTable(
                name: "AbpSecurityLogs");

            migrationBuilder.DropTable(
                name: "AbpSettings");

            migrationBuilder.DropTable(
                name: "AbpTenantConnectionStrings");

            migrationBuilder.DropTable(
                name: "AbpUserClaims");

            migrationBuilder.DropTable(
                name: "AbpUserLogins");

            migrationBuilder.DropTable(
                name: "AbpUserOrganizationUnits");

            migrationBuilder.DropTable(
                name: "AbpUserRoles");

            migrationBuilder.DropTable(
                name: "AbpUserTokens");

            migrationBuilder.DropTable(
                name: "ApprovalDetail");

            migrationBuilder.DropTable(
                name: "ApprovalGroupInfo");

            migrationBuilder.DropTable(
                name: "WeChatAutoReply");

            migrationBuilder.DropTable(
                name: "WeChatMaterialNewsArticle");

            migrationBuilder.DropTable(
                name: "WeChatMenu");

            migrationBuilder.DropTable(
                name: "WeChatMessage");

            migrationBuilder.DropTable(
                name: "WeChatMessageNotify");

            migrationBuilder.DropTable(
                name: "WeChatNews");

            migrationBuilder.DropTable(
                name: "WeChatQrCodeRecord");

            migrationBuilder.DropTable(
                name: "WeChatSendRecord");

            migrationBuilder.DropTable(
                name: "WeChatStatisticsArticleDetail");

            migrationBuilder.DropTable(
                name: "WeChatStatisticsInterface");

            migrationBuilder.DropTable(
                name: "WeChatStatisticsMsg");

            migrationBuilder.DropTable(
                name: "WeChatStatisticsUser");

            migrationBuilder.DropTable(
                name: "WeChatSyncRecord");

            migrationBuilder.DropTable(
                name: "WeChatTempMedia");

            migrationBuilder.DropTable(
                name: "WeChatToDoList");

            migrationBuilder.DropTable(
                name: "WeChatUser_WeChatTag_Mapping");

            migrationBuilder.DropTable(
                name: "AbpEntityChanges");

            migrationBuilder.DropTable(
                name: "AbpTenants");

            migrationBuilder.DropTable(
                name: "AbpOrganizationUnits");

            migrationBuilder.DropTable(
                name: "AbpRoles");

            migrationBuilder.DropTable(
                name: "AbpUsers");

            migrationBuilder.DropTable(
                name: "WeChatMaterialNewsVersion");

            migrationBuilder.DropTable(
                name: "WeChatMedia");

            migrationBuilder.DropTable(
                name: "WeChatQrCode");

            migrationBuilder.DropTable(
                name: "WeChatStatisticsArticle");

            migrationBuilder.DropTable(
                name: "WeChatUser");

            migrationBuilder.DropTable(
                name: "AbpAuditLogs");

            migrationBuilder.DropTable(
                name: "WeChatMaterialNews");

            migrationBuilder.DropTable(
                name: "WeChatConfig");

            migrationBuilder.DropTable(
                name: "WeChatTag");

            migrationBuilder.DropTable(
                name: "ApprovalRule");

            migrationBuilder.DropTable(
                name: "ApprovalGroup");
        }
    }
}
