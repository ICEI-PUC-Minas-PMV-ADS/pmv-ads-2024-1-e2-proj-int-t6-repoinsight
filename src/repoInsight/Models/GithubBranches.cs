using System;
using System.Collections.Generic;

using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace repoInsight.Models;

public class GithubBranches
{
    public partial class Welcome
    {
        [JsonProperty("type")]
        public EventsType Type { get; set; }

        [JsonProperty("items")]
        public WelcomeItems Items { get; set; }
    }

    public partial class WelcomeItems
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public PurpleProperties Properties { get; set; }

        [JsonProperty("required")]
        public string[] ItemsRequired { get; set; }
    }

    public partial class PurpleProperties
    {
        [JsonProperty("name")]
        public PurpleName Name { get; set; }

        [JsonProperty("commit")]
        public Commit Commit { get; set; }

        [JsonProperty("protected")]
        public PurpleName Protected { get; set; }

        [JsonProperty("protection")]
        public Protection Protection { get; set; }

        [JsonProperty("protection_url")]
        public ProtectionUrlClass ProtectionUrl { get; set; }
    }

    public partial class Commit
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public CommitProperties Properties { get; set; }

        [JsonProperty("required")]
        public string[] CommitRequired { get; set; }
    }

    public partial class CommitProperties
    {
        [JsonProperty("sha")]
        public PurpleName Sha { get; set; }

        [JsonProperty("url")]
        public ProtectionUrlClass Url { get; set; }
    }

    public partial class PurpleName
    {
        [JsonProperty("type")]
        public ProtectedType Type { get; set; }
    }

    public partial class ProtectionUrlClass
    {
        [JsonProperty("type")]
        public ProtectedType Type { get; set; }

        [JsonProperty("format")]
        public Format Format { get; set; }
    }

    public partial class Protection
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public ProtectionProperties Properties { get; set; }
    }

    public partial class ProtectionProperties
    {
        [JsonProperty("url")]
        public PurpleName Url { get; set; }

        [JsonProperty("enabled")]
        public PurpleName Enabled { get; set; }

        [JsonProperty("required_status_checks")]
        public RequiredStatusChecks RequiredStatusChecks { get; set; }

        [JsonProperty("enforce_admins")]
        public EnforceAdmins EnforceAdmins { get; set; }

        [JsonProperty("required_pull_request_reviews")]
        public RequiredPullRequestReviews RequiredPullRequestReviews { get; set; }

        [JsonProperty("restrictions")]
        public Restrictions Restrictions { get; set; }

        [JsonProperty("required_linear_history")]
        public AllowDeletions RequiredLinearHistory { get; set; }

        [JsonProperty("allow_force_pushes")]
        public AllowDeletions AllowForcePushes { get; set; }

        [JsonProperty("allow_deletions")]
        public AllowDeletions AllowDeletions { get; set; }

        [JsonProperty("block_creations")]
        public AllowDeletions BlockCreations { get; set; }

        [JsonProperty("required_conversation_resolution")]
        public AllowDeletions RequiredConversationResolution { get; set; }

        [JsonProperty("name")]
        public NameClass Name { get; set; }

        [JsonProperty("protection_url")]
        public NameClass ProtectionUrl { get; set; }

        [JsonProperty("required_signatures")]
        public RequiredSignatures RequiredSignatures { get; set; }

        [JsonProperty("lock_branch")]
        public AllowForkSyncing LockBranch { get; set; }

        [JsonProperty("allow_fork_syncing")]
        public AllowForkSyncing AllowForkSyncing { get; set; }
    }

    public partial class AllowDeletions
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public AllowDeletionsProperties Properties { get; set; }
    }

    public partial class AllowDeletionsProperties
    {
        [JsonProperty("enabled")]
        public PurpleName Enabled { get; set; }
    }

    public partial class AllowForkSyncing
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("properties")]
        public AllowForkSyncingProperties Properties { get; set; }
    }

    public partial class AllowForkSyncingProperties
    {
        [JsonProperty("enabled")]
        public PurpleEnabled Enabled { get; set; }
    }

    public partial class PurpleEnabled
    {
        [JsonProperty("default")]
        public bool Default { get; set; }

        [JsonProperty("type")]
        public ProtectedType Type { get; set; }
    }

    public partial class EnforceAdmins
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public EnforceAdminsProperties Properties { get; set; }

        [JsonProperty("required")]
        public string[] EnforceAdminsRequired { get; set; }
    }

    public partial class EnforceAdminsProperties
    {
        [JsonProperty("url")]
        public ExternalUrlClass Url { get; set; }

        [JsonProperty("enabled")]
        public DismissStaleReviewsClass Enabled { get; set; }
    }

    public partial class DismissStaleReviewsClass
    {
        [JsonProperty("type")]
        public ProtectedType Type { get; set; }

        [JsonProperty("examples")]
        public bool[] Examples { get; set; }
    }

    public partial class ExternalUrlClass
    {
        [JsonProperty("type")]
        public ProtectedType Type { get; set; }

        [JsonProperty("format")]
        public Format Format { get; set; }

        [JsonProperty("examples")]
        public ExampleElement[] Examples { get; set; }
    }

    public partial class NameClass
    {
        [JsonProperty("type")]
        public ProtectedType Type { get; set; }

        [JsonProperty("examples")]
        public string[] Examples { get; set; }
    }

    public partial class RequiredPullRequestReviews
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public RequiredPullRequestReviewsProperties Properties { get; set; }

        [JsonProperty("required")]
        public string[] RequiredPullRequestReviewsRequired { get; set; }
    }

    public partial class RequiredPullRequestReviewsProperties
    {
        [JsonProperty("url")]
        public CreatedAtClass Url { get; set; }

        [JsonProperty("dismissal_restrictions")]
        public DismissalRestrictions DismissalRestrictions { get; set; }

        [JsonProperty("bypass_pull_request_allowances")]
        public BypassPullRequestAllowances BypassPullRequestAllowances { get; set; }

        [JsonProperty("dismiss_stale_reviews")]
        public DismissStaleReviewsClass DismissStaleReviews { get; set; }

        [JsonProperty("require_code_owner_reviews")]
        public DismissStaleReviewsClass RequireCodeOwnerReviews { get; set; }

        [JsonProperty("required_approving_review_count")]
        public RequiredApprovingReviewCount RequiredApprovingReviewCount { get; set; }

        [JsonProperty("require_last_push_approval")]
        public RequireLastPushApproval RequireLastPushApproval { get; set; }
    }

    public partial class BypassPullRequestAllowances
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("properties")]
        public BypassPullRequestAllowancesProperties Properties { get; set; }
    }

    public partial class BypassPullRequestAllowancesProperties
    {
        [JsonProperty("users")]
        public PurpleUsers Users { get; set; }

        [JsonProperty("teams")]
        public PurpleTeams Teams { get; set; }

        [JsonProperty("apps")]
        public PurpleApps Apps { get; set; }
    }

    public partial class PurpleApps
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public EventsType Type { get; set; }

        [JsonProperty("items")]
        public PurpleItems Items { get; set; }
    }

    public partial class PurpleItems
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string[] Type { get; set; }

        [JsonProperty("properties")]
        public FluffyProperties Properties { get; set; }

        [JsonProperty("required")]
        public string[] ItemsRequired { get; set; }
    }

    public partial class FluffyProperties
    {
        [JsonProperty("id")]
        public InstallationsCountClass Id { get; set; }

        [JsonProperty("slug")]
        public Events Slug { get; set; }

        [JsonProperty("node_id")]
        public NameClass NodeId { get; set; }

        [JsonProperty("owner")]
        public PurpleOwner Owner { get; set; }

        [JsonProperty("name")]
        public Events Name { get; set; }

        [JsonProperty("description")]
        public WebhookSecretClass Description { get; set; }

        [JsonProperty("external_url")]
        public ExternalUrlClass ExternalUrl { get; set; }

        [JsonProperty("html_url")]
        public ExternalUrlClass HtmlUrl { get; set; }

        [JsonProperty("created_at")]
        public CreatedAtClass CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public ExternalUrlClass UpdatedAt { get; set; }

        [JsonProperty("permissions")]
        public PurplePermissions Permissions { get; set; }

        [JsonProperty("events")]
        public Events Events { get; set; }

        [JsonProperty("installations_count")]
        public InstallationsCountClass InstallationsCount { get; set; }

        [JsonProperty("client_id")]
        public NameClass ClientId { get; set; }

        [JsonProperty("client_secret")]
        public NameClass ClientSecret { get; set; }

        [JsonProperty("webhook_secret")]
        public WebhookSecretClass WebhookSecret { get; set; }

        [JsonProperty("pem")]
        public NameClass Pem { get; set; }
    }

    public partial class CreatedAtClass
    {
        [JsonProperty("type")]
        public ProtectedType Type { get; set; }

        [JsonProperty("format")]
        public Format Format { get; set; }

        [JsonProperty("examples")]
        public ExampleElement[] Examples { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }
    }

    public partial class WebhookSecretClass
    {
        [JsonProperty("type")]
        public TypeElement[] Type { get; set; }

        [JsonProperty("examples")]
        public string[] Examples { get; set; }
    }

    public partial class Events
    {
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("type")]
        public EventsType Type { get; set; }

        [JsonProperty("items", NullValueHandling = NullValueHandling.Ignore)]
        public PurpleName Items { get; set; }

        [JsonProperty("examples")]
        public string[] Examples { get; set; }

        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public Format? Format { get; set; }
    }

    public partial class InstallationsCountClass
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public ProtectedType Type { get; set; }

        [JsonProperty("examples")]
        public long[] Examples { get; set; }
    }

    public partial class PurpleOwner
    {
        [JsonProperty("anyOf")]
        public ItemsElement[] AnyOf { get; set; }
    }

    public partial class ItemsElement
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public TentacledProperties Properties { get; set; }

        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public string[] ItemsRequired { get; set; }
    }

    public partial class TentacledProperties
    {
        [JsonProperty("name")]
        public AppId Name { get; set; }

        [JsonProperty("email")]
        public AppId Email { get; set; }

        [JsonProperty("login")]
        public NameClass Login { get; set; }

        [JsonProperty("id")]
        public PurpleId Id { get; set; }

        [JsonProperty("node_id")]
        public NameClass NodeId { get; set; }

        [JsonProperty("avatar_url")]
        public ExternalUrlClass AvatarUrl { get; set; }

        [JsonProperty("gravatar_id")]
        public WebhookSecretClass GravatarId { get; set; }

        [JsonProperty("url")]
        public CreatedAtClass Url { get; set; }

        [JsonProperty("html_url")]
        public ExternalUrlClass HtmlUrl { get; set; }

        [JsonProperty("followers_url")]
        public ExternalUrlClass FollowersUrl { get; set; }

        [JsonProperty("following_url")]
        public NameClass FollowingUrl { get; set; }

        [JsonProperty("gists_url")]
        public NameClass GistsUrl { get; set; }

        [JsonProperty("starred_url")]
        public NameClass StarredUrl { get; set; }

        [JsonProperty("subscriptions_url")]
        public CreatedAtClass SubscriptionsUrl { get; set; }

        [JsonProperty("organizations_url")]
        public ExternalUrlClass OrganizationsUrl { get; set; }

        [JsonProperty("repos_url")]
        public ExternalUrlClass ReposUrl { get; set; }

        [JsonProperty("events_url")]
        public NameClass EventsUrl { get; set; }

        [JsonProperty("received_events_url")]
        public ExternalUrlClass ReceivedEventsUrl { get; set; }

        [JsonProperty("type")]
        public NameClass Type { get; set; }

        [JsonProperty("site_admin")]
        public PurpleName SiteAdmin { get; set; }

        [JsonProperty("starred_at")]
        public NameClass StarredAt { get; set; }
    }

    public partial class AppId
    {
        [JsonProperty("type")]
        public TypeElement[] Type { get; set; }
    }

    public partial class PurpleId
    {
        [JsonProperty("type")]
        public ProtectedType Type { get; set; }

        [JsonProperty("examples")]
        public long[] Examples { get; set; }
    }

    public partial class PurplePermissions
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public StickyProperties Properties { get; set; }

        [JsonProperty("additionalProperties")]
        public PurpleName AdditionalProperties { get; set; }

        [JsonProperty("example")]
        public ExampleClass Example { get; set; }
    }

    public partial class ExampleClass
    {
        [JsonProperty("issues")]
        public string Issues { get; set; }

        [JsonProperty("deployments")]
        public string Deployments { get; set; }
    }

    public partial class StickyProperties
    {
        [JsonProperty("issues")]
        public PurpleName Issues { get; set; }

        [JsonProperty("checks")]
        public PurpleName Checks { get; set; }

        [JsonProperty("metadata")]
        public PurpleName Metadata { get; set; }

        [JsonProperty("contents")]
        public PurpleName Contents { get; set; }

        [JsonProperty("deployments")]
        public PurpleName Deployments { get; set; }
    }

    public partial class PurpleTeams
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public EventsType Type { get; set; }

        [JsonProperty("items")]
        public FluffyItems Items { get; set; }
    }

    public partial class FluffyItems
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public IndigoProperties Properties { get; set; }

        [JsonProperty("required")]
        public string[] ItemsRequired { get; set; }
    }

    public partial class IndigoProperties
    {
        [JsonProperty("id")]
        public PurpleName Id { get; set; }

        [JsonProperty("node_id")]
        public PurpleName NodeId { get; set; }

        [JsonProperty("name")]
        public PurpleName Name { get; set; }

        [JsonProperty("slug")]
        public PurpleName Slug { get; set; }

        [JsonProperty("description")]
        public AppId Description { get; set; }

        [JsonProperty("privacy")]
        public PurpleName Privacy { get; set; }

        [JsonProperty("notification_setting")]
        public PurpleName NotificationSetting { get; set; }

        [JsonProperty("permission")]
        public PurpleName Permission { get; set; }

        [JsonProperty("permissions")]
        public FluffyPermissions Permissions { get; set; }

        [JsonProperty("url")]
        public ProtectionUrlClass Url { get; set; }

        [JsonProperty("html_url")]
        public ExternalUrlClass HtmlUrl { get; set; }

        [JsonProperty("members_url")]
        public PurpleName MembersUrl { get; set; }

        [JsonProperty("repositories_url")]
        public ProtectionUrlClass RepositoriesUrl { get; set; }

        [JsonProperty("parent")]
        public Parent Parent { get; set; }
    }

    public partial class Parent
    {
        [JsonProperty("anyOf")]
        public AnyOf[] AnyOf { get; set; }
    }

    public partial class AnyOf
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public IndecentProperties Properties { get; set; }

        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public string[] AnyOfRequired { get; set; }
    }

    public partial class IndecentProperties
    {
        [JsonProperty("id")]
        public InstallationsCountClass Id { get; set; }

        [JsonProperty("node_id")]
        public NameClass NodeId { get; set; }

        [JsonProperty("url")]
        public CreatedAtClass Url { get; set; }

        [JsonProperty("members_url")]
        public NameClass MembersUrl { get; set; }

        [JsonProperty("name")]
        public Events Name { get; set; }

        [JsonProperty("description")]
        public PurpleDescription Description { get; set; }

        [JsonProperty("permission")]
        public Events Permission { get; set; }

        [JsonProperty("privacy")]
        public Events Privacy { get; set; }

        [JsonProperty("notification_setting")]
        public Events NotificationSetting { get; set; }

        [JsonProperty("html_url")]
        public CreatedAtClass HtmlUrl { get; set; }

        [JsonProperty("repositories_url")]
        public ExternalUrlClass RepositoriesUrl { get; set; }

        [JsonProperty("slug")]
        public NameClass Slug { get; set; }

        [JsonProperty("ldap_dn")]
        public Events LdapDn { get; set; }
    }

    public partial class PurpleDescription
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public TypeElement[] Type { get; set; }

        [JsonProperty("examples")]
        public string[] Examples { get; set; }
    }

    public partial class FluffyPermissions
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public HilariousProperties Properties { get; set; }

        [JsonProperty("required")]
        public string[] PermissionsRequired { get; set; }
    }

    public partial class HilariousProperties
    {
        [JsonProperty("pull")]
        public PurpleName Pull { get; set; }

        [JsonProperty("triage")]
        public PurpleName Triage { get; set; }

        [JsonProperty("push")]
        public PurpleName Push { get; set; }

        [JsonProperty("maintain")]
        public PurpleName Maintain { get; set; }

        [JsonProperty("admin")]
        public PurpleName Admin { get; set; }
    }

    public partial class PurpleUsers
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public EventsType Type { get; set; }

        [JsonProperty("items")]
        public ItemsElement Items { get; set; }
    }

    public partial class DismissalRestrictions
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public DismissalRestrictionsProperties Properties { get; set; }
    }

    public partial class DismissalRestrictionsProperties
    {
        [JsonProperty("users")]
        public PurpleUsers Users { get; set; }

        [JsonProperty("teams")]
        public PurpleTeams Teams { get; set; }

        [JsonProperty("apps")]
        public PurpleApps Apps { get; set; }

        [JsonProperty("url")]
        public NameClass Url { get; set; }

        [JsonProperty("users_url")]
        public NameClass UsersUrl { get; set; }

        [JsonProperty("teams_url")]
        public NameClass TeamsUrl { get; set; }
    }

    public partial class RequireLastPushApproval
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public ProtectedType Type { get; set; }

        [JsonProperty("default")]
        public bool Default { get; set; }

        [JsonProperty("examples")]
        public bool[] Examples { get; set; }
    }

    public partial class RequiredApprovingReviewCount
    {
        [JsonProperty("type")]
        public ProtectedType Type { get; set; }

        [JsonProperty("minimum")]
        public long Minimum { get; set; }

        [JsonProperty("maximum")]
        public long Maximum { get; set; }

        [JsonProperty("examples")]
        public long[] Examples { get; set; }
    }

    public partial class RequiredSignatures
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public EnforceAdminsProperties Properties { get; set; }

        [JsonProperty("required")]
        public string[] RequiredSignaturesRequired { get; set; }
    }

    public partial class RequiredStatusChecks
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public RequiredStatusChecksProperties Properties { get; set; }

        [JsonProperty("required")]
        public string[] RequiredStatusChecksRequired { get; set; }
    }

    public partial class RequiredStatusChecksProperties
    {
        [JsonProperty("url")]
        public PurpleName Url { get; set; }

        [JsonProperty("enforcement_level")]
        public PurpleName EnforcementLevel { get; set; }

        [JsonProperty("contexts")]
        public Contexts Contexts { get; set; }

        [JsonProperty("checks")]
        public Checks Checks { get; set; }

        [JsonProperty("contexts_url")]
        public PurpleName ContextsUrl { get; set; }

        [JsonProperty("strict")]
        public PurpleName Strict { get; set; }
    }

    public partial class Checks
    {
        [JsonProperty("type")]
        public EventsType Type { get; set; }

        [JsonProperty("items")]
        public ChecksItems Items { get; set; }
    }

    public partial class ChecksItems
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public AmbitiousProperties Properties { get; set; }

        [JsonProperty("required")]
        public string[] ItemsRequired { get; set; }
    }

    public partial class AmbitiousProperties
    {
        [JsonProperty("context")]
        public PurpleName Context { get; set; }

        [JsonProperty("app_id")]
        public AppId AppId { get; set; }
    }

    public partial class Contexts
    {
        [JsonProperty("type")]
        public EventsType Type { get; set; }

        [JsonProperty("items")]
        public PurpleName Items { get; set; }
    }

    public partial class Restrictions
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public RestrictionsProperties Properties { get; set; }

        [JsonProperty("required")]
        public string[] RestrictionsRequired { get; set; }
    }

    public partial class RestrictionsProperties
    {
        [JsonProperty("url")]
        public ProtectionUrlClass Url { get; set; }

        [JsonProperty("users_url")]
        public ProtectionUrlClass UsersUrl { get; set; }

        [JsonProperty("teams_url")]
        public ProtectionUrlClass TeamsUrl { get; set; }

        [JsonProperty("apps_url")]
        public ProtectionUrlClass AppsUrl { get; set; }

        [JsonProperty("users")]
        public FluffyUsers Users { get; set; }

        [JsonProperty("teams")]
        public FluffyTeams Teams { get; set; }

        [JsonProperty("apps")]
        public FluffyApps Apps { get; set; }
    }

    public partial class FluffyApps
    {
        [JsonProperty("type")]
        public EventsType Type { get; set; }

        [JsonProperty("items")]
        public TentacledItems Items { get; set; }
    }

    public partial class TentacledItems
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public CunningProperties Properties { get; set; }
    }

    public partial class CunningProperties
    {
        [JsonProperty("id")]
        public PurpleName Id { get; set; }

        [JsonProperty("slug")]
        public PurpleName Slug { get; set; }

        [JsonProperty("node_id")]
        public PurpleName NodeId { get; set; }

        [JsonProperty("owner")]
        public FluffyOwner Owner { get; set; }

        [JsonProperty("name")]
        public PurpleName Name { get; set; }

        [JsonProperty("description")]
        public PurpleName Description { get; set; }

        [JsonProperty("external_url")]
        public PurpleName ExternalUrl { get; set; }

        [JsonProperty("html_url")]
        public PurpleName HtmlUrl { get; set; }

        [JsonProperty("created_at")]
        public PurpleName CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public PurpleName UpdatedAt { get; set; }

        [JsonProperty("permissions")]
        public TentacledPermissions Permissions { get; set; }

        [JsonProperty("events")]
        public Contexts Events { get; set; }
    }

    public partial class FluffyOwner
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public OwnerProperties Properties { get; set; }
    }

    public partial class OwnerProperties
    {
        [JsonProperty("login")]
        public PurpleName Login { get; set; }

        [JsonProperty("id")]
        public PurpleName Id { get; set; }

        [JsonProperty("node_id")]
        public PurpleName NodeId { get; set; }

        [JsonProperty("url")]
        public PurpleName Url { get; set; }

        [JsonProperty("repos_url")]
        public PurpleName ReposUrl { get; set; }

        [JsonProperty("events_url")]
        public PurpleName EventsUrl { get; set; }

        [JsonProperty("hooks_url")]
        public PurpleName HooksUrl { get; set; }

        [JsonProperty("issues_url")]
        public PurpleName IssuesUrl { get; set; }

        [JsonProperty("members_url")]
        public PurpleName MembersUrl { get; set; }

        [JsonProperty("public_members_url")]
        public PurpleName PublicMembersUrl { get; set; }

        [JsonProperty("avatar_url")]
        public PurpleName AvatarUrl { get; set; }

        [JsonProperty("description")]
        public PurpleName Description { get; set; }

        [JsonProperty("gravatar_id")]
        public NameClass GravatarId { get; set; }

        [JsonProperty("html_url")]
        public NameClass HtmlUrl { get; set; }

        [JsonProperty("followers_url")]
        public NameClass FollowersUrl { get; set; }

        [JsonProperty("following_url")]
        public NameClass FollowingUrl { get; set; }

        [JsonProperty("gists_url")]
        public NameClass GistsUrl { get; set; }

        [JsonProperty("starred_url")]
        public NameClass StarredUrl { get; set; }

        [JsonProperty("subscriptions_url")]
        public NameClass SubscriptionsUrl { get; set; }

        [JsonProperty("organizations_url")]
        public NameClass OrganizationsUrl { get; set; }

        [JsonProperty("received_events_url")]
        public NameClass ReceivedEventsUrl { get; set; }

        [JsonProperty("type")]
        public NameClass Type { get; set; }

        [JsonProperty("site_admin")]
        public DismissStaleReviewsClass SiteAdmin { get; set; }
    }

    public partial class TentacledPermissions
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public MagentaProperties Properties { get; set; }
    }

    public partial class MagentaProperties
    {
        [JsonProperty("metadata")]
        public PurpleName Metadata { get; set; }

        [JsonProperty("contents")]
        public PurpleName Contents { get; set; }

        [JsonProperty("issues")]
        public PurpleName Issues { get; set; }

        [JsonProperty("single_file")]
        public PurpleName SingleFile { get; set; }
    }

    public partial class FluffyTeams
    {
        [JsonProperty("type")]
        public EventsType Type { get; set; }

        [JsonProperty("items")]
        public StickyItems Items { get; set; }
    }

    public partial class StickyItems
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public FriskyProperties Properties { get; set; }
    }

    public partial class FriskyProperties
    {
        [JsonProperty("id")]
        public PurpleName Id { get; set; }

        [JsonProperty("node_id")]
        public PurpleName NodeId { get; set; }

        [JsonProperty("url")]
        public PurpleName Url { get; set; }

        [JsonProperty("html_url")]
        public PurpleName HtmlUrl { get; set; }

        [JsonProperty("name")]
        public PurpleName Name { get; set; }

        [JsonProperty("slug")]
        public PurpleName Slug { get; set; }

        [JsonProperty("description")]
        public AppId Description { get; set; }

        [JsonProperty("privacy")]
        public PurpleName Privacy { get; set; }

        [JsonProperty("notification_setting")]
        public PurpleName NotificationSetting { get; set; }

        [JsonProperty("permission")]
        public PurpleName Permission { get; set; }

        [JsonProperty("members_url")]
        public PurpleName MembersUrl { get; set; }

        [JsonProperty("repositories_url")]
        public PurpleName RepositoriesUrl { get; set; }

        [JsonProperty("parent")]
        public AppId Parent { get; set; }
    }

    public partial class FluffyUsers
    {
        [JsonProperty("type")]
        public EventsType Type { get; set; }

        [JsonProperty("items")]
        public IndigoItems Items { get; set; }
    }

    public partial class IndigoItems
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("properties")]
        public Dictionary<string, PurpleName> Properties { get; set; }
    }

    public enum ProtectedType { Boolean, Integer, String };

    public enum Format { DateTime, Uri };

    public enum TypeElement { Integer, Null, String };

    public enum EventsType { Array, String };

    public partial struct ExampleElement
    {
        public DateTimeOffset? DateTime;
        public Uri PurpleUri;

        public static implicit operator ExampleElement(DateTimeOffset DateTime) => new ExampleElement { DateTime = DateTime };
        public static implicit operator ExampleElement(Uri PurpleUri) => new ExampleElement { PurpleUri = PurpleUri };
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                ProtectedTypeConverter.Singleton,
                FormatConverter.Singleton,
                ExampleElementConverter.Singleton,
                TypeElementConverter.Singleton,
                EventsTypeConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class ProtectedTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ProtectedType) || t == typeof(ProtectedType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "boolean":
                    return ProtectedType.Boolean;
                case "integer":
                    return ProtectedType.Integer;
                case "string":
                    return ProtectedType.String;
            }
            throw new Exception("Cannot unmarshal type ProtectedType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ProtectedType)untypedValue;
            switch (value)
            {
                case ProtectedType.Boolean:
                    serializer.Serialize(writer, "boolean");
                    return;
                case ProtectedType.Integer:
                    serializer.Serialize(writer, "integer");
                    return;
                case ProtectedType.String:
                    serializer.Serialize(writer, "string");
                    return;
            }
            throw new Exception("Cannot marshal type ProtectedType");
        }

        public static readonly ProtectedTypeConverter Singleton = new ProtectedTypeConverter();
    }

    internal class FormatConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Format) || t == typeof(Format?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "date-time":
                    return Format.DateTime;
                case "uri":
                    return Format.Uri;
            }
            throw new Exception("Cannot unmarshal type Format");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Format)untypedValue;
            switch (value)
            {
                case Format.DateTime:
                    serializer.Serialize(writer, "date-time");
                    return;
                case Format.Uri:
                    serializer.Serialize(writer, "uri");
                    return;
            }
            throw new Exception("Cannot marshal type Format");
        }

        public static readonly FormatConverter Singleton = new FormatConverter();
    }

    internal class ExampleElementConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ExampleElement) || t == typeof(ExampleElement?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            switch (reader.TokenType)
            {
                case JsonToken.String:
                case JsonToken.Date:
                    var stringValue = serializer.Deserialize<string>(reader);
                    DateTimeOffset dt;
                    if (DateTimeOffset.TryParse(stringValue, out dt))
                    {
                        return new ExampleElement { DateTime = dt };
                    }
                    try
                    {
                        var uri = new Uri(stringValue);
                        return new ExampleElement { PurpleUri = uri };
                    }
                    catch (UriFormatException) {}
                    break;
            }
            throw new Exception("Cannot unmarshal type ExampleElement");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (ExampleElement)untypedValue;
            if (value.DateTime != null)
            {
                serializer.Serialize(writer, value.DateTime.Value.ToString("o", System.Globalization.CultureInfo.InvariantCulture));
                return;
            }
            if (value.PurpleUri != null)
            {
                serializer.Serialize(writer, value.PurpleUri.ToString());
                return;
            }
            throw new Exception("Cannot marshal type ExampleElement");
        }

        public static readonly ExampleElementConverter Singleton = new ExampleElementConverter();
    }

    internal class TypeElementConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(TypeElement) || t == typeof(TypeElement?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "integer":
                    return TypeElement.Integer;
                case "null":
                    return TypeElement.Null;
                case "string":
                    return TypeElement.String;
            }
            throw new Exception("Cannot unmarshal type TypeElement");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (TypeElement)untypedValue;
            switch (value)
            {
                case TypeElement.Integer:
                    serializer.Serialize(writer, "integer");
                    return;
                case TypeElement.Null:
                    serializer.Serialize(writer, "null");
                    return;
                case TypeElement.String:
                    serializer.Serialize(writer, "string");
                    return;
            }
            throw new Exception("Cannot marshal type TypeElement");
        }

        public static readonly TypeElementConverter Singleton = new TypeElementConverter();
    }

    internal class EventsTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(EventsType) || t == typeof(EventsType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "array":
                    return EventsType.Array;
                case "string":
                    return EventsType.String;
            }
            throw new Exception("Cannot unmarshal type EventsType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (EventsType)untypedValue;
            switch (value)
            {
                case EventsType.Array:
                    serializer.Serialize(writer, "array");
                    return;
                case EventsType.String:
                    serializer.Serialize(writer, "string");
                    return;
            }
            throw new Exception("Cannot marshal type EventsType");
        }

        public static readonly EventsTypeConverter Singleton = new EventsTypeConverter();
    }
}
