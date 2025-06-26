using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StriveApi.Database.Models.MTISite;

namespace StriveApi.Database;

public partial class MtisiteContext(DbContextOptions<MtisiteContext> options) : DbContext(options)
{
    public virtual DbSet<AccountCollection> AccountCollections { get; set; }

    public virtual DbSet<AccountCollectionLog> AccountCollectionLogs { get; set; }

    public virtual DbSet<AccountCollectionsOld> AccountCollectionsOlds { get; set; }

    public virtual DbSet<AccountLicence> AccountLicences { get; set; }

    public virtual DbSet<AcctTable> AcctTables { get; set; }

    public virtual DbSet<AcserverGroup> AcserverGroups { get; set; }

    public virtual DbSet<AcserverGroupsOld> AcserverGroupsOlds { get; set; }

    public virtual DbSet<AdvertCounter> AdvertCounters { get; set; }

    public virtual DbSet<Apiaccount> Apiaccounts { get; set; }

    public virtual DbSet<Apilogin> Apilogins { get; set; }

    public virtual DbSet<AppStoreActivity> AppStoreActivities { get; set; }

    public virtual DbSet<AppStoreCategory> AppStoreCategories { get; set; }

    public virtual DbSet<AppStoreDownload> AppStoreDownloads { get; set; }

    public virtual DbSet<AppStorePackage> AppStorePackages { get; set; }

    public virtual DbSet<AppStorePackageFile> AppStorePackageFiles { get; set; }

    public virtual DbSet<AutoNewsEvent> AutoNewsEvents { get; set; }

    public virtual DbSet<AutoNewsEventType> AutoNewsEventTypes { get; set; }

    public virtual DbSet<AutoNewsEventsOld> AutoNewsEventsOlds { get; set; }

    public virtual DbSet<AutoNewsLanguageVariable> AutoNewsLanguageVariables { get; set; }

    public virtual DbSet<AutoNewsMessageTwitterLink> AutoNewsMessageTwitterLinks { get; set; }

    public virtual DbSet<AutoNewsMessageType> AutoNewsMessageTypes { get; set; }

    public virtual DbSet<AutoNewsTwitterCredential> AutoNewsTwitterCredentials { get; set; }

    public virtual DbSet<BroadcastMessage> BroadcastMessages { get; set; }

    public virtual DbSet<BroadcastPriceLevel> BroadcastPriceLevels { get; set; }

    public virtual DbSet<BrokerDirectory> BrokerDirectories { get; set; }

    public virtual DbSet<BrokerDirectoryArticle> BrokerDirectoryArticles { get; set; }

    public virtual DbSet<BrokerDirectoryDetail> BrokerDirectoryDetails { get; set; }

    public virtual DbSet<BrokerDirectoryEditor> BrokerDirectoryEditors { get; set; }

    public virtual DbSet<BrokerDownload> BrokerDownloads { get; set; }

    public virtual DbSet<BrokerPermissionAccountList> BrokerPermissionAccountLists { get; set; }

    public virtual DbSet<BrokerPermissionAccountLogin> BrokerPermissionAccountLogins { get; set; }

    public virtual DbSet<ChallengeImport> ChallengeImports { get; set; }

    public virtual DbSet<ChartAlertLog> ChartAlertLogs { get; set; }

    public virtual DbSet<ChartSharing> ChartSharings { get; set; }

    public virtual DbSet<ChartState> ChartStates { get; set; }

    public virtual DbSet<ChartUserSetting> ChartUserSettings { get; set; }

    public virtual DbSet<Chat> Chats { get; set; }

    public virtual DbSet<ChatChannel> ChatChannels { get; set; }

    public virtual DbSet<Competition> Competitions { get; set; }

    public virtual DbSet<CompetitionForum> CompetitionForums { get; set; }

    public virtual DbSet<CompetitionInvitation> CompetitionInvitations { get; set; }

    public virtual DbSet<CompetitionJoinMessage> CompetitionJoinMessages { get; set; }

    public virtual DbSet<Competitor> Competitors { get; set; }

    public virtual DbSet<CompetitorSnapshot> CompetitorSnapshots { get; set; }

    public virtual DbSet<ConnectAccount> ConnectAccounts { get; set; }

    public virtual DbSet<ConnectAlarm> ConnectAlarms { get; set; }

    public virtual DbSet<ConnectDashboardSubscription> ConnectDashboardSubscriptions { get; set; }

    public virtual DbSet<ConnectFeed> ConnectFeeds { get; set; }

    public virtual DbSet<ConnectFeedFilter> ConnectFeedFilters { get; set; }

    public virtual DbSet<ConnectPriceList> ConnectPriceLists { get; set; }

    public virtual DbSet<ConnectTweeter> ConnectTweeters { get; set; }

    public virtual DbSet<ConnectTweeterFilter> ConnectTweeterFilters { get; set; }

    public virtual DbSet<Contest> Contests { get; set; }

    public virtual DbSet<Contestant> Contestants { get; set; }

    public virtual DbSet<CountryCode> CountryCodes { get; set; }

    public virtual DbSet<DeletedUser> DeletedUsers { get; set; }

    public virtual DbSet<DemoAccountPool> DemoAccountPools { get; set; }

    public virtual DbSet<FixiTemp> FixiTemps { get; set; }

    public virtual DbSet<HitTracking> HitTrackings { get; set; }

    public virtual DbSet<ImpressionTracking> ImpressionTrackings { get; set; }

    public virtual DbSet<Lead> Leads { get; set; }

    public virtual DbSet<LeadCompany> LeadCompanies { get; set; }

    public virtual DbSet<Lttcoach> Lttcoaches { get; set; }

    public virtual DbSet<LttemailSubscription> LttemailSubscriptions { get; set; }

    public virtual DbSet<Lttscreenshot> Lttscreenshots { get; set; }

    public virtual DbSet<Lttsignal> Lttsignals { get; set; }

    public virtual DbSet<Lttstrategy> Lttstrategies { get; set; }

    public virtual DbSet<MailJourney> MailJourneys { get; set; }

    public virtual DbSet<MailJourneyItem> MailJourneyItems { get; set; }

    public virtual DbSet<MirrorInviteCode> MirrorInviteCodes { get; set; }

    public virtual DbSet<NewsFeedLogin> NewsFeedLogins { get; set; }

    public virtual DbSet<NewsFeedLoginActivity> NewsFeedLoginActivities { get; set; }

    public virtual DbSet<NewsFeedLoginDatum> NewsFeedLoginData { get; set; }

    public virtual DbSet<NewsItem> NewsItems { get; set; }

    public virtual DbSet<NewsItemTag> NewsItemTags { get; set; }

    public virtual DbSet<NewsItemTagsArchive> NewsItemTagsArchives { get; set; }

    public virtual DbSet<NewsItemsArchive> NewsItemsArchives { get; set; }

    public virtual DbSet<NoMailshot> NoMailshots { get; set; }

    public virtual DbSet<Performance> Performances { get; set; }

    public virtual DbSet<PerformanceOld> PerformanceOlds { get; set; }

    public virtual DbSet<PhoneValidationCache> PhoneValidationCaches { get; set; }

    public virtual DbSet<Portfolio> Portfolios { get; set; }

    public virtual DbSet<PortfolioConstituent> PortfolioConstituents { get; set; }

    public virtual DbSet<Prediction> Predictions { get; set; }

    public virtual DbSet<PredictionCredit> PredictionCredits { get; set; }

    public virtual DbSet<PredictionMessage> PredictionMessages { get; set; }

    public virtual DbSet<PredictionPriceBar> PredictionPriceBars { get; set; }

    public virtual DbSet<PredictionState> PredictionStates { get; set; }

    public virtual DbSet<PredictionSymbol> PredictionSymbols { get; set; }

    public virtual DbSet<PredictionSymbolPrice> PredictionSymbolPrices { get; set; }

    public virtual DbSet<PredictionpricebarsOld> PredictionpricebarsOlds { get; set; }

    public virtual DbSet<QuickChannelSubscriber> QuickChannelSubscribers { get; set; }

    public virtual DbSet<Room> Rooms { get; set; }

    public virtual DbSet<RoomAction> RoomActions { get; set; }

    public virtual DbSet<RoomActionType> RoomActionTypes { get; set; }

    public virtual DbSet<RoomBrokerAccount> RoomBrokerAccounts { get; set; }

    public virtual DbSet<RoomCommand> RoomCommands { get; set; }

    public virtual DbSet<RoomCommandResponseDatum> RoomCommandResponseData { get; set; }

    public virtual DbSet<RoomEntityType> RoomEntityTypes { get; set; }

    public virtual DbSet<RoomFollower> RoomFollowers { get; set; }

    public virtual DbSet<RoomLike> RoomLikes { get; set; }

    public virtual DbSet<RoomMember> RoomMembers { get; set; }

    public virtual DbSet<RoomMemberLevel> RoomMemberLevels { get; set; }

    public virtual DbSet<RoomMessage> RoomMessages { get; set; }

    public virtual DbSet<RoomOrder> RoomOrders { get; set; }

    public virtual DbSet<RoomOrderActionType> RoomOrderActionTypes { get; set; }

    public virtual DbSet<RoomOrderState> RoomOrderStates { get; set; }

    public virtual DbSet<SiteUser> SiteUsers { get; set; }

    public virtual DbSet<Slingshot> Slingshots { get; set; }

    public virtual DbSet<SlingshotDownload> SlingshotDownloads { get; set; }

    public virtual DbSet<SlingshotForum> SlingshotForums { get; set; }

    public virtual DbSet<SlingshotTracking> SlingshotTrackings { get; set; }

    public virtual DbSet<SoftwareLicence> SoftwareLicences { get; set; }

    public virtual DbSet<SoftwareLicencesIpaddressBlock> SoftwareLicencesIpaddressBlocks { get; set; }

    public virtual DbSet<SystemLog> SystemLogs { get; set; }

    public virtual DbSet<TradeBoardClosedTrade> TradeBoardClosedTrades { get; set; }

    public virtual DbSet<TradeBoardOpenTrade> TradeBoardOpenTrades { get; set; }

    public virtual DbSet<TradingDrill> TradingDrills { get; set; }

    public virtual DbSet<TradingDrillDefinition> TradingDrillDefinitions { get; set; }

    public virtual DbSet<TradingWheelsUsage> TradingWheelsUsages { get; set; }

    public virtual DbSet<Universe> Universes { get; set; }

    public virtual DbSet<UsageTracking> UsageTrackings { get; set; }

    public virtual DbSet<UsageTrackingAccount> UsageTrackingAccounts { get; set; }

    public virtual DbSet<UsageTrackingCache> UsageTrackingCaches { get; set; }

    public virtual DbSet<UserAccessRestriction> UserAccessRestrictions { get; set; }

    public virtual DbSet<UserCommentTag> UserCommentTags { get; set; }

    public virtual DbSet<UserIdAllocator> UserIdAllocators { get; set; }

    public virtual DbSet<UserPosition> UserPositions { get; set; }

    public virtual DbSet<UserPositionSnapshot> UserPositionSnapshots { get; set; }

    public virtual DbSet<UserPositionSnapshotsExternal> UserPositionSnapshotsExternals { get; set; }

    public virtual DbSet<UserSecretModel> UserSecrets { get; set; }

    public virtual DbSet<VwBloomberg> VwBloombergs { get; set; }

    public virtual DbSet<WhiteLabelUserMapping> WhiteLabelUserMappings { get; set; }

    public class CustomGuidToStringConverter(ConverterMappingHints? mappingHints = null) :
        ValueConverter<Guid?, string>(
            modelValue => modelValue == null ? string.Empty : modelValue.ToString()!,
            dbValue => string.IsNullOrWhiteSpace(dbValue) ? null : Guid.Parse(dbValue),
            mappingHints
        )
    { }

    /// <summary>
    /// DB function mapping for fnGeoCheck
    /// </summary>
    /// <param name="countryCode"></param>
    /// <param name="geoMode"></param>
    /// <param name="countryList"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public int GeoCheckResult(string countryCode, BrokerGeoMode geoMode, string countryList) =>
        throw new NotImplementedException();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDbFunction(typeof(MtisiteContext).GetMethod(nameof(GeoCheckResult), [typeof(string), typeof(BrokerGeoMode), typeof(string)])!).HasName("fnGeoCheck");

        modelBuilder.Entity<AccountCollection>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.HasIndex(e => new { e.DisableReasonId, e.LastRequestTimestamp }, "IX_AccountCollection");

            entity.HasIndex(e => e.AccountLogin, "IX_AccountCollection_AccountLogin");

            entity.HasIndex(e => new { e.DisableReasonId, e.SubGroup, e.LastRequestTimestamp }, "IX_AccountCollection_Allocator");

            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AccountLogin)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BrokerServer)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EncryptedPassword)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.IncludeOpenOrders).HasDefaultValue((short)1);
            entity.Property(e => e.IncludeOpenProfit).HasDefaultValue((short)1);
            entity.Property(e => e.IncludePendingOrders).HasDefaultValue((short)1);
            entity.Property(e => e.LastCollectionTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.LastStatus).HasDefaultValue(-1);
            entity.Property(e => e.LastSuccessfulCollectionTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.PublishOrderComments).HasDefaultValue((short)1);
            entity.Property(e => e.SubGroup)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<AccountCollectionLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AccountCollectionLog");

            entity.Property(e => e.CollectionTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.FromIpaddress)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("FromIPAddress");
            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AccountCollectionsOld>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("AccountCollections_Old");

            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AccountLogin)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BrokerServer)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EncryptedPassword)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.LastCollectionTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.LastSuccessfulCollectionTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.SubGroup)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AccountLicence>(entity =>
        {
            entity.HasKey(e => new { e.ProductKey, e.AccountNumber, e.AccountServer });

            entity.Property(e => e.ProductKey)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AccountServer)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ExpiryDateUtc)
                .HasDefaultValue(new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.IsEnabled).HasDefaultValue((byte)1);
        });

        modelBuilder.Entity<AcctTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("acct_table");

            entity.Property(e => e.HideGrpPath).HasColumnName("hide_grp_path");
            entity.Property(e => e.HomePath)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("home_path");
            entity.Property(e => e.HomePerm)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("home_perm");
            entity.Property(e => e.HostId).HasColumnName("host_id");
            entity.Property(e => e.HostPort).HasColumnName("host_port");
            entity.Property(e => e.NoPassword).HasColumnName("no_password");
            entity.Property(e => e.Password)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("username");
        });

        modelBuilder.Entity<AcserverGroup>(entity =>
        {
            entity.HasKey(e => new { e.ServerName, e.SubGroup });

            entity.ToTable("ACServerGroups");

            entity.HasIndex(e => e.ServerName, "IX_ACServerGroups");

            entity.Property(e => e.ServerName)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.SubGroup)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AcserverGroupsOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ACServerGroups_Old");

            entity.Property(e => e.ServerName)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.SubGroup)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AdvertCounter>(entity =>
        {
            entity.HasKey(e => e.AdvertId);

            entity.Property(e => e.AdvertId)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Apiaccount>(entity =>
        {
            entity.HasKey(e => e.ApiaccountKey);

            entity.ToTable("APIAccounts");

            entity.HasIndex(e => e.UserId, "IX_APIAccounts").IsUnique();

            entity.HasIndex(e => e.ApiloginKey, "IX_APIAccounts_UserKey");

            entity.Property(e => e.ApiaccountKey)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("APIAccountKey");
            entity.Property(e => e.ApiloginKey)
                .HasMaxLength(32)
                .HasColumnName("APILoginKey");
            entity.Property(e => e.PeakDrawdownBalance).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.PeakDrawdownPercent).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.PeakDrawdownPl)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("PeakDrawdownPL");
            entity.Property(e => e.PeakDrawdownTimeUtc)
                .HasDefaultValue(new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime")
                .HasColumnName("PeakDrawdownTimeUTC");
            entity.Property(e => e.UserId).HasMaxLength(30);
        });

        modelBuilder.Entity<Apilogin>(entity =>
        {
            entity.HasKey(e => e.ApiloginKey).HasName("PK_APIUsers");

            entity.ToTable("APILogins");

            entity.Property(e => e.ApiloginKey)
                .HasMaxLength(32)
                .IsUnicode(false)
                .HasColumnName("APILoginKey");
            entity.Property(e => e.AllowLogin).HasDefaultValue((byte)1);
            entity.Property(e => e.AllowUserCreation).HasDefaultValue((byte)1);
            entity.Property(e => e.ApiloginCaption)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("APILoginCaption");
            entity.Property(e => e.UserUniverse)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AppStoreActivity>(entity =>
        {
            entity.HasKey(e => e.AppStoreLogId);

            entity.ToTable("AppStoreActivity");

            entity.Property(e => e.ComputerId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EventTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.EventType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("IPAddress");
            entity.Property(e => e.Param1)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AppStoreCategory>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AppStoreCategoryName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CategoryDescription).HasColumnType("text");
            entity.Property(e => e.CategoryPageName)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AppStoreDownload>(entity =>
        {
            entity.HasIndex(e => new { e.AppStorePackageId, e.UserId }, "IX_AppStoreDownloads");

            entity.HasIndex(e => e.UserId, "IX_AppstoreDownloads_User");

            entity.Property(e => e.DownloadDateUtc).HasColumnType("datetime");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("IPAddress");
            entity.Property(e => e.IpaddressCountry)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("IPAddressCountry");
            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.WantNotifications).HasDefaultValue((short)1);
        });

        modelBuilder.Entity<AppStorePackage>(entity =>
        {
            entity.Property(e => e.AppStorePackageId).ValueGeneratedNever();
            entity.Property(e => e.AllowInstallers).HasDefaultValue((short)1);
            entity.Property(e => e.AppLogo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AppPrice).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.AppPriceCurrency)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("USD");
            entity.Property(e => e.AuthorWebsite)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AverageRating).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.CreationDate)
                .HasDefaultValue(new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.CurrentVersion).HasDefaultValue(1);
            entity.Property(e => e.DetailText).HasColumnType("ntext");
            entity.Property(e => e.DocumentationUrl)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.DownloadUrl)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EmailTemplate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.FxadvertsIdForInstaller).HasColumnName("FXAdvertsIdForInstaller");
            entity.Property(e => e.IncludeInStats).HasDefaultValue((short)1);
            entity.Property(e => e.InstallFxadverts).HasColumnName("InstallFXAdverts");
            entity.Property(e => e.IsVisible).HasDefaultValue((short)1);
            entity.Property(e => e.MetaDescription).HasColumnType("ntext");
            entity.Property(e => e.MostRecentUpdate).HasColumnType("datetime");
            entity.Property(e => e.Mt4postInstallPage)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("MT4PostInstallPage");
            entity.Property(e => e.PackageDataStoreDirectory)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PackageName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PackagePageName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PackageTermsUrl)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Popularity).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.RequireRegistration).HasDefaultValue((short)1);
            entity.Property(e => e.ShowForum).HasDefaultValue((short)1);
            entity.Property(e => e.ShowSocialLinks).HasDefaultValue((short)1);
            entity.Property(e => e.SummaryText).HasColumnType("ntext");
            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AppStorePackageFile>(entity =>
        {
            entity.HasKey(e => e.AppStoreFileId);

            entity.HasIndex(e => e.AppStorePackageId, "IX_AppStorePackageFiles_Package");

            entity.Property(e => e.AppStoreFilename)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.InstallationTarget)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AutoNewsEvent>(entity =>
        {
            entity.Property(e => e.AutoNewsEventLanguage)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.AutoNewsEventTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.AutoNewsEventType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EventCategory)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EventTitle).HasMaxLength(140);
        });

        modelBuilder.Entity<AutoNewsEventType>(entity =>
        {
            entity.HasKey(e => e.AutoNewsEventType1);

            entity.Property(e => e.AutoNewsEventType1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AutoNewsEventType");
        });

        modelBuilder.Entity<AutoNewsEventsOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AutoNewsEvents_Old");

            entity.Property(e => e.AutoNewsEventId).ValueGeneratedOnAdd();
            entity.Property(e => e.AutoNewsEventLanguage)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.AutoNewsEventTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.AutoNewsEventType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EventCategory)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EventTitle).HasMaxLength(140);
        });

        modelBuilder.Entity<AutoNewsLanguageVariable>(entity =>
        {
            entity.HasKey(e => new { e.AutoNewsVariable, e.AutoNewsLanguage }).HasName("PK_AutoNewsVariables");

            entity.Property(e => e.AutoNewsVariable)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AutoNewsLanguage)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.AutoNewsTranslation).HasMaxLength(50);
        });

        modelBuilder.Entity<AutoNewsMessageTwitterLink>(entity =>
        {
            entity.HasKey(e => new { e.AutoNewsMessageType, e.AutoNewsTwitterId });

            entity.Property(e => e.AutoNewsMessageType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AutoNewsTwitterId)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<AutoNewsMessageType>(entity =>
        {
            entity.HasKey(e => new { e.AutoNewsMessageType1, e.AutoNewsMessageLanguage });

            entity.Property(e => e.AutoNewsMessageType1)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("AutoNewsMessageType");
            entity.Property(e => e.AutoNewsMessageLanguage)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.AutoNewsMessageTemplate)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SendToTwitter).HasDefaultValue((short)1);
        });

        modelBuilder.Entity<AutoNewsTwitterCredential>(entity =>
        {
            entity.HasKey(e => e.AutoNewsLanguage);

            entity.Property(e => e.AutoNewsLanguage)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.AccessToken)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AccessTokenSecret)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AutoNewsTwitterId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ConsumerKey)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.ConsumerKeySecret)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BroadcastMessage>(entity =>
        {
            entity.HasKey(e => e.EventId);

            entity.Property(e => e.EventTimeUtc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.MessageChannel).HasMaxLength(20);
            entity.Property(e => e.MessageId)
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BroadcastPriceLevel>(entity =>
        {
            entity.HasKey(e => new { e.ProviderId, e.LevelId });

            entity.HasIndex(e => new { e.ProviderId, e.LevelSymbol, e.LevelTimeframe }, "IX_BroadcastPriceLevels");

            entity.Property(e => e.ProviderId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LevelId).ValueGeneratedOnAdd();
            entity.Property(e => e.LevelExpiryUtc)
                .HasDefaultValue(new DateTime(2029, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.LevelPrice).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LevelStartUtc)
                .HasDefaultValue(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.LevelSymbol)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LevelTolerance).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<BrokerDirectory>(entity =>
        {
            entity.HasKey(e => e.BrokerId);

            entity.ToTable("BrokerDirectory");

            entity.HasIndex(e => e.BrokerCompanyName, "IX_BrokerDirectory_CompanyName").IsUnique();

            entity.HasIndex(e => e.BrokerPageName, "IX_BrokerDirectory_PageName").IsUnique();

            entity.Property(e => e.BrokerId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasConversion(new GuidToStringConverter());
            entity.Property(e => e.BrokerCompanyName).HasMaxLength(50);
            entity.Property(e => e.BrokerPageName).HasMaxLength(20);
            entity.Property(e => e.ContactEmail).HasMaxLength(50);
            entity.Property(e => e.CurrentDetailsStatus)
                .HasDefaultValue(CurrentDetailsStatus.Archived)
                .HasSentinel(CurrentDetailsStatus.Archived);
            entity.Property(e => e.GeoList)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.Published).HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.CanHaveLogo).HasConversion(new BoolToZeroOneConverter<byte>()).HasDefaultValue(true);
        });

        modelBuilder.Entity<BrokerDirectoryArticle>(entity =>
        {
            entity.HasKey(e => new { e.ArticleId, e.ArticleStatus });

            entity.HasIndex(e => new { e.BrokerId, e.ArticlePageTitle }, "IX_BrokerDirectoryArticles_UniquePageTitlePerBroker");

            entity.Property(e => e.ArticleId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasConversion(new GuidToStringConverter());
            entity.Property(e => e.ArticleBody)
                .HasDefaultValue("")
                .HasColumnType("ntext");
            entity.Property(e => e.ArticleContact).HasMaxLength(100);
            entity.Property(e => e.ArticleLink).HasMaxLength(200);
            entity.Property(e => e.ArticlePageTitle).HasMaxLength(100);
            entity.Property(e => e.ArticleSummary)
                .HasDefaultValue("")
                .HasColumnType("ntext");
            entity.Property(e => e.ArticleTitle).HasColumnType("ntext");
            entity.Property(e => e.BrokerId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasConversion(new GuidToStringConverter());
            entity.Property(e => e.CanonicalPage)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.CreationDateUtc).HasColumnType("datetime");
            entity.Property(e => e.DisclaimerText)
                .HasDefaultValue("")
                .HasColumnType("ntext");
            entity.Property(e => e.EndDateUtc)
                .HasDefaultValue(new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.FirstApprovalDateUtc).HasColumnType("datetime");
            entity.Property(e => e.GeoList)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.LastEditByUserId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LinkButtonCaption)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.ModificationDateUtc).HasColumnType("datetime");
            entity.Property(e => e.PublicationDateUtc)
                .HasDefaultValue(new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.RevisionId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue(Guid.NewGuid())
                .HasConversion(new GuidToStringConverter());
            entity.Property(e => e.StartDateUtc)
                .HasDefaultValue(new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.HasBeenApproved).HasConversion(new BoolToZeroOneConverter<byte>());
        });

        modelBuilder.Entity<BrokerDirectoryDetail>(entity =>
        {
            entity.HasKey(e => new { e.BrokerId, e.InfoStatus });

            entity.Property(e => e.BrokerId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasConversion(new GuidToStringConverter());
            entity.Property(e => e.CompanyOverview)
                .HasDefaultValue("")
                .HasColumnType("ntext");
            entity.Property(e => e.CreationDateUtc).HasColumnType("datetime");
            entity.Property(e => e.DefaultArticleDisclaimer)
                .HasDefaultValue("")
                .HasColumnType("ntext");
            entity.Property(e => e.Disclaimer)
                .HasDefaultValue("")
                .HasColumnType("ntext");
            entity.Property(e => e.HasCommodities).HasColumnName("hasCommodities").HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.HasCrypto).HasColumnName("hasCrypto").HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.HasCtrader).HasColumnName("hasCTrader").HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.HasDaxStocks).HasColumnName("hasDAXStocks").HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.HasDjStocks).HasColumnName("hasDJStocks").HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.HasEquityIndices).HasColumnName("hasEquityIndices").HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.HasForexExotics).HasColumnName("hasFXExotics").HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.HasForexMajors).HasColumnName("hasFXMajors").HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.HasForexMinors).HasColumnName("hasFXMinors").HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.HasGoldAndSilver).HasColumnName("hasGoldAndSilver").HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.HasMt4).HasColumnName("hasMT4").HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.HasMt5).HasColumnName("hasMT5").HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.HasOtherMetals).HasColumnName("hasOtherMetals").HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.HasOtherPlatform).HasColumnName("hasOtherPlatform").HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.HasOwnPlatform).HasColumnName("hasOwnPlatform").HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.HasRegASIC).HasColumnName("hasRegASIC").HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.HasRegBaFin).HasColumnName("hasRegBaFin").HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.HasRegCayman).HasColumnName("hasRegCayman").HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.HasRegCFTC).HasColumnName("hasRegCFTC").HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.HasRegCysec).HasColumnName("hasRegCysec").HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.HasRegFSA).HasColumnName("hasRegFSA").HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.HasRegFSCA).HasColumnName("hasRegFSCA").HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.HasRegIFSC).HasColumnName("hasRegIFSC").HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.HasRegKenya).HasColumnName("hasRegKenya").HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.HasRegOther).HasColumnName("hasRegOther").HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.HasSpStocks).HasColumnName("hasSPStocks").HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.HasUk100Stocks).HasColumnName("hasUK100Stocks").HasConversion(new BoolToZeroOneConverter<byte>());
            entity.Property(e => e.LastEditByUserId).HasMaxLength(30);
            entity.Property(e => e.LiveAccountLink)
                .HasMaxLength(300)
                .HasDefaultValue("");
            entity.Property(e => e.ModificationDateUtc).HasColumnType("datetime");
            entity.Property(e => e.ProprietaryPlatformName)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.RevisionId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue(Guid.NewGuid())
                .HasConversion(new CustomGuidToStringConverter());
        });

        modelBuilder.Entity<BrokerDirectoryEditor>(entity =>
        {
            entity.HasKey(e => e.Username);

            entity.Property(e => e.Username)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BrokerId)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasDefaultValue("");
        });


        modelBuilder.Entity<BrokerDownload>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AccountId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BrokerId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CreationTime).HasColumnType("datetime");
            entity.Property(e => e.DownloadIpaddress)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("DownloadIPAddress");
            entity.Property(e => e.InstallIpaddress)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("InstallIPAddress");
            entity.Property(e => e.InstallTime).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<BrokerPermissionAccountList>(entity =>
        {
            entity.HasKey(e => new { e.BrokerId, e.AccountNumber });

            entity.ToTable("BrokerPermissionAccountList");

            entity.Property(e => e.BrokerId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PermissionMode).HasDefaultValue(1);
        });

        modelBuilder.Entity<BrokerPermissionAccountLogin>(entity =>
        {
            entity.HasKey(e => new { e.BrokerId, e.BrokerUsername }).HasName("PK_BrokerPermissionAccountLogins_1");

            entity.Property(e => e.BrokerId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.BrokerUsername)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BrokerPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BrokerUsageKeyMatch)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ChallengeImport>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ChallengeImport");

            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ChartAlertLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ChartAlertLog");

            entity.HasIndex(e => new { e.UserId, e.AlertTimeUtc }, "IX_ChartAlertLog");

            entity.Property(e => e.AlertText).HasColumnType("ntext");
            entity.Property(e => e.AlertTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.SentBySms).HasColumnName("SentBySMS");
            entity.Property(e => e.SmsOverQuota).HasColumnName("SMSOverQuota");
            entity.Property(e => e.UserId).HasMaxLength(30);
        });

        modelBuilder.Entity<ChartSharing>(entity =>
        {
            entity.ToTable("ChartSharing");

            entity.Property(e => e.ChartSharingId)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.ChartNotes).HasColumnType("ntext");
            entity.Property(e => e.ChartState).HasColumnType("ntext");
            entity.Property(e => e.CreationTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.FromUserId).HasMaxLength(30);
            entity.Property(e => e.LastAccessTimeUtc)
                .HasDefaultValue(new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.ToAddress)
                .HasMaxLength(100)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<ChartState>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.ToTable("ChartState");

            entity.HasIndex(e => e.ChartStateId, "IX_ChartState").IsUnique();

            entity.Property(e => e.UserId).HasMaxLength(30);
            entity.Property(e => e.BrowserHeartbeatUtc).HasColumnType("datetime");
            entity.Property(e => e.ChartState1)
                .HasColumnType("ntext")
                .HasColumnName("ChartState");
            entity.Property(e => e.ChartStateId)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.LastUpdateUtc).HasColumnType("datetime");
            entity.Property(e => e.ServerAlertState).HasColumnType("ntext");
            entity.Property(e => e.ServerHeartbeatUtc).HasColumnType("datetime");
            entity.Property(e => e.ServerId)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ChartUserSetting>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.Property(e => e.UserId).HasMaxLength(30);
            entity.Property(e => e.SendSms).HasColumnName("SendSMS");
            entity.Property(e => e.SmsquotaAmount).HasColumnName("SMSQuotaAmount");
            entity.Property(e => e.SmsquotaPeriod).HasColumnName("SMSQuotaPeriod");
            entity.Property(e => e.TwitterAccessKey)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TwitterAccessSecret)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TwitterScreenName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Chat>(entity =>
        {
            entity.HasKey(e => e.MessageCounter);

            entity.ToTable("Chat");

            entity.HasIndex(e => e.ChannelId, "IX_Chat_Channel");

            entity.Property(e => e.ChannelId)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.CreationTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.LastChangeTime).HasColumnType("datetime");
            entity.Property(e => e.MessageText).HasColumnType("ntext");
            entity.Property(e => e.UserId).HasMaxLength(30);

            entity.HasOne(d => d.Channel).WithMany(p => p.Chats)
                .HasForeignKey(d => d.ChannelId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Chat_ChatChannels");
        });

        modelBuilder.Entity<ChatChannel>(entity =>
        {
            entity.HasKey(e => e.ChannelId);

            entity.Property(e => e.ChannelId)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.CanAddMessages).HasDefaultValue((byte)1);
            entity.Property(e => e.CanDeleteMessages).HasDefaultValue((byte)1);
            entity.Property(e => e.CanEditMessages).HasDefaultValue((byte)1);
            entity.Property(e => e.ChannelCloseTime)
                .HasDefaultValue(new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.ChannelOpenTime)
                .HasDefaultValue(new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.ChannelPageSize).HasDefaultValue(100);
            entity.Property(e => e.MessageLimitCount).HasDefaultValue(2);
            entity.Property(e => e.MessageLimitLength).HasDefaultValue(500);
            entity.Property(e => e.MessageLimitSeconds).HasDefaultValue(60);
            entity.Property(e => e.OwnerId).HasMaxLength(30);
        });

        modelBuilder.Entity<Competition>(entity =>
        {
            entity.HasKey(e => e.CompetitionId).HasFillFactor(90);

            entity.Property(e => e.BrokerServer)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CompetitionCurrency)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CompetitionDescription).HasColumnType("text");
            entity.Property(e => e.CompetitionEndDateUtc).HasColumnType("datetime");
            entity.Property(e => e.CompetitionName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CompetitionOwnerCaption)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CompetitionOwnerId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CompetitionOwnerLogo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CompetitionStartDateUtc).HasColumnType("datetime");
            entity.Property(e => e.CompetitionStartEquity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.CompetitionUrl)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.CreationDateUtc).HasColumnType("datetime");
            entity.Property(e => e.MaxDrawdownCash).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MaxDrawdownPercent).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MaxLots).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.MinEquity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PermittedSymbols)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.SingleTradeLots).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<CompetitionForum>(entity =>
        {
            entity.HasKey(e => e.CompetitionForumMessageId)
                .HasName("PK_CompetitionMessages")
                .HasFillFactor(90);

            entity.ToTable("CompetitionForum");

            entity.Property(e => e.MessageText)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.MessageTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CompetitionInvitation>(entity =>
        {
            entity.HasKey(e => e.CompetitionInvitationId).HasFillFactor(90);

            entity.Property(e => e.CompetitionInvitationId)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.InvitationEmailAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CompetitionJoinMessage>(entity =>
        {
            entity.HasKey(e => new { e.CompetitionId, e.UserId }).HasFillFactor(90);

            entity.HasIndex(e => e.CompetitionJoinMessageId, "ix_CompetitionJoinMessages_Id")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CompetitionJoinMessageId)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Competitor>(entity =>
        {
            entity.HasKey(e => new { e.CompetitionId, e.UserId }).HasFillFactor(90);

            entity.HasIndex(e => e.UserId, "IX_Competitors_UserId");

            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BrokerAccountNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CompetitorCountry).HasMaxLength(30);
            entity.Property(e => e.CurrentOpenOrders).HasDefaultValue(-1);
            entity.Property(e => e.DisqualificationReasonText)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FirstRecordedEquity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.GrossDeposits).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LatestBalance).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LatestEquity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LotsTradedEver)
                .HasDefaultValue(-1m)
                .HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ParticipantDisplayName).HasMaxLength(50);
            entity.Property(e => e.PeakEquity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PeakLossPercent).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PercentReturn)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TotalOrdersEver).HasDefaultValue(-1);
            entity.Property(e => e.TroughEquity).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<CompetitorSnapshot>(entity =>
        {
            entity.HasKey(e => new { e.CompetitionId, e.UserId, e.SnapshotTime }).HasFillFactor(90);

            entity.HasIndex(e => new { e.CompetitionId, e.SnapshotTime }, "IX_CompetitorSnapshot_Time");

            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SnapshotTime).HasColumnType("datetime");
            entity.Property(e => e.SnapshotBalance).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SnapshotEquity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SnapshotGrossDeposits)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SnapshotMostRecentCalculation).HasColumnType("datetime");
            entity.Property(e => e.SnapshotPeakEquity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SnapshotPercentReturn)
                .HasDefaultValue(0m)
                .HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SnapshotTroughEquity).HasColumnType("decimal(18, 4)");
        });

        modelBuilder.Entity<ConnectAccount>(entity =>
        {
            entity.HasKey(e => e.ConnectAccount1).HasFillFactor(90);

            entity.Property(e => e.ConnectAccount1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ConnectAccount");
        });

        modelBuilder.Entity<ConnectAlarm>(entity =>
        {
            entity.HasKey(e => e.AlarmId).HasFillFactor(90);

            entity.HasIndex(e => e.ConnectAccount, "IX_ConnectAlarms").HasFillFactor(90);

            entity.HasIndex(e => new { e.ConnectAccount, e.ItemHash }, "IX_ConnectAlarms_AccountAndHash").HasFillFactor(90);

            entity.Property(e => e.AlarmCaption)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.AlarmTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.ConnectAccount)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ItemHash)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ConnectDashboardSubscription>(entity =>
        {
            entity.HasKey(e => new { e.ConnectAccount, e.Mtiaccount }).HasFillFactor(90);

            entity.HasIndex(e => e.ConnectAccount, "IX_ConnectDashboardSubscriptions").HasFillFactor(90);

            entity.Property(e => e.ConnectAccount)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Mtiaccount)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("MTIAccount");
            entity.Property(e => e.GroupName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MtiaccountPin)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MTIAccountPIN");
        });

        modelBuilder.Entity<ConnectFeed>(entity =>
        {
            entity.HasKey(e => e.FeedId).HasFillFactor(90);

            entity.HasIndex(e => e.ConnectAccount, "IX_ConnectFeeds").HasFillFactor(90);

            entity.HasIndex(e => new { e.ConnectAccount, e.FeedUrl }, "IX_ConnectFeeds_UserAndUrl")
                .IsUnique()
                .HasFillFactor(90);

            entity.Property(e => e.ConnectAccount)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FeedCaption)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.FeedUrl)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ConnectFeedFilter>(entity =>
        {
            entity.HasKey(e => e.FeedFilterId).HasFillFactor(90);

            entity.HasIndex(e => e.ConnectAccount, "IX_ConnectFeedFilters").HasFillFactor(90);

            entity.Property(e => e.ConnectAccount)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FilterCaption)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FilterText)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ConnectPriceList>(entity =>
        {
            entity.HasKey(e => new { e.ConnectAccount, e.PriceSymbol });

            entity.ToTable("ConnectPriceList");

            entity.Property(e => e.ConnectAccount)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PriceSymbol)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ConnectTweeter>(entity =>
        {
            entity.HasKey(e => e.TweeterId).HasFillFactor(90);

            entity.HasIndex(e => new { e.ConnectAccount, e.TweeterName }, "IX_ConnectTweeters")
                .IsUnique()
                .HasFillFactor(90);

            entity.HasIndex(e => e.ConnectAccount, "IX_ConnectTweeters_1").HasFillFactor(90);

            entity.Property(e => e.ConnectAccount)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TweeterName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TweeterUrl)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ConnectTweeterFilter>(entity =>
        {
            entity.HasKey(e => e.TweeterFilterId).HasFillFactor(90);

            entity.HasIndex(e => e.ConnectAccount, "IX_ConnectTweeterFilters").HasFillFactor(90);

            entity.Property(e => e.ConnectAccount)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FilterCaption)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FilterText)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Contest>(entity =>
        {
            entity.HasKey(e => e.ContestCounter).HasName("PK_Contests_1");

            entity.Property(e => e.CategoryId)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.ContestName).HasMaxLength(100);
            entity.Property(e => e.ContestOwnerId).HasMaxLength(30);
            entity.Property(e => e.CreationTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.DailyDrawdownLimit).HasColumnType("numeric(18, 6)");
            entity.Property(e => e.DepositCurrency)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.EndTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.MaxEntrants).HasDefaultValue(100);
            entity.Property(e => e.MaxHighWaterDrawdown).HasColumnType("numeric(18, 6)");
            entity.Property(e => e.MaxOpenLossPercent).HasColumnType("numeric(18, 6)");
            entity.Property(e => e.OwnerNotes).HasColumnType("ntext");
            entity.Property(e => e.ShutdownPercent).HasColumnType("numeric(18, 6)");
            entity.Property(e => e.StartTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.StartingFunds).HasColumnType("numeric(18, 6)");
            entity.Property(e => e.SymbolGroup).HasMaxLength(20);
            entity.Property(e => e.TargetPercent).HasColumnType("numeric(18, 6)");
        });

        modelBuilder.Entity<Contestant>(entity =>
        {
            entity.HasKey(e => new { e.ContestCounter, e.UserId }).HasName("PK_ContestEntrants");

            entity.Property(e => e.UserId).HasMaxLength(30);
            entity.Property(e => e.AccountId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AccountState).HasDefaultValue(-1);
            entity.Property(e => e.FinalEquity).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.PeakEquity).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TroughEquity).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<CountryCode>(entity =>
        {
            entity.HasKey(e => e.CountryCode1);

            entity.HasIndex(e => e.ISO3, "IX_ISO3").IsUnique();

            entity.Property(e => e.CountryCode1)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("CountryCode");
            entity.Property(e => e.CountryName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsAPAC).HasColumnName("IsAPAC");
            entity.Property(e => e.IsEFTA).HasColumnName("IsEFTA");
            entity.Property(e => e.IsEU).HasColumnName("IsEU");
            entity.Property(e => e.IsMENA).HasColumnName("IsMENA");
            entity.Property(e => e.ISO3)
                .HasMaxLength(3)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DeletedUser>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.BespokePageTitle)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BrokerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BrokerTimezoneDstmode).HasColumnName("BrokerTimezoneDSTMode");
            entity.Property(e => e.Downloadrate).HasColumnName("downloadrate");
            entity.Property(e => e.Eaversion)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("EAVersion");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmailValidationCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmbeddedUrl)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EmbeddedUrlTabName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Enableflag).HasColumnName("enableflag");
            entity.Property(e => e.FirstUpload).HasColumnType("datetime");
            entity.Property(e => e.Homedirectory)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("homedirectory");
            entity.Property(e => e.Idletime).HasColumnName("idletime");
            entity.Property(e => e.LastItmactivityUtc)
                .HasColumnType("datetime")
                .HasColumnName("LastITMActivityUtc");
            entity.Property(e => e.LeadBatch)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LeadCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Maxloginnumber).HasColumnName("maxloginnumber");
            entity.Property(e => e.Maxloginperip).HasColumnName("maxloginperip");
            entity.Property(e => e.MostRecentUpload).HasColumnType("datetime");
            entity.Property(e => e.OldPassword)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.PhoneCountry)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.PhoneFamilyName).HasMaxLength(30);
            entity.Property(e => e.PhoneGivenName).HasMaxLength(30);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PhoneValidationCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PhoneVerificationSession)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.ResultPin)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ResultPIN");
            entity.Property(e => e.SignUpDate).HasColumnType("datetime");
            entity.Property(e => e.SignupCountry)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.SignupIpaddress)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SignupIPAddress");
            entity.Property(e => e.SubAccountOf).HasMaxLength(30);
            entity.Property(e => e.SystemDescription)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TimeAdjustDstmode).HasColumnName("TimeAdjustDSTMode");
            entity.Property(e => e.TimeAdjustInsideDst).HasColumnName("TimeAdjustInsideDST");
            entity.Property(e => e.TimeAdjustOutsideDst).HasColumnName("TimeAdjustOutsideDST");
            entity.Property(e => e.TwitterSecret)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TwitterToken)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Uploadrate).HasColumnName("uploadrate");
            entity.Property(e => e.UserDescription).HasColumnType("text");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UserSource)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UserUniverse)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Userid)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("userid");
            entity.Property(e => e.Userpassword)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("userpassword");
            entity.Property(e => e.VerificationContext)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.VerificationStartTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.Website)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Writepermission).HasColumnName("writepermission");
        });

        modelBuilder.Entity<DemoAccountPool>(entity =>
        {
            entity.HasKey(e => new { e.PoolGroup, e.AccountNumber });

            entity.ToTable("DemoAccountPool");

            entity.Property(e => e.PoolGroup)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AccountPassword)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AccountServer)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FixiTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FixiTemp");

            entity.Property(e => e.BrokerAccountNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CompetitorCountry).HasMaxLength(30);
            entity.Property(e => e.DisqualificationReasonText)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.FirstRecordedEquity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.GrossDeposits).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LatestBalance).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LatestEquity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.LotsTradedEver).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.PeakEquity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PeakLossPercent).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PercentReturn).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.TroughEquity).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<HitTracking>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("HitTracking");

            entity.Property(e => e.HitTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.HitUrl)
                .HasMaxLength(256)
                .IsUnicode(false);
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("IPAddress");
            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ImpressionTracking>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ImpressionTracking");

            entity.Property(e => e.AdvertId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ImpressionTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("IPAddress");
        });

        modelBuilder.Entity<Lead>(entity =>
        {
            entity.HasKey(e => e.EmailAddress);

            entity.HasIndex(e => e.LeadBatchId, "IX_Leads");

            entity.HasIndex(e => new { e.LeadBatchId, e.LeadCode }, "IX_Leads_Index1");

            entity.HasIndex(e => new { e.LeadCode, e.EmailAddress, e.PhoneNumber }, "IX_Leads_LeadAllocSearch");

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Cpl)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("CPL");
            entity.Property(e => e.LeadBatchId)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.LeadCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.LeadDateUtc).HasColumnType("datetime");
            entity.Property(e => e.PendingAllocationDate)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PhoneCountry)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.PhoneFamilyName).HasMaxLength(30);
            entity.Property(e => e.PhoneGivenName).HasMaxLength(30);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<LeadCompany>(entity =>
        {
            entity.HasKey(e => e.LeadCode);

            entity.Property(e => e.LeadCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.EmailPassword)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("FXBlueLeads");
            entity.Property(e => e.LeadContacts).IsUnicode(false);
            entity.Property(e => e.SendEmail).HasDefaultValue((byte)1);
        });

        modelBuilder.Entity<Lttcoach>(entity =>
        {
            entity.ToTable("LTTCoaches");

            entity.HasIndex(e => e.LttemailAddress, "IX_LTTCoaches").IsUnique();

            entity.Property(e => e.LttcoachId)
                .ValueGeneratedNever()
                .HasColumnName("LTTCoachId");
            entity.Property(e => e.CoachCountry)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("UK");
            entity.Property(e => e.EncryptedPassword)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.IsLoginAllowed).HasDefaultValue((short)1);
            entity.Property(e => e.IsVisible).HasDefaultValue((short)1);
            entity.Property(e => e.LockedUntil)
                .HasDefaultValue(new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.LttcoachName)
                .HasMaxLength(40)
                .IsUnicode(false)
                .HasColumnName("LTTCoachName");
            entity.Property(e => e.LttemailAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("LTTEmailAddress");
            entity.Property(e => e.Region)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("UK");
            entity.Property(e => e.SendEmails).HasDefaultValue((short)1);
        });

        modelBuilder.Entity<LttemailSubscription>(entity =>
        {
            entity.HasKey(e => e.LttlicenceId);

            entity.ToTable("LTTEmailSubscriptions");

            entity.Property(e => e.LttlicenceId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LTTLicenceId");
            entity.Property(e => e.CoachExclusions)
                .HasMaxLength(300)
                .IsUnicode(false);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.IsActive).HasDefaultValue((short)1);
            entity.Property(e => e.StrategyInclusions)
                .HasMaxLength(300)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Lttscreenshot>(entity =>
        {
            entity.HasKey(e => e.LttsignalId);

            entity.ToTable("LTTScreenshots");

            entity.Property(e => e.LttsignalId)
                .ValueGeneratedNever()
                .HasColumnName("LTTSignalId");
            entity.Property(e => e.ScreenshotFormat)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Lttsignal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LTTSignals");

            entity.Property(e => e.CreationTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.LastEditTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.LttcoachId).HasColumnName("LTTCoachId");
            entity.Property(e => e.Lttcomments)
                .HasColumnType("text")
                .HasColumnName("LTTComments");
            entity.Property(e => e.LttentryPrice)
                .HasColumnType("decimal(10, 6)")
                .HasColumnName("LTTEntryPrice");
            entity.Property(e => e.LttisSignalValid)
                .HasDefaultValue((short)1)
                .HasColumnName("LTTIsSignalValid");
            entity.Property(e => e.LttsignalExpiryUtc)
                .HasColumnType("datetime")
                .HasColumnName("LTTSignalExpiryUtc");
            entity.Property(e => e.LttsignalId)
                .ValueGeneratedOnAdd()
                .HasColumnName("LTTSignalId");
            entity.Property(e => e.LttsignalTimeUtc)
                .HasColumnType("datetime")
                .HasColumnName("LTTSignalTimeUtc");
            entity.Property(e => e.LttstopLoss)
                .HasColumnType("decimal(10, 6)")
                .HasColumnName("LTTStopLoss");
            entity.Property(e => e.LttstrategyId).HasColumnName("LTTStrategyId");
            entity.Property(e => e.Lttsymbol)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("LTTSymbol");
            entity.Property(e => e.LtttakeProfit)
                .HasColumnType("decimal(10, 6)")
                .HasColumnName("LTTTakeProfit");
            entity.Property(e => e.LtttradeDirection).HasColumnName("LTTTradeDirection");
            entity.Property(e => e.StrategyField1)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StrategyField2)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StrategyField3)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StrategyField4)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StrategyField5)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StrategyField6)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StrategyField7)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StrategyField8)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StrategyParam1).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.StrategyParam2).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.StrategyParam3).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.StrategyParam4).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.StrategyParam5).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.StrategyParam6).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.StrategyParam7).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.StrategyParam8).HasColumnType("decimal(18, 6)");

            entity.HasOne(d => d.Lttcoach).WithMany()
                .HasForeignKey(d => d.LttcoachId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LTTSignals_LTTCoaches");

            entity.HasOne(d => d.Lttstrategy).WithMany()
                .HasForeignKey(d => d.LttstrategyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_LTTSignals_LTTStrategies");
        });

        modelBuilder.Entity<Lttstrategy>(entity =>
        {
            entity.ToTable("LTTStrategies");

            entity.Property(e => e.LttstrategyId)
                .ValueGeneratedNever()
                .HasColumnName("LTTStrategyId");
            entity.Property(e => e.IsVisible).HasDefaultValue((short)1);
            entity.Property(e => e.LttstrategyName)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("LTTStrategyName");
            entity.Property(e => e.ScannerName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.StrategyCourse)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("FX");
        });

        modelBuilder.Entity<MailJourney>(entity =>
        {
            entity.Property(e => e.MailJourneyId).ValueGeneratedNever();
            entity.Property(e => e.Caption)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CheckDuplicatesByEmailAddress).HasDefaultValue((byte)1);
            entity.Property(e => e.ClickJourneyRedirect)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ExpireDuplicatesAfterDays).HasDefaultValue(30);
            entity.Property(e => e.MailFileName)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<MailJourneyItem>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.UserId, e.MailJourneyId }, "IX_MailJourneyItems");

            entity.HasIndex(e => new { e.IsPending, e.SendTimeUtc }, "IX_MailJourneyItems_Pending");

            entity.Property(e => e.IsPending).HasDefaultValue((byte)1);
            entity.Property(e => e.MailJourneyItemId)
                .HasMaxLength(36)
                .IsUnicode(false);
            entity.Property(e => e.SendTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(30);
        });

        modelBuilder.Entity<MirrorInviteCode>(entity =>
        {
            entity.HasKey(e => e.MirrorInviteCode1);

            entity.Property(e => e.MirrorInviteCode1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MirrorInviteCode");
            entity.Property(e => e.CreationDateUtc).HasColumnType("datetime");
            entity.Property(e => e.EmailAddress).HasMaxLength(50);
            entity.Property(e => e.SubscriberId)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.UserId).HasMaxLength(30);
        });

        modelBuilder.Entity<NewsFeedLogin>(entity =>
        {
            entity.HasKey(e => e.WebAccessId);

            entity.Property(e => e.WebAccessId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.AllowWebAccess).HasDefaultValue((byte)1);
            entity.Property(e => e.BrokerServer)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.CreationDateUtc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.ExpiryDateUtc)
                .HasDefaultValue(new DateTime(2099, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.FeedId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FeedProvider)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LastLoginTimeUtc)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.PlatformId)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NewsFeedLoginActivity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NewsFeedLoginActivity");

            entity.HasIndex(e => new { e.WebAccessId, e.AccessTimeUtc }, "IX_NewsFeedLoginActivity");

            entity.Property(e => e.AccessTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.ComputerId)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("IPAddress");
            entity.Property(e => e.WebAccessId)
                .HasMaxLength(12)
                .IsUnicode(false);
        });

        modelBuilder.Entity<NewsFeedLoginDatum>(entity =>
        {
            entity.HasKey(e => e.WebAccessId);

            entity.Property(e => e.WebAccessId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.LastChangeUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<NewsItem>(entity =>
        {
            entity.Property(e => e.LatestPubDate).HasColumnType("datetime");
            entity.Property(e => e.LatestRecordChange).HasColumnType("datetime");
            entity.Property(e => e.NewsLanguage)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasDefaultValue("en");
            entity.Property(e => e.NewsProvider)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NewsTitle).HasMaxLength(200);
            entity.Property(e => e.OriginalGuid).HasMaxLength(50);
            entity.Property(e => e.OriginalPubDate).HasColumnType("datetime");
            entity.Property(e => e.RssDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<NewsItemTag>(entity =>
        {
            entity.HasKey(e => new { e.NewsItemId, e.TagType, e.TagValue });

            entity.HasIndex(e => e.TagValue, "IX_NewsItemTags_TagValue");

            entity.Property(e => e.TagValue).HasMaxLength(20);

            entity.HasOne(d => d.NewsItem).WithMany(p => p.NewsItemTags)
                .HasForeignKey(d => d.NewsItemId)
                .HasConstraintName("FK_NewsItemTags_NewsItems");
        });

        modelBuilder.Entity<NewsItemTagsArchive>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("NewsItemTags_Archive");

            entity.HasIndex(e => e.NewsItemId, "IX_NewsItemTags_Archive");

            entity.Property(e => e.TagValue).HasMaxLength(20);
        });

        modelBuilder.Entity<NewsItemsArchive>(entity =>
        {
            entity.HasKey(e => e.NewsItemId).HasName("PK_NewsItems_Old");

            entity.ToTable("NewsItems_Archive");

            entity.Property(e => e.NewsItemId).ValueGeneratedNever();
            entity.Property(e => e.LatestPubDate).HasColumnType("datetime");
            entity.Property(e => e.LatestRecordChange)
                .HasDefaultValueSql("(getutcdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.NewsLanguage)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.NewsProvider)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.NewsTitle).HasMaxLength(200);
            entity.Property(e => e.OriginalGuid).HasMaxLength(50);
            entity.Property(e => e.OriginalPubDate).HasColumnType("datetime");
            entity.Property(e => e.RssDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<NoMailshot>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.EmailAddress, "IX_NoMailshots");

            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Performance>(entity =>
        {
            entity.HasKey(e => e.UserId).HasFillFactor(90);

            entity.ToTable("Performance");

            entity.HasIndex(e => new { e.SystemTypeId, e.MostRecentCalculation }, "IX_Performance_CountActive");

            entity.HasIndex(e => e.SystemTypeId, "IX_Performance_SystemType");

            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.AccountCurrency)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.AverageTradeDuration).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.BrokerAccountNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DeepestValley).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.LatestEquity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MonthlyGain).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.MostRecentCalculation).HasColumnType("datetime");
            entity.Property(e => e.MostRecentTrade).HasColumnType("datetime");
            entity.Property(e => e.MostTradedSymbol)
                .HasMaxLength(20)
                .HasDefaultValue("");
            entity.Property(e => e.ProfitFactor).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.RoR10).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.RoR25).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.RoR50).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Rrr)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("RRR");
            entity.Property(e => e.TotalGain).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TotalTradeCount).HasDefaultValue(-1);
            entity.Property(e => e.TradesPerDay).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TradingDays).HasDefaultValue(-1);
            entity.Property(e => e.WeeklyGain).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.WinRate)
                .HasDefaultValue(-1m)
                .HasColumnType("decimal(10, 2)");
            entity.Property(e => e.WorstDay).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.WorstMonth).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.WorstWeek).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<PerformanceOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("performance_old");

            entity.Property(e => e.AccountCurrency)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.AverageTradeDuration).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.BrokerAccountNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DeepestValley).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.LatestEquity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.MonthlyGain).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.MostRecentCalculation).HasColumnType("datetime");
            entity.Property(e => e.MostRecentTrade).HasColumnType("datetime");
            entity.Property(e => e.ProfitFactor).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.RoR10).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.RoR25).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.RoR50).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.Rrr)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("RRR");
            entity.Property(e => e.TotalGain).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.TradesPerDay).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.WeeklyGain).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.WorstDay).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.WorstMonth).HasColumnType("decimal(10, 2)");
            entity.Property(e => e.WorstWeek).HasColumnType("decimal(10, 2)");
        });

        modelBuilder.Entity<PhoneValidationCache>(entity =>
        {
            entity.HasKey(e => e.PhoneNumber);

            entity.ToTable("PhoneValidationCache");

            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CacheDateUtc).HasColumnType("datetime");
            entity.Property(e => e.NetworkType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Reachability)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Validity)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Portfolio>(entity =>
        {
            entity.HasKey(e => e.PortfolioId).HasFillFactor(90);

            entity.HasIndex(e => e.OwnerId, "IX_Portfolios_Owner").HasFillFactor(90);

            entity.Property(e => e.PortfolioId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OwnerId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PortfolioDescription)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.PortfolioTitle)
                .HasMaxLength(200)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PortfolioConstituent>(entity =>
        {
            entity.HasKey(e => new { e.PortfolioId, e.ConstituentId }).HasFillFactor(90);

            entity.Property(e => e.PortfolioId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ConstituentId)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Prediction>(entity =>
        {
            entity.Property(e => e.AcceptancePeriod).HasDefaultValue(60);
            entity.Property(e => e.AdoptionPrice).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.AutoWithdrawHighPrice)
                .HasDefaultValue(999999m)
                .HasColumnType("decimal(12, 6)");
            entity.Property(e => e.AutoWithdrawLowPrice).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.ClosePrice).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.CreationPrice).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.CreationTime).HasColumnType("datetime");
            entity.Property(e => e.CreatorPipResult).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.EndTime)
                .HasDefaultValue(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.GrossPipResult).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.HighestPrice).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.LowestPrice).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.MinTerminationPeriodMinutes).HasDefaultValue(25);
            entity.Property(e => e.OpenPrice).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.OpponentId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.OpponentPipResult).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.PipSize).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.PipTarget).HasDefaultValue(9999);
            entity.Property(e => e.PredictionSymbol)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PriceTargetHigh)
                .HasDefaultValue(999999m)
                .HasColumnType("decimal(12, 6)");
            entity.Property(e => e.PriceTargetLow).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.RunPeriod).HasDefaultValue(1800);
            entity.Property(e => e.StartTime)
                .HasDefaultValue(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.SystemOpponentWeighting).HasDefaultValue(50);
            entity.Property(e => e.UseSystemOpponent).HasDefaultValue((short)1);
            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PredictionCredit>(entity =>
        {
            entity.HasIndex(e => e.CreditTimeUtc, "IX_PredictionCredits_CreationTimeUtc");

            entity.HasIndex(e => e.UserId, "IX_PredictionCredits_User");

            entity.Property(e => e.CreditTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.PipCredit).HasColumnType("decimal(14, 2)");
            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PredictionMessage>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.PredictionMessageId).ValueGeneratedOnAdd();
            entity.Property(e => e.PredictionMessageTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PredictionPriceBar>(entity =>
        {
            entity.HasKey(e => new { e.Symbol, e.BarDate });

            entity.Property(e => e.Symbol)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PriceClose).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.PriceHigh).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.PriceLow).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.PriceOpen).HasColumnType("decimal(12, 6)");
        });

        modelBuilder.Entity<PredictionState>(entity =>
        {
            entity.Property(e => e.PredictionStateId).ValueGeneratedNever();
            entity.Property(e => e.PredictionStateName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<PredictionSymbol>(entity =>
        {
            entity.HasKey(e => e.PredictionSymbol1);

            entity.Property(e => e.PredictionSymbol1)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("PredictionSymbol");
            entity.Property(e => e.IsEnabled).HasDefaultValue((short)1);
            entity.Property(e => e.PipSize).HasColumnType("decimal(12, 6)");
        });

        modelBuilder.Entity<PredictionSymbolPrice>(entity =>
        {
            entity.HasKey(e => e.PredictionSymbol);

            entity.Property(e => e.PredictionSymbol)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MidPrice).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.PriceTimeUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<PredictionpricebarsOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("predictionpricebars_old");

            entity.Property(e => e.PriceClose).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.PriceHigh).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.PriceLow).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.PriceOpen).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.Symbol)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<QuickChannelSubscriber>(entity =>
        {
            entity.HasKey(e => new { e.ChannelId, e.SubscriberId });

            entity.Property(e => e.ChannelId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SubscriberId)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Room>(entity =>
        {
            entity.Property(e => e.AllowMessages).HasDefaultValue((short)1);
            entity.Property(e => e.DefaultMemberAllowMessages).HasDefaultValue((short)1);
            entity.Property(e => e.MaxShowTradeMode).HasDefaultValue(2);
            entity.Property(e => e.RoomName).HasMaxLength(100);
            entity.Property(e => e.RoomOwnerId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ShowTrades).HasDefaultValue((short)1);
        });

        modelBuilder.Entity<RoomAction>(entity =>
        {
            entity.HasIndex(e => e.RoomId, "IX_RoomActions");

            entity.Property(e => e.RoomActionTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.User1Id)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.User2Id)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RoomActionType>(entity =>
        {
            entity.Property(e => e.RoomActionTypeId).ValueGeneratedNever();
            entity.Property(e => e.RoomActionTypename)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RoomBrokerAccount>(entity =>
        {
            entity.HasIndex(e => new { e.RoomUserId, e.BrokerAccountId }, "IX_RoomBrokerAccounts").IsUnique();

            entity.Property(e => e.AccountBalance).HasColumnType("decimal(14, 2)");
            entity.Property(e => e.AccountBrokerTime).HasColumnType("datetime");
            entity.Property(e => e.AccountClosedPl)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("AccountClosedPL");
            entity.Property(e => e.AccountCredit).HasColumnType("decimal(14, 2)");
            entity.Property(e => e.AccountCurrency)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.AccountEquity).HasColumnType("decimal(14, 2)");
            entity.Property(e => e.AccountFloatingPl)
                .HasColumnType("decimal(14, 2)")
                .HasColumnName("AccountFloatingPL");
            entity.Property(e => e.AccountFreeMargin).HasColumnType("decimal(14, 2)");
            entity.Property(e => e.AccountLeverage).HasColumnType("decimal(14, 2)");
            entity.Property(e => e.AccountMarginInUse).HasColumnType("decimal(14, 2)");
            entity.Property(e => e.AccountName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BrokerAccountId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BrokerServer)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EurusdlotSize)
                .HasColumnType("decimal(14, 4)")
                .HasColumnName("EURUSDLotSize");
            entity.Property(e => e.EurusdminVolume)
                .HasColumnType("decimal(14, 4)")
                .HasColumnName("EURUSDMinVolume");
            entity.Property(e => e.LastUpdateIpaddress)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("LastUpdateIPAddress");
            entity.Property(e => e.LastUpdateUtc).HasColumnType("datetime");
            entity.Property(e => e.PublisherVersion).HasColumnType("decimal(14, 2)");
            entity.Property(e => e.RoomUserId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UsdconversionFactor)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("USDConversionFactor");
        });

        modelBuilder.Entity<RoomCommand>(entity =>
        {
            entity.HasIndex(e => new { e.RoomUserId, e.RoomCommandStateId }, "IX_RoomCommands");

            entity.Property(e => e.BaseEquity).HasColumnType("decimal(14, 4)");
            entity.Property(e => e.CollectionDateUtc)
                .HasDefaultValue(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.CommandParams)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.CommandPrice).HasColumnType("decimal(14, 6)");
            entity.Property(e => e.CommandSl)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("CommandSL");
            entity.Property(e => e.CommandSymbol)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CommandText)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CommandTicketId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.CommandTp)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("CommandTP");
            entity.Property(e => e.CommandVolume).HasColumnType("decimal(14, 6)");
            entity.Property(e => e.CreationDateUtc).HasColumnType("datetime");
            entity.Property(e => e.HasCreatedTicketId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.ResultDateUtc)
                .HasDefaultValue(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.RoomUserId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SourceUserId)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RoomCommandResponseDatum>(entity =>
        {
            entity.HasKey(e => e.RoomCommandId);

            entity.Property(e => e.RoomCommandId).ValueGeneratedNever();
            entity.Property(e => e.ResponseData).IsUnicode(false);
        });

        modelBuilder.Entity<RoomEntityType>(entity =>
        {
            entity.Property(e => e.RoomEntityTypeId).ValueGeneratedNever();
            entity.Property(e => e.RoomEntityTypeName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RoomFollower>(entity =>
        {
            entity.HasIndex(e => new { e.RoomId, e.FollowOfUserId, e.FollowByUserId }, "IX_RoomFollowers_Unique").IsUnique();

            entity.Property(e => e.CreationDateUtc).HasColumnType("datetime");
            entity.Property(e => e.FollowByUserId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FollowOfUserId)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RoomLike>(entity =>
        {
            entity.HasIndex(e => new { e.LikeByUserId, e.LikeEntityId, e.LikeEntityTypeId }, "IX_Like_UniqueUserEntity").IsUnique();

            entity.HasIndex(e => new { e.RoomId, e.LikeEntityId }, "IX_RoomLikes");

            entity.Property(e => e.LikeByUserId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LikeDateUtc).HasColumnType("datetime");
            entity.Property(e => e.LikeOfUserId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LikeValue)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<RoomMember>(entity =>
        {
            entity.HasIndex(e => new { e.RoomId, e.RoomUserId }, "IX_RoomMembers_UniqueRoomAndMember").IsUnique();

            entity.Property(e => e.AllowApimessages).HasColumnName("AllowAPIMessages");
            entity.Property(e => e.AllowMessages).HasDefaultValue((short)1);
            entity.Property(e => e.JoinDateUtc).HasColumnType("datetime");
            entity.Property(e => e.LastOrderSyncUtc)
                .HasDefaultValue(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.LikeWeighting)
                .HasDefaultValue(1m)
                .HasColumnType("decimal(14, 2)");
            entity.Property(e => e.MembershipExpiryUtc)
                .HasDefaultValue(new DateTime(2029, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.MessagesDisabledUntilUtc)
                .HasDefaultValue(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.RoomUserId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ShowAccountHeadline).HasDefaultValue(1);
            entity.Property(e => e.TotalMessageLikeValue).HasColumnType("decimal(14, 2)");
            entity.Property(e => e.TotalTradeLikeValue).HasColumnType("decimal(14, 2)");
        });

        modelBuilder.Entity<RoomMemberLevel>(entity =>
        {
            entity.Property(e => e.RoomMemberLevelId).ValueGeneratedNever();
            entity.Property(e => e.RoomMemberLevelName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RoomMessage>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FollowerMessageId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MessageCategory).HasMaxLength(50);
            entity.Property(e => e.MessageId).ValueGeneratedOnAdd();
            entity.Property(e => e.MessageLikeValue).HasColumnType("decimal(14, 2)");
            entity.Property(e => e.MessageTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.PrivateMessageTo)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.RoomUserId)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RoomOrder>(entity =>
        {
            entity.HasKey(e => e.RoomOrderId).HasName("PK_RoomOrders_1");

            entity.HasIndex(e => new { e.RoomUserId, e.BrokerAccountId, e.TicketId }, "IX_RoomOrders").IsUnique();

            entity.Property(e => e.BrokerAccountId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BrokerCloseTime)
                .HasDefaultValue(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.BrokerOpenTime).HasColumnType("datetime");
            entity.Property(e => e.ClosePrice).HasColumnType("decimal(14, 6)");
            entity.Property(e => e.FinalOrderLots).HasColumnType("decimal(14, 6)");
            entity.Property(e => e.FinalOrderVolume).HasColumnType("decimal(14, 6)");
            entity.Property(e => e.LastUpdateUtc).HasColumnType("datetime");
            entity.Property(e => e.OpenPrice).HasColumnType("decimal(14, 6)");
            entity.Property(e => e.OrderComment)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.OrderCommission).HasColumnType("decimal(14, 6)");
            entity.Property(e => e.OrderLikeValue).HasColumnType("decimal(14, 2)");
            entity.Property(e => e.OrderProfit).HasColumnType("decimal(14, 6)");
            entity.Property(e => e.OrderSwap).HasColumnType("decimal(14, 6)");
            entity.Property(e => e.OrderSymbol)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.OriginalOrderLots).HasColumnType("decimal(14, 6)");
            entity.Property(e => e.OriginalOrderVolume).HasColumnType("decimal(14, 6)");
            entity.Property(e => e.PartialCloseTicketId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.RoomUserId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Sl)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("SL");
            entity.Property(e => e.SystemCloseTimeUtc)
                .HasDefaultValue(new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.SystemOpenTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.TicketId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Tp)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("TP");
        });

        modelBuilder.Entity<RoomOrderActionType>(entity =>
        {
            entity.HasKey(e => e.RoomOrderActionid).HasName("PK_RoomOrderActions");

            entity.Property(e => e.RoomOrderActionid).ValueGeneratedNever();
            entity.Property(e => e.RoomOrderAction)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<RoomOrderState>(entity =>
        {
            entity.Property(e => e.RoomOrderStateId).ValueGeneratedNever();
            entity.Property(e => e.RoomOrderStateName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SiteUser>(entity =>
        {
            entity.HasKey(e => e.UserId)
                .HasName("PK_FTP_USER")
                .HasFillFactor(90);

            entity.HasIndex(e => e.EmailValidationCode, "IX_SiteUsers_EmailValidationCode");

            entity.HasIndex(e => new { e.LeadCode, e.EmailAddress, e.PhoneNumber }, "IX_SiteUsers_LeadAllocSearch");

            entity.HasIndex(e => new { e.EmailAddress, e.NoMailshots, e.PhoneCountry }, "IX_SiteUsers_LeadGeneration2");

            entity.HasIndex(e => e.SubAccountOf, "IX_SiteUsers_SubAccountOf");

            entity.Property(e => e.UserId)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("userid");
            entity.Property(e => e.BespokePageTitle)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BrokerName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.BrokerTimezoneDstmode)
                .HasDefaultValue(-1)
                .HasColumnName("BrokerTimezoneDSTMode");
            entity.Property(e => e.Downloadrate).HasColumnName("downloadrate");
            entity.Property(e => e.Eaversion)
                .HasColumnType("decimal(10, 4)")
                .HasColumnName("EAVersion");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.EmailValidationCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EmbeddedUrl)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.EmbeddedUrlTabName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.EnableFlag)
                .HasDefaultValue(true)
                .HasColumnName("enableflag");
            entity.Property(e => e.FirstUpload).HasColumnType("datetime");
            entity.Property(e => e.HideAccountName).HasDefaultValue((byte)1);
            entity.Property(e => e.HideAccountNumber).HasDefaultValue((byte)1);
            entity.Property(e => e.HomeDirectory)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("homedirectory");
            entity.Property(e => e.Idletime).HasColumnName("idletime");
            entity.Property(e => e.IsPhoneValidated).HasConversion<BoolToZeroOneConverter<int>>();
            entity.Property(e => e.IsEmailValidated).HasConversion<BoolToZeroOneConverter<int>>();
            entity.Property(e => e.LastItmActivityUtc)
                .HasColumnType("datetime")
                .HasColumnName("LastITMActivityUtc");
            entity.Property(e => e.LeadBatch)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.LeadCode)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.ListInDirectory).HasDefaultValue((byte)1);
            entity.Property(e => e.MaxSignalClients).HasDefaultValue(100);
            entity.Property(e => e.MaxUploadedOrders).HasDefaultValue(100000);
            entity.Property(e => e.MaxLoginNumber).HasColumnName("maxloginnumber");
            entity.Property(e => e.MaxLoginPerIp).HasColumnName("maxloginperip");
            entity.Property(e => e.MostRecentUpload).HasColumnType("datetime");
            entity.Property(e => e.NoMailshots).HasDefaultValue((short)0);
            entity.Property(e => e.OldPassword)
                .HasMaxLength(64)
                .IsUnicode(false);
            entity.Property(e => e.PhoneCountry)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.PhoneFamilyName).HasMaxLength(30);
            entity.Property(e => e.PhoneGivenName).HasMaxLength(30);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PhoneValidationCode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PhoneVerificationSession)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.ResultPin)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("ResultPIN");
            entity.Property(e => e.SignUpDate).HasColumnType("datetime");
            entity.Property(e => e.SignupCountry)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.SignupIpaddress)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("SignupIPAddress");
            entity.Property(e => e.SlingshotQuota).HasDefaultValue(100000);
            entity.Property(e => e.StatementStyle).HasDefaultValue(1);
            entity.Property(e => e.SubAccountOf).HasMaxLength(30);
            entity.Property(e => e.SystemDescription)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.SystemDescriptionPublic).HasDefaultValue((byte)1);
            entity.Property(e => e.TimeAdjustDstmode)
                .HasDefaultValue(-1)
                .HasColumnName("TimeAdjustDSTMode");
            entity.Property(e => e.TimeAdjustInsideDst).HasColumnName("TimeAdjustInsideDST");
            entity.Property(e => e.TimeAdjustOutsideDst).HasColumnName("TimeAdjustOutsideDST");
            entity.Property(e => e.TwitterSecret)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TwitterToken)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Uploadrate).HasColumnName("uploadrate");
            entity.Property(e => e.UserDescription).HasColumnType("text");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.UserSource)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UserUniverse)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("mt4i");
            entity.Property(e => e.UserPassword)
                .HasMaxLength(64)
                .IsUnicode(false)
                .HasColumnName("userpassword");
            entity.Property(e => e.VerificationContext)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.VerificationStartTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.Website)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.Writepermission)
                .HasDefaultValue(true)
                .HasColumnName("writepermission");
        });

        modelBuilder.Entity<Slingshot>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_Slingshots_UserId");

            entity.Property(e => e.SlingshotId)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.CreationDateUtc).HasColumnType("datetime");
            entity.Property(e => e.DisplayUrl).HasMaxLength(200);
            entity.Property(e => e.LastUploadUtc).HasColumnType("datetime");
            entity.Property(e => e.MostRecentCommentUtc).HasColumnType("datetime");
            entity.Property(e => e.OneTimeLogin)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.PackageManifest).HasColumnType("ntext");
            entity.Property(e => e.PackageMode)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.ShowForum).HasDefaultValue((short)1);
            entity.Property(e => e.SlingshotDescription).HasMaxLength(1000);
            entity.Property(e => e.SlingshotTitle).HasMaxLength(30);
            entity.Property(e => e.UpgradedById)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasMaxLength(30);
        });

        modelBuilder.Entity<SlingshotDownload>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.SlingshotId, e.DownloadUserId }, "IX_SlingshotDownloads_1");

            entity.Property(e => e.DownloadDateUtc).HasColumnType("datetime");
            entity.Property(e => e.DownloadIpaddress)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("DownloadIPAddress");
            entity.Property(e => e.DownloadUserId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SlingshotId)
                .HasMaxLength(32)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SlingshotForum>(entity =>
        {
            entity.HasKey(e => e.SlingshotMessageId);

            entity.ToTable("SlingshotForum");

            entity.HasIndex(e => e.SlingshotId, "IX_SlingshotForum");

            entity.Property(e => e.CreationDateUtc).HasColumnType("datetime");
            entity.Property(e => e.ForumMessage).HasMaxLength(1000);
            entity.Property(e => e.LastEditUtc).HasColumnType("datetime");
            entity.Property(e => e.Rating).HasDefaultValue(-1);
            entity.Property(e => e.SlingshotId)
                .HasMaxLength(32)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasMaxLength(30);
        });

        modelBuilder.Entity<SlingshotTracking>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SlingshotTracking");

            entity.Property(e => e.ComputerId)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.HitTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("IPAddress");
            entity.Property(e => e.PackageId)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.PackageTitle).HasMaxLength(50);
            entity.Property(e => e.PlatformId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PremiumMode)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SoftwareLicence>(entity =>
        {
            entity.HasKey(e => e.LicenceId);

            entity.Property(e => e.LicenceId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.AffiliateId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasDefaultValueSql("((0))");
            entity.Property(e => e.AssignedToHardwareId)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.CheckHardwareId).HasDefaultValue((short)1);
            entity.Property(e => e.FirstLicenceHitUtc).HasColumnType("datetime");
            entity.Property(e => e.LastIpaddress)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("LastIPAddress");
            entity.Property(e => e.LastIpaddressTime)
                .HasColumnType("datetime")
                .HasColumnName("LastIPAddressTime");
            entity.Property(e => e.LastReleaseTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.LicenceExpiryDate)
                .HasDefaultValue(new DateTime(2019, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.LicenceProduct)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.LockedAgainstAccountNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<SoftwareLicencesIpaddressBlock>(entity =>
        {
            entity.HasKey(e => new { e.LicenceId, e.Ipaddress });

            entity.ToTable("SoftwareLicences_IPAddressBlocks");

            entity.Property(e => e.LicenceId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("IPAddress");
            entity.Property(e => e.BlockTimeUtc)
                .HasColumnType("datetime")
                .HasColumnName("BlockTimeUTC");
        });

        modelBuilder.Entity<SystemLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SystemLog");

            entity.HasIndex(e => e.LogTimeUtc, "IX_SystemLog");

            entity.Property(e => e.LogDetail).HasDefaultValue("");
            entity.Property(e => e.LogTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.LogType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LogUserId)
                .HasMaxLength(30)
                .HasDefaultValue("");
        });

        modelBuilder.Entity<TradeBoardClosedTrade>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.UserAccountNumber, e.Ticket });

            entity.ToTable("TradeBoard_ClosedTrades");

            entity.HasIndex(e => e.TradeBoardClosedTradeId, "IX_TradeBoard_ClosedTrades");

            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UserAccountNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BrokerCloseTime).HasColumnType("datetime");
            entity.Property(e => e.BrokerOpenTime).HasColumnType("datetime");
            entity.Property(e => e.ClosePrice).HasColumnType("decimal(14, 6)");
            entity.Property(e => e.FinalCommission).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FinalProfit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FinalProfitPips).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FinalSwap).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.FinalVolume).HasColumnType("decimal(14, 6)");
            entity.Property(e => e.IsOrphan).HasDefaultValue((short)1);
            entity.Property(e => e.OpenPrice).HasColumnType("decimal(14, 6)");
            entity.Property(e => e.OriginalVolume).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Sl)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("SL");
            entity.Property(e => e.Symbol)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SystemCloseTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.SystemOpenTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.Tp)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("TP");
            entity.Property(e => e.TradeBoardClosedTradeId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TradeBoardOpenTrade>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.UserAccountNumber, e.Ticket });

            entity.ToTable("TradeBoard_OpenTrades");

            entity.HasIndex(e => e.TradeBoardOpenTradeId, "IX_TradeBoard_OpenTrades");

            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UserAccountNumber)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BrokerOpenTime).HasColumnType("datetime");
            entity.Property(e => e.CurrentVolume).HasColumnType("decimal(14, 6)");
            entity.Property(e => e.EquityAtOpen).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LatestCommission).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LatestProfit).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LatestProfitPips).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LatestSwap).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.LatestUpdateTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.OpenPrice).HasColumnType("decimal(14, 6)");
            entity.Property(e => e.OriginalVolume).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Sl)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("SL");
            entity.Property(e => e.Symbol)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SystemOpenTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.Tp)
                .HasColumnType("decimal(14, 6)")
                .HasColumnName("TP");
            entity.Property(e => e.TradeBoardOpenTradeId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<TradingDrill>(entity =>
        {
            entity.HasKey(e => e.DrillCounter);

            entity.Property(e => e.AccountId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CertificatePdfstatus).HasColumnName("CertificatePDFStatus");
            entity.Property(e => e.CreationTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.DrillType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.FmestatusCode).HasColumnName("FMEStatusCode");
            entity.Property(e => e.PdfstartTime)
                .HasDefaultValue(new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime")
                .HasColumnName("PDFStartTime");
            entity.Property(e => e.TerminationTimeUtc)
                .HasDefaultValue(new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified))
                .HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(30);
        });

        modelBuilder.Entity<TradingDrillDefinition>(entity =>
        {
            entity.HasKey(e => e.DrillType);

            entity.Property(e => e.DrillType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.AccountFlags).HasDefaultValue(2048);
            entity.Property(e => e.AllowRepeats).HasDefaultValue(1);
            entity.Property(e => e.AvailableSymbols)
                .HasMaxLength(100)
                .HasDefaultValue("");
            entity.Property(e => e.ContingentOnDrill)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("");
            entity.Property(e => e.DeletionMinutes).HasDefaultValue(43200);
            entity.Property(e => e.DepositCurrency)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasDefaultValue("USD");
            entity.Property(e => e.DrillCaption)
                .HasMaxLength(30)
                .HasDefaultValue("");
            entity.Property(e => e.FixedLotSize).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.LossPercentShutdown).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.MaxSlpips).HasColumnName("MaxSLPips");
            entity.Property(e => e.MinSlpips).HasColumnName("MinSLPips");
            entity.Property(e => e.MinTradeRrrpercent).HasColumnName("MinTradeRRRPercent");
            entity.Property(e => e.StartingFunds).HasDefaultValue(10000);
            entity.Property(e => e.SymbolGroup)
                .HasMaxLength(20)
                .HasDefaultValue("Standard");
            entity.Property(e => e.TimeLimitMinutes).HasDefaultValue(1440);
            entity.Property(e => e.WaitMinutesBeforeRetry).HasDefaultValue(30);
        });

        modelBuilder.Entity<TradingWheelsUsage>(entity =>
        {
            entity.HasKey(e => new { e.UsageTimeUtc, e.LicenceCode });

            entity.ToTable("TradingWheelsUsage");

            entity.Property(e => e.UsageTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.LicenceCode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.ComputerId)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.DemoAccount)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DemoServer)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("IPAddress");
            entity.Property(e => e.LiveAccount)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.LiveServer)
                .HasMaxLength(40)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Universe>(entity =>
        {
            entity.Property(e => e.UniverseId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.DefaultLanguage)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasDefaultValue("en");
            entity.Property(e => e.DefaultServerDstmode).HasColumnName("DefaultServerDSTMode");
            entity.Property(e => e.DefaultServerGmtoffset).HasColumnName("DefaultServerGMTOffset");
            entity.Property(e => e.UniverseName)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UsageTracking>(entity =>
        {
            entity.HasKey(e => new { e.UsageKey, e.Ipaddress, e.ComputerKey });

            entity.ToTable("UsageTracking");

            entity.Property(e => e.UsageKey)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("IPAddress");
            entity.Property(e => e.ComputerKey)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.FirstHitUtc).HasColumnType("datetime");
            entity.Property(e => e.MostRecentHitUtc).HasColumnType("datetime");
        });

        modelBuilder.Entity<UsageTrackingAccount>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UsageTracking_Accounts");

            entity.HasIndex(e => new { e.AccountNumber, e.BrokerServer, e.ComputerId }, "IX_UsageTrackingAccounts_FinderIndex");

            entity.HasIndex(e => new { e.ComputerId, e.PlatformId, e.BrokerServer }, "IX_UsageTrackingAccounts_Lookup");

            entity.Property(e => e.BrokerServer)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ComputerId)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.HitTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.Ipaddress)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("IPAddress");
            entity.Property(e => e.PlatformId)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasDefaultValue("MT4");
            entity.Property(e => e.UsageKey)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UsageTrackingCache>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UsageTracking_Cache");

            entity.HasIndex(e => new { e.HitTimeUtc, e.BrokerServer, e.PlatformId, e.BrokerId }, "IX_UsageTrackingCache");

            entity.Property(e => e.BrokerId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.BrokerServer)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ComputerId)
                .HasMaxLength(40)
                .IsUnicode(false);
            entity.Property(e => e.HitTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.PlatformId)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UsageKey)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserAccessRestriction>(entity =>
        {
            entity.HasKey(e => new { e.AccessToUserId, e.AccessByUserId });

            entity.Property(e => e.AccessToUserId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.AccessByUserId)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserCommentTag>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => e.UserId, "IX_UserCommentTags");

            entity.Property(e => e.MatchAgainst)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.TagCaption)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserIdAllocator>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UserIdAllocator");

            entity.Property(e => e.UserIdAllocator1).HasColumnName("UserIdAllocator");
        });

        modelBuilder.Entity<UserPosition>(entity =>
        {
            entity.HasNoKey();

            entity.HasIndex(e => new { e.UserId, e.SymbolName }, "PK_UserPositions")
                .IsUnique()
                .IsClustered();

            entity.HasIndex(e => new { e.SymbolName, e.PositionTimestampUtc }, "ix_UserPositions_Timestamp");

            entity.Property(e => e.NetLots).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.PositionTimestampUtc).HasColumnType("datetime");
            entity.Property(e => e.SentimentSubUniverse)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SentimentUniverse)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SymbolName)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserPositionSnapshot>(entity =>
        {
            entity.HasKey(e => new { e.SnapshotTimeUtc, e.SymbolName })
                .IsClustered();

            entity.Property(e => e.SentimentUniverse)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SnapshotTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.SymbolName)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserPositionSnapshotsExternal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UserPositionSnapshotsExternal");

            entity.HasIndex(e => new { e.SnapshotTimeUtc, e.SymbolName }, "PK_UserPositionSnapshotsExternal")
                .IsUnique()
                .IsClustered();

            entity.Property(e => e.SentimentUniverse)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SnapshotTimeUtc).HasColumnType("datetime");
            entity.Property(e => e.SymbolName)
                .HasMaxLength(10)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserSecretModel>(entity =>
        {
            entity.HasKey(e => e.UserId);

            entity.Property(e => e.UserId).HasMaxLength(30);
            entity.Property(e => e.UserCounter).ValueGeneratedOnAdd();
            entity.Property(e => e.UserSecret)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("UserSecret");
        });

        modelBuilder.Entity<VwBloomberg>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("vwBloomberg");

            entity.Property(e => e.NewsItemId).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<WhiteLabelUserMapping>(entity =>
        {
            entity.HasKey(e => new { e.UniverseId, e.UserId });

            entity.Property(e => e.UniverseId)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.UserId)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MappedUsername)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);


    public readonly struct BrokerModel
    {
        public required Guid BrokerId { get; init; }
        public required string CompanyName { get; init; }
        public required string PageName { get; init; }
        public required CurrentDetailsStatus CurrentDetailsStatus { get; init; }
        public bool Published { get; init; }
        public required BrokerDirectoryDetail? BrokerDirectoryDetail { get; init; }
        public int SponsorshipLevel { get; init; }
        public BrokerGeoMode GeoMode { get; init; }
        public string? GeoCountries { get; init; }

        public int Ranking => SponsorshipLevel switch
        {
            >= 100 => 100,
            <= 0 => 0,
            _ => SponsorshipLevel * Random.Shared.Next(100) / 100
        };

        public ICollection<BrokerArticle> Articles { get; init; }
    }

    public readonly struct BrokerModelLimited
    {
        public required string PageName { get; init; }
        public int SponsorshipLevel { get; init; }
        public int Ranking => SponsorshipLevel switch
        {
            >= 100 => 100,
            <= 0 => 0,
            _ => SponsorshipLevel * Random.Shared.Next(100) / 100
        };
    }

    public readonly struct BrokerArticle
    {
        public required Guid ArticleId { get; init; }
        public required string ArticlePageTitle { get; init; }
        public DateTime PublicationDate { get; init; }
        public DateTime StartDate { get; init; }
        public DateTime EndDate { get; init; }
        public required ArticleType Type { get; init; }
        public required string Title { get; init; }
        public string? Summary { get; init; }
        public required string Content { get; init; }
        public string? Disclaimer { get; init; }
        public string? BrokerLink { get; init; }
        public string? LinkCaption { get; init; }
        public string? CanonicalPage { get; init; }
        public BrokerGeoMode GeoMode { get; init; }
        public string? GeoCountries { get; init; }
        public BrokerModel Broker { get; init; }
    }

    public readonly struct BrokerArticleLimited
    {
        public required Guid ArticleId { get; init; }
        public required string ArticlePageTitle { get; init; }
        public DateTime PublicationDate { get; init; }
        public required ArticleType Type { get; init; }
        public required string Title { get; init; }
        public string? Summary { get; init; }
        public BrokerModelLimited Broker { get; init; }
    }

    public enum BrokerGeoMode
    {
        None,
        OnlyCountries,
        ExceptCountries
    }

    public enum ArticleStatus
    {
        Draft,
        Approval,
        Published
    }

    public enum ArticleType
    {
        News,
        Offer,
        Competition,
        Blog
    }

    public enum CurrentDetailsStatus
    {
        Archived = -1,
        Draft = 0,
        Approval = 1,
        Published = 2
    }
}


