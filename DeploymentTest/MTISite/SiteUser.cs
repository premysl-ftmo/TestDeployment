namespace StriveApi.Database.Models.MTISite;

public partial class SiteUser
{
    public string UserId { get; set; } = null!;

    public string UserPassword { get; set; } = null!;

    public string HomeDirectory { get; set; } = null!;

    public bool EnableFlag { get; set; }

    public bool Writepermission { get; set; }

    public int Idletime { get; set; }

    public int Uploadrate { get; set; }

    public int Downloadrate { get; set; }

    public int MaxLoginNumber { get; set; }

    public int MaxLoginPerIp { get; set; }

    public string? ResultPin { get; set; }

    public string? EmailAddress { get; set; }

    public DateTime SignUpDate { get; set; }

    public byte IsValidated { get; set; }

    public string? UserName { get; set; }

    public byte ListInDirectory { get; set; }

    public byte AllowContact { get; set; }

    public string? Website { get; set; }

    public DateTime? FirstUpload { get; set; }

    public DateTime? MostRecentUpload { get; set; }

    public int TotalUploads { get; set; }

    public string? UserDescription { get; set; }

    public int MessagesSent { get; set; }

    public int MessagesReceived { get; set; }

    public string? SignupIpaddress { get; set; }

    public string? BrokerName { get; set; }

    public string? SystemDescription { get; set; }

    public byte SystemDescriptionPublic { get; set; }

    public string? BespokePageTitle { get; set; }

    public byte HideAccountNumber { get; set; }

    public byte HideAccountName { get; set; }

    public decimal Eaversion { get; set; }

    public string? UserSource { get; set; }

    public byte IncludeInLeaderboard { get; set; }

    public string? TwitterToken { get; set; }

    public string? TwitterSecret { get; set; }

    public string? OldPassword { get; set; }

    public int BrokerTimezoneBaseOffset { get; set; }

    public int BrokerTimezoneDstmode { get; set; }

    public int VerificationFlag { get; set; }

    public string? EmbeddedUrl { get; set; }

    public int EmbeddedUrlPosition { get; set; }

    public string? EmbeddedUrlTabName { get; set; }

    public short HideOrdersUnlessLoggedIn { get; set; }

    public int MaxSignalClients { get; set; }

    public DateTime? LastItmActivityUtc { get; set; }

    public int StatementStyle { get; set; }

    public int ShowSocialNetworkLinks { get; set; }

    public short HasAccessList { get; set; }

    public string? UserUniverse { get; set; } = null!;

    public short? NoMailshots { get; set; }

    public int SlingshotQuota { get; set; }

    public string? PhoneValidationCode { get; set; }

    public string? EmailValidationCode { get; set; }

    public bool IsPhoneValidated { get; set; }

    public bool IsEmailValidated { get; set; }

    public string? PhoneNumber { get; set; }

    public string? PhoneGivenName { get; set; }

    public string? PhoneFamilyName { get; set; }

    public string? PhoneVerificationSession { get; set; }

    public string? PhoneCountry { get; set; }

    public string? LeadBatch { get; set; } = null!;

    public string? LeadCode { get; set; } = null!;

    public DateTime? VerificationStartTimeUtc { get; set; }

    public int TimeAdjustDstmode { get; set; }

    public int TimeAdjustOutsideDst { get; set; }

    public int TimeAdjustInsideDst { get; set; }

    public int MaxUploadedOrders { get; set; }

    public string? VerificationContext { get; set; } = null!;

    public byte LeadDecline { get; set; }

    public string? SignupCountry { get; set; } = null!;

    public string? SubAccountOf { get; set; }
}
