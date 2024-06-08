using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace repoInsight.Models;

public class GithubPulls
{
    public partial class Welcome
    {
        [JsonProperty("type")]
        public string Type { get; set; }

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
        public CommentsType Type { get; set; }

        [JsonProperty("properties")]
        public PurpleProperties Properties { get; set; }

        [JsonProperty("required")]
        public string[] ItemsRequired { get; set; }
    }

    public partial class PurpleProperties
    {
        [JsonProperty("url")]
        public CommentsUrl Url { get; set; }

        [JsonProperty("id")]
        public ForksCountClass Id { get; set; }

        [JsonProperty("node_id")]
        public NodeId NodeId { get; set; }

        [JsonProperty("html_url")]
        public CommentsUrl HtmlUrl { get; set; }

        [JsonProperty("diff_url")]
        public CommentsUrl DiffUrl { get; set; }

        [JsonProperty("patch_url")]
        public CommentsUrl PatchUrl { get; set; }

        [JsonProperty("issue_url")]
        public CommentsUrl IssueUrl { get; set; }

        [JsonProperty("commits_url")]
        public CommentsUrl CommitsUrl { get; set; }

        [JsonProperty("review_comments_url")]
        public CommentsUrl ReviewCommentsUrl { get; set; }

        [JsonProperty("review_comment_url")]
        public NodeId ReviewCommentUrl { get; set; }

        [JsonProperty("comments_url")]
        public CommentsUrl CommentsUrl { get; set; }

        [JsonProperty("statuses_url")]
        public CommentsUrl StatusesUrl { get; set; }

        [JsonProperty("number")]
        public ForksCountClass Number { get; set; }

        [JsonProperty("state")]
        public NodeId State { get; set; }

        [JsonProperty("locked")]
        public Locked Locked { get; set; }

        [JsonProperty("title")]
        public NodeId Title { get; set; }

        [JsonProperty("user")]
        public Assignee User { get; set; }

        [JsonProperty("body")]
        public ActiveLockReason Body { get; set; }

        [JsonProperty("labels")]
        public Labels Labels { get; set; }

        [JsonProperty("milestone")]
        public Milestone Milestone { get; set; }

        [JsonProperty("active_lock_reason")]
        public ActiveLockReason ActiveLockReason { get; set; }

        [JsonProperty("created_at")]
        public CommentsUrl CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public CommentsUrl UpdatedAt { get; set; }

        [JsonProperty("closed_at")]
        public ClosedAt ClosedAt { get; set; }

        [JsonProperty("merged_at")]
        public ClosedAt MergedAt { get; set; }

        [JsonProperty("merge_commit_sha")]
        public ActiveLockReason MergeCommitSha { get; set; }

        [JsonProperty("assignee")]
        public Assignee Assignee { get; set; }

        [JsonProperty("assignees")]
        public Assignees Assignees { get; set; }

        [JsonProperty("requested_reviewers")]
        public Assignees RequestedReviewers { get; set; }

        [JsonProperty("requested_teams")]
        public RequestedTeams RequestedTeams { get; set; }

        [JsonProperty("head")]
        public Base Head { get; set; }

        [JsonProperty("base")]
        public Base Base { get; set; }

        [JsonProperty("_links")]
        public Links Links { get; set; }

        [JsonProperty("author_association")]
        public AuthorAssociation AuthorAssociation { get; set; }

        [JsonProperty("auto_merge")]
        public AutoMerge AutoMerge { get; set; }

        [JsonProperty("draft")]
        public Draft Draft { get; set; }
    }

    public partial class ActiveLockReason
    {
        [JsonProperty("type")]
        public ActiveLockReasonType[] Type { get; set; }

        [JsonProperty("examples")]
        public string[] Examples { get; set; }
    }

    public partial class Assignee
    {
        [JsonProperty("anyOf")]
        public ItemsElement[] AnyOf { get; set; }
    }

    public partial class ItemsElement
    {
        [JsonProperty("type")]
        public CommentsType Type { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public Title? Title { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public DescriptionEnum? Description { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public EnabledByProperties Properties { get; set; }

        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public string[] ItemsRequired { get; set; }
    }

    public partial class EnabledByProperties
    {
        [JsonProperty("name")]
        public Email Name { get; set; }

        [JsonProperty("email")]
        public Email Email { get; set; }

        [JsonProperty("login")]
        public NodeId Login { get; set; }

        [JsonProperty("id")]
        public ForksCountClass Id { get; set; }

        [JsonProperty("node_id")]
        public NodeId NodeId { get; set; }

        [JsonProperty("avatar_url")]
        public CommentsUrl AvatarUrl { get; set; }

        [JsonProperty("gravatar_id")]
        public ActiveLockReason GravatarId { get; set; }

        [JsonProperty("url")]
        public CommentsUrl Url { get; set; }

        [JsonProperty("html_url")]
        public CommentsUrl HtmlUrl { get; set; }

        [JsonProperty("followers_url")]
        public CommentsUrl FollowersUrl { get; set; }

        [JsonProperty("following_url")]
        public NodeId FollowingUrl { get; set; }

        [JsonProperty("gists_url")]
        public NodeId GistsUrl { get; set; }

        [JsonProperty("starred_url")]
        public NodeId StarredUrl { get; set; }

        [JsonProperty("subscriptions_url")]
        public CommentsUrl SubscriptionsUrl { get; set; }

        [JsonProperty("organizations_url")]
        public CommentsUrl OrganizationsUrl { get; set; }

        [JsonProperty("repos_url")]
        public CommentsUrl ReposUrl { get; set; }

        [JsonProperty("events_url")]
        public NodeId EventsUrl { get; set; }

        [JsonProperty("received_events_url")]
        public CommentsUrl ReceivedEventsUrl { get; set; }

        [JsonProperty("type")]
        public NodeId Type { get; set; }

        [JsonProperty("site_admin")]
        public Label SiteAdmin { get; set; }

        [JsonProperty("starred_at")]
        public NodeId StarredAt { get; set; }
    }

    public partial class CommentsUrl
    {
        [JsonProperty("type")]
        public LabelType Type { get; set; }

        [JsonProperty("format")]
        public Format Format { get; set; }

        [JsonProperty("examples")]
        public Example[] Examples { get; set; }
    }

    public partial class Email
    {
        [JsonProperty("type")]
        public ActiveLockReasonType[] Type { get; set; }
    }

    public partial class NodeId
    {
        [JsonProperty("type")]
        public LabelType Type { get; set; }

        [JsonProperty("examples")]
        public string[] Examples { get; set; }
    }

    public partial class ForksCountClass
    {
        [JsonProperty("type")]
        public LabelType Type { get; set; }

        [JsonProperty("examples")]
        public long[] Examples { get; set; }
    }

    public partial class Label
    {
        [JsonProperty("type")]
        public LabelType Type { get; set; }
    }

    public partial class Assignees
    {
        [JsonProperty("type")]
        public string[] Type { get; set; }

        [JsonProperty("items")]
        public ItemsElement Items { get; set; }
    }

    public partial class AuthorAssociation
    {
        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("type")]
        public LabelType Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enum")]
        public string[] Enum { get; set; }

        [JsonProperty("examples")]
        public string[] Examples { get; set; }

        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public string Default { get; set; }
    }

    public partial class AutoMerge
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public CommentsType[] Type { get; set; }

        [JsonProperty("properties")]
        public AutoMergeProperties Properties { get; set; }

        [JsonProperty("required")]
        public string[] AutoMergeRequired { get; set; }
    }

    public partial class AutoMergeProperties
    {
        [JsonProperty("enabled_by")]
        public ItemsElement EnabledBy { get; set; }

        [JsonProperty("merge_method")]
        public MergeMethod MergeMethod { get; set; }

        [JsonProperty("commit_title")]
        public CommitMessage CommitTitle { get; set; }

        [JsonProperty("commit_message")]
        public CommitMessage CommitMessage { get; set; }
    }

    public partial class CommitMessage
    {
        [JsonProperty("type")]
        public LabelType Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }

    public partial class MergeMethod
    {
        [JsonProperty("type")]
        public LabelType Type { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enum")]
        public string[] Enum { get; set; }
    }

    public partial class Base
    {
        [JsonProperty("type")]
        public CommentsType Type { get; set; }

        [JsonProperty("properties")]
        public BaseProperties Properties { get; set; }

        [JsonProperty("required")]
        public string[] BaseRequired { get; set; }
    }

    public partial class BaseProperties
    {
        [JsonProperty("label")]
        public Label Label { get; set; }

        [JsonProperty("ref")]
        public Label Ref { get; set; }

        [JsonProperty("repo")]
        public Repo Repo { get; set; }

        [JsonProperty("sha")]
        public Label Sha { get; set; }

        [JsonProperty("user")]
        public Assignee User { get; set; }
    }

    public partial class Repo
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public CommentsType Type { get; set; }

        [JsonProperty("properties")]
        public RepoProperties Properties { get; set; }

        [JsonProperty("required")]
        public string[] RepoRequired { get; set; }
    }

    public partial class RepoProperties
    {
        [JsonProperty("id")]
        public SizeClass Id { get; set; }

        [JsonProperty("node_id")]
        public NodeId NodeId { get; set; }

        [JsonProperty("name")]
        public DefaultBranch Name { get; set; }

        [JsonProperty("full_name")]
        public NodeId FullName { get; set; }

        [JsonProperty("license")]
        public License License { get; set; }

        [JsonProperty("forks")]
        public Label Forks { get; set; }

        [JsonProperty("permissions")]
        public Permissions Permissions { get; set; }

        [JsonProperty("owner")]
        public ItemsElement Owner { get; set; }

        [JsonProperty("private")]
        public Draft Private { get; set; }

        [JsonProperty("html_url")]
        public CommentsUrl HtmlUrl { get; set; }

        [JsonProperty("description")]
        public ActiveLockReason Description { get; set; }

        [JsonProperty("fork")]
        public Label Fork { get; set; }

        [JsonProperty("url")]
        public CommentsUrl Url { get; set; }

        [JsonProperty("archive_url")]
        public NodeId ArchiveUrl { get; set; }

        [JsonProperty("assignees_url")]
        public NodeId AssigneesUrl { get; set; }

        [JsonProperty("blobs_url")]
        public NodeId BlobsUrl { get; set; }

        [JsonProperty("branches_url")]
        public NodeId BranchesUrl { get; set; }

        [JsonProperty("collaborators_url")]
        public NodeId CollaboratorsUrl { get; set; }

        [JsonProperty("comments_url")]
        public NodeId CommentsUrl { get; set; }

        [JsonProperty("commits_url")]
        public NodeId CommitsUrl { get; set; }

        [JsonProperty("compare_url")]
        public NodeId CompareUrl { get; set; }

        [JsonProperty("contents_url")]
        public NodeId ContentsUrl { get; set; }

        [JsonProperty("contributors_url")]
        public CommentsUrl ContributorsUrl { get; set; }

        [JsonProperty("deployments_url")]
        public CommentsUrl DeploymentsUrl { get; set; }

        [JsonProperty("downloads_url")]
        public CommentsUrl DownloadsUrl { get; set; }

        [JsonProperty("events_url")]
        public CommentsUrl EventsUrl { get; set; }

        [JsonProperty("forks_url")]
        public CommentsUrl ForksUrl { get; set; }

        [JsonProperty("git_commits_url")]
        public NodeId GitCommitsUrl { get; set; }

        [JsonProperty("git_refs_url")]
        public NodeId GitRefsUrl { get; set; }

        [JsonProperty("git_tags_url")]
        public NodeId GitTagsUrl { get; set; }

        [JsonProperty("git_url")]
        public NodeId GitUrl { get; set; }

        [JsonProperty("issue_comment_url")]
        public NodeId IssueCommentUrl { get; set; }

        [JsonProperty("issue_events_url")]
        public NodeId IssueEventsUrl { get; set; }

        [JsonProperty("issues_url")]
        public NodeId IssuesUrl { get; set; }

        [JsonProperty("keys_url")]
        public NodeId KeysUrl { get; set; }

        [JsonProperty("labels_url")]
        public NodeId LabelsUrl { get; set; }

        [JsonProperty("languages_url")]
        public CommentsUrl LanguagesUrl { get; set; }

        [JsonProperty("merges_url")]
        public CommentsUrl MergesUrl { get; set; }

        [JsonProperty("milestones_url")]
        public NodeId MilestonesUrl { get; set; }

        [JsonProperty("notifications_url")]
        public NodeId NotificationsUrl { get; set; }

        [JsonProperty("pulls_url")]
        public NodeId PullsUrl { get; set; }

        [JsonProperty("releases_url")]
        public NodeId ReleasesUrl { get; set; }

        [JsonProperty("ssh_url")]
        public NodeId SshUrl { get; set; }

        [JsonProperty("stargazers_url")]
        public CommentsUrl StargazersUrl { get; set; }

        [JsonProperty("statuses_url")]
        public NodeId StatusesUrl { get; set; }

        [JsonProperty("subscribers_url")]
        public CommentsUrl SubscribersUrl { get; set; }

        [JsonProperty("subscription_url")]
        public CommentsUrl SubscriptionUrl { get; set; }

        [JsonProperty("tags_url")]
        public CommentsUrl TagsUrl { get; set; }

        [JsonProperty("teams_url")]
        public CommentsUrl TeamsUrl { get; set; }

        [JsonProperty("trees_url")]
        public NodeId TreesUrl { get; set; }

        [JsonProperty("clone_url")]
        public NodeId CloneUrl { get; set; }

        [JsonProperty("mirror_url")]
        public ClosedAt MirrorUrl { get; set; }

        [JsonProperty("hooks_url")]
        public CommentsUrl HooksUrl { get; set; }

        [JsonProperty("svn_url")]
        public CommentsUrl SvnUrl { get; set; }

        [JsonProperty("homepage")]
        public ClosedAt Homepage { get; set; }

        [JsonProperty("language")]
        public Email Language { get; set; }

        [JsonProperty("forks_count")]
        public ForksCountClass ForksCount { get; set; }

        [JsonProperty("stargazers_count")]
        public ForksCountClass StargazersCount { get; set; }

        [JsonProperty("watchers_count")]
        public ForksCountClass WatchersCount { get; set; }

        [JsonProperty("size")]
        public SizeClass Size { get; set; }

        [JsonProperty("default_branch")]
        public DefaultBranch DefaultBranch { get; set; }

        [JsonProperty("open_issues_count")]
        public ForksCountClass OpenIssuesCount { get; set; }

        [JsonProperty("is_template")]
        public Draft IsTemplate { get; set; }

        [JsonProperty("topics")]
        public Topics Topics { get; set; }

        [JsonProperty("has_issues")]
        public Draft HasIssues { get; set; }

        [JsonProperty("has_projects")]
        public Draft HasProjects { get; set; }

        [JsonProperty("has_wiki")]
        public Draft HasWiki { get; set; }

        [JsonProperty("has_pages")]
        public Label HasPages { get; set; }

        [JsonProperty("has_downloads")]
        public Draft HasDownloads { get; set; }

        [JsonProperty("has_discussions")]
        public Draft HasDiscussions { get; set; }

        [JsonProperty("archived")]
        public Draft Archived { get; set; }

        [JsonProperty("disabled")]
        public CommitMessage Disabled { get; set; }

        [JsonProperty("visibility")]
        public Visibility Visibility { get; set; }

        [JsonProperty("pushed_at")]
        public ClosedAt PushedAt { get; set; }

        [JsonProperty("created_at")]
        public ClosedAt CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public ClosedAt UpdatedAt { get; set; }

        [JsonProperty("allow_rebase_merge")]
        public Draft AllowRebaseMerge { get; set; }

        [JsonProperty("temp_clone_token")]
        public Label TempCloneToken { get; set; }

        [JsonProperty("allow_squash_merge")]
        public Draft AllowSquashMerge { get; set; }

        [JsonProperty("allow_auto_merge")]
        public Draft AllowAutoMerge { get; set; }

        [JsonProperty("delete_branch_on_merge")]
        public Draft DeleteBranchOnMerge { get; set; }

        [JsonProperty("allow_update_branch")]
        public Draft AllowUpdateBranch { get; set; }

        [JsonProperty("use_squash_pr_title_as_default")]
        public Draft UseSquashPrTitleAsDefault { get; set; }

        [JsonProperty("squash_merge_commit_title")]
        public MergeMethod SquashMergeCommitTitle { get; set; }

        [JsonProperty("squash_merge_commit_message")]
        public MergeMethod SquashMergeCommitMessage { get; set; }

        [JsonProperty("merge_commit_title")]
        public MergeMethod MergeCommitTitle { get; set; }

        [JsonProperty("merge_commit_message")]
        public MergeMethod MergeCommitMessage { get; set; }

        [JsonProperty("allow_merge_commit")]
        public Draft AllowMergeCommit { get; set; }

        [JsonProperty("allow_forking")]
        public CommitMessage AllowForking { get; set; }

        [JsonProperty("web_commit_signoff_required")]
        public Draft WebCommitSignoffRequired { get; set; }

        [JsonProperty("open_issues")]
        public Label OpenIssues { get; set; }

        [JsonProperty("watchers")]
        public Label Watchers { get; set; }

        [JsonProperty("master_branch")]
        public Label MasterBranch { get; set; }

        [JsonProperty("starred_at")]
        public NodeId StarredAt { get; set; }

        [JsonProperty("anonymous_access_enabled")]
        public CommitMessage AnonymousAccessEnabled { get; set; }
    }

    public partial class Draft
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("default", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Default { get; set; }

        [JsonProperty("type")]
        public LabelType Type { get; set; }

        [JsonProperty("examples", NullValueHandling = NullValueHandling.Ignore)]
        public bool[] Examples { get; set; }

        [JsonProperty("deprecated", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deprecated { get; set; }
    }

    public partial class ClosedAt
    {
        [JsonProperty("type")]
        public ActiveLockReasonType[] Type { get; set; }

        [JsonProperty("format")]
        public Format Format { get; set; }

        [JsonProperty("examples")]
        public string[] Examples { get; set; }
    }

    public partial class DefaultBranch
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public LabelType Type { get; set; }

        [JsonProperty("examples")]
        public string[] Examples { get; set; }

        [JsonProperty("format", NullValueHandling = NullValueHandling.Ignore)]
        public Format? Format { get; set; }
    }

    public partial class SizeClass
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public LabelType Type { get; set; }

        [JsonProperty("examples")]
        public long[] Examples { get; set; }
    }

    public partial class License
    {
        [JsonProperty("anyOf")]
        public LicenseAnyOf[] AnyOf { get; set; }
    }

    public partial class LicenseAnyOf
    {
        [JsonProperty("type")]
        public CommentsType Type { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public FluffyProperties Properties { get; set; }

        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public string[] AnyOfRequired { get; set; }
    }

    public partial class FluffyProperties
    {
        [JsonProperty("key")]
        public NodeId Key { get; set; }

        [JsonProperty("name")]
        public NodeId Name { get; set; }

        [JsonProperty("url")]
        public ClosedAt Url { get; set; }

        [JsonProperty("spdx_id")]
        public ActiveLockReason SpdxId { get; set; }

        [JsonProperty("node_id")]
        public NodeId NodeId { get; set; }

        [JsonProperty("html_url")]
        public RepositoriesUrlClass HtmlUrl { get; set; }
    }

    public partial class RepositoriesUrlClass
    {
        [JsonProperty("type")]
        public LabelType Type { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }
    }

    public partial class Permissions
    {
        [JsonProperty("type")]
        public CommentsType Type { get; set; }

        [JsonProperty("properties")]
        public PermissionsProperties Properties { get; set; }

        [JsonProperty("required")]
        public string[] PermissionsRequired { get; set; }
    }

    public partial class PermissionsProperties
    {
        [JsonProperty("admin")]
        public Label Admin { get; set; }

        [JsonProperty("pull")]
        public Label Pull { get; set; }

        [JsonProperty("triage")]
        public Label Triage { get; set; }

        [JsonProperty("push")]
        public Label Push { get; set; }

        [JsonProperty("maintain")]
        public Label Maintain { get; set; }
    }

    public partial class Topics
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("items")]
        public Label Items { get; set; }
    }

    public partial class Visibility
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("default")]
        public string Default { get; set; }

        [JsonProperty("type")]
        public LabelType Type { get; set; }
    }

    public partial class Labels
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("items")]
        public LabelsItems Items { get; set; }
    }

    public partial class LabelsItems
    {
        [JsonProperty("type")]
        public CommentsType Type { get; set; }

        [JsonProperty("properties")]
        public TentacledProperties Properties { get; set; }

        [JsonProperty("required")]
        public string[] ItemsRequired { get; set; }
    }

    public partial class TentacledProperties
    {
        [JsonProperty("id")]
        public RepositoriesUrlClass Id { get; set; }

        [JsonProperty("node_id")]
        public Label NodeId { get; set; }

        [JsonProperty("url")]
        public Label Url { get; set; }

        [JsonProperty("name")]
        public Label Name { get; set; }

        [JsonProperty("description")]
        public Label Description { get; set; }

        [JsonProperty("color")]
        public Label Color { get; set; }

        [JsonProperty("default")]
        public Label Default { get; set; }
    }

    public partial class Links
    {
        [JsonProperty("type")]
        public CommentsType Type { get; set; }

        [JsonProperty("properties")]
        public LinksProperties Properties { get; set; }

        [JsonProperty("required")]
        public string[] LinksRequired { get; set; }
    }

    public partial class LinksProperties
    {
        [JsonProperty("comments")]
        public Comments Comments { get; set; }

        [JsonProperty("commits")]
        public Comments Commits { get; set; }

        [JsonProperty("statuses")]
        public Comments Statuses { get; set; }

        [JsonProperty("html")]
        public Comments Html { get; set; }

        [JsonProperty("issue")]
        public Comments Issue { get; set; }

        [JsonProperty("review_comments")]
        public Comments ReviewComments { get; set; }

        [JsonProperty("review_comment")]
        public Comments ReviewComment { get; set; }

        [JsonProperty("self")]
        public Comments Self { get; set; }
    }

    public partial class Comments
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public CommentsType Type { get; set; }

        [JsonProperty("properties")]
        public CommentsProperties Properties { get; set; }

        [JsonProperty("required")]
        public string[] CommentsRequired { get; set; }
    }

    public partial class CommentsProperties
    {
        [JsonProperty("href")]
        public Label Href { get; set; }
    }

    public partial class Locked
    {
        [JsonProperty("type")]
        public LabelType Type { get; set; }

        [JsonProperty("examples")]
        public bool[] Examples { get; set; }
    }

    public partial class Milestone
    {
        [JsonProperty("anyOf")]
        public MilestoneAnyOf[] AnyOf { get; set; }
    }

    public partial class MilestoneAnyOf
    {
        [JsonProperty("type")]
        public CommentsType Type { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }

        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        [JsonProperty("properties", NullValueHandling = NullValueHandling.Ignore)]
        public StickyProperties Properties { get; set; }

        [JsonProperty("required", NullValueHandling = NullValueHandling.Ignore)]
        public string[] AnyOfRequired { get; set; }
    }

    public partial class StickyProperties
    {
        [JsonProperty("url")]
        public CommentsUrl Url { get; set; }

        [JsonProperty("html_url")]
        public CommentsUrl HtmlUrl { get; set; }

        [JsonProperty("labels_url")]
        public CommentsUrl LabelsUrl { get; set; }

        [JsonProperty("id")]
        public ForksCountClass Id { get; set; }

        [JsonProperty("node_id")]
        public NodeId NodeId { get; set; }

        [JsonProperty("number")]
        public SizeClass Number { get; set; }

        [JsonProperty("state")]
        public AuthorAssociation State { get; set; }

        [JsonProperty("title")]
        public DefaultBranch Title { get; set; }

        [JsonProperty("description")]
        public ActiveLockReason Description { get; set; }

        [JsonProperty("creator")]
        public Assignee Creator { get; set; }

        [JsonProperty("open_issues")]
        public ForksCountClass OpenIssues { get; set; }

        [JsonProperty("closed_issues")]
        public ForksCountClass ClosedIssues { get; set; }

        [JsonProperty("created_at")]
        public CommentsUrl CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        public CommentsUrl UpdatedAt { get; set; }

        [JsonProperty("closed_at")]
        public ClosedAt ClosedAt { get; set; }

        [JsonProperty("due_on")]
        public ClosedAt DueOn { get; set; }
    }

    public partial class RequestedTeams
    {
        [JsonProperty("type")]
        public string[] Type { get; set; }

        [JsonProperty("items")]
        public RequestedTeamsItems Items { get; set; }
    }

    public partial class RequestedTeamsItems
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public CommentsType Type { get; set; }

        [JsonProperty("properties")]
        public IndigoProperties Properties { get; set; }

        [JsonProperty("required")]
        public string[] ItemsRequired { get; set; }
    }

    public partial class IndigoProperties
    {
        [JsonProperty("id")]
        public Label Id { get; set; }

        [JsonProperty("node_id")]
        public Label NodeId { get; set; }

        [JsonProperty("name")]
        public Label Name { get; set; }

        [JsonProperty("slug")]
        public Label Slug { get; set; }

        [JsonProperty("description")]
        public Email Description { get; set; }

        [JsonProperty("privacy")]
        public Label Privacy { get; set; }

        [JsonProperty("notification_setting")]
        public Label NotificationSetting { get; set; }

        [JsonProperty("permission")]
        public Label Permission { get; set; }

        [JsonProperty("permissions")]
        public Permissions Permissions { get; set; }

        [JsonProperty("url")]
        public RepositoriesUrlClass Url { get; set; }

        [JsonProperty("html_url")]
        public CommentsUrl HtmlUrl { get; set; }

        [JsonProperty("members_url")]
        public Label MembersUrl { get; set; }

        [JsonProperty("repositories_url")]
        public RepositoriesUrlClass RepositoriesUrl { get; set; }

        [JsonProperty("parent")]
        public Parent Parent { get; set; }
    }

    public partial class Parent
    {
        [JsonProperty("anyOf")]
        public ParentAnyOf[] AnyOf { get; set; }
    }

    public partial class ParentAnyOf
    {
        [JsonProperty("type")]
        public CommentsType Type { get; set; }

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
        public SizeClass Id { get; set; }

        [JsonProperty("node_id")]
        public NodeId NodeId { get; set; }

        [JsonProperty("url")]
        public DefaultBranch Url { get; set; }

        [JsonProperty("members_url")]
        public NodeId MembersUrl { get; set; }

        [JsonProperty("name")]
        public DefaultBranch Name { get; set; }

        [JsonProperty("description")]
        public DescriptionClass Description { get; set; }

        [JsonProperty("permission")]
        public DefaultBranch Permission { get; set; }

        [JsonProperty("privacy")]
        public DefaultBranch Privacy { get; set; }

        [JsonProperty("notification_setting")]
        public DefaultBranch NotificationSetting { get; set; }

        [JsonProperty("html_url")]
        public CommentsUrl HtmlUrl { get; set; }

        [JsonProperty("repositories_url")]
        public CommentsUrl RepositoriesUrl { get; set; }

        [JsonProperty("slug")]
        public NodeId Slug { get; set; }

        [JsonProperty("ldap_dn")]
        public DefaultBranch LdapDn { get; set; }
    }

    public partial class DescriptionClass
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("type")]
        public ActiveLockReasonType[] Type { get; set; }

        [JsonProperty("examples")]
        public string[] Examples { get; set; }
    }

    public enum ActiveLockReasonType { Null, String };

    public enum DescriptionEnum { AGitHubUser };

    public enum Format { DateTime, Uri };

    public enum LabelType { Boolean, Integer, String };

    public enum Title { SimpleUser };

    public enum CommentsType { Null, Object };

    public partial struct Example
    {
        public DateTimeOffset? DateTime;
        public Uri PurpleUri;

        public static implicit operator Example(DateTimeOffset DateTime) => new Example { DateTime = DateTime };
        public static implicit operator Example(Uri PurpleUri) => new Example { PurpleUri = PurpleUri };
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters =
            {
                LabelTypeConverter.Singleton,
                CommentsTypeConverter.Singleton,
                ActiveLockReasonTypeConverter.Singleton,
                DescriptionEnumConverter.Singleton,
                ExampleConverter.Singleton,
                FormatConverter.Singleton,
                TitleConverter.Singleton,
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }

    internal class LabelTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(LabelType) || t == typeof(LabelType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "boolean":
                    return LabelType.Boolean;
                case "integer":
                    return LabelType.Integer;
                case "string":
                    return LabelType.String;
            }
            throw new Exception("Cannot unmarshal type LabelType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (LabelType)untypedValue;
            switch (value)
            {
                case LabelType.Boolean:
                    serializer.Serialize(writer, "boolean");
                    return;
                case LabelType.Integer:
                    serializer.Serialize(writer, "integer");
                    return;
                case LabelType.String:
                    serializer.Serialize(writer, "string");
                    return;
            }
            throw new Exception("Cannot marshal type LabelType");
        }

        public static readonly LabelTypeConverter Singleton = new LabelTypeConverter();
    }

    internal class CommentsTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(CommentsType) || t == typeof(CommentsType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "null":
                    return CommentsType.Null;
                case "object":
                    return CommentsType.Object;
            }
            throw new Exception("Cannot unmarshal type CommentsType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (CommentsType)untypedValue;
            switch (value)
            {
                case CommentsType.Null:
                    serializer.Serialize(writer, "null");
                    return;
                case CommentsType.Object:
                    serializer.Serialize(writer, "object");
                    return;
            }
            throw new Exception("Cannot marshal type CommentsType");
        }

        public static readonly CommentsTypeConverter Singleton = new CommentsTypeConverter();
    }

    internal class ActiveLockReasonTypeConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(ActiveLockReasonType) || t == typeof(ActiveLockReasonType?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            switch (value)
            {
                case "null":
                    return ActiveLockReasonType.Null;
                case "string":
                    return ActiveLockReasonType.String;
            }
            throw new Exception("Cannot unmarshal type ActiveLockReasonType");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (ActiveLockReasonType)untypedValue;
            switch (value)
            {
                case ActiveLockReasonType.Null:
                    serializer.Serialize(writer, "null");
                    return;
                case ActiveLockReasonType.String:
                    serializer.Serialize(writer, "string");
                    return;
            }
            throw new Exception("Cannot marshal type ActiveLockReasonType");
        }

        public static readonly ActiveLockReasonTypeConverter Singleton = new ActiveLockReasonTypeConverter();
    }

    internal class DescriptionEnumConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(DescriptionEnum) || t == typeof(DescriptionEnum?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "A GitHub user.")
            {
                return DescriptionEnum.AGitHubUser;
            }
            throw new Exception("Cannot unmarshal type DescriptionEnum");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (DescriptionEnum)untypedValue;
            if (value == DescriptionEnum.AGitHubUser)
            {
                serializer.Serialize(writer, "A GitHub user.");
                return;
            }
            throw new Exception("Cannot marshal type DescriptionEnum");
        }

        public static readonly DescriptionEnumConverter Singleton = new DescriptionEnumConverter();
    }

    internal class ExampleConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Example) || t == typeof(Example?);

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
                        return new Example { DateTime = dt };
                    }
                    try
                    {
                        var uri = new Uri(stringValue);
                        return new Example { PurpleUri = uri };
                    }
                    catch (UriFormatException) {}
                    break;
            }
            throw new Exception("Cannot unmarshal type Example");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            var value = (Example)untypedValue;
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
            throw new Exception("Cannot marshal type Example");
        }

        public static readonly ExampleConverter Singleton = new ExampleConverter();
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

    internal class TitleConverter : JsonConverter
    {
        public override bool CanConvert(Type t) => t == typeof(Title) || t == typeof(Title?);

        public override object ReadJson(JsonReader reader, Type t, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null) return null;
            var value = serializer.Deserialize<string>(reader);
            if (value == "Simple User")
            {
                return Title.SimpleUser;
            }
            throw new Exception("Cannot unmarshal type Title");
        }

        public override void WriteJson(JsonWriter writer, object untypedValue, JsonSerializer serializer)
        {
            if (untypedValue == null)
            {
                serializer.Serialize(writer, null);
                return;
            }
            var value = (Title)untypedValue;
            if (value == Title.SimpleUser)
            {
                serializer.Serialize(writer, "Simple User");
                return;
            }
            throw new Exception("Cannot marshal type Title");
        }

        public static readonly TitleConverter Singleton = new TitleConverter();
    }
}
