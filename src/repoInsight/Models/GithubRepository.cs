using System;
using System.Collections.Generic;
using Newtonsoft.Json;
namespace repoInsight.Models;

public class GithubRepository
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("node_id")]
    public string NodeId { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("full_name")]
    public string FullName { get; set; }

    [JsonProperty("private")]
    public bool Private { get; set; }

    [JsonProperty("owner")]
    public Owner Owner { get; set; }

    [JsonProperty("html_url")]
    public string HtmlUrl { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("fork")]
    public bool Fork { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("forks_url")]
    public string ForksUrl { get; set; }

    [JsonProperty("keys_url")]
    public string KeysUrl { get; set; }

    [JsonProperty("collaborators_url")]
    public string CollaboratorsUrl { get; set; }

    [JsonProperty("teams_url")]
    public string TeamsUrl { get; set; }

    [JsonProperty("hooks_url")]
    public string HooksUrl { get; set; }

    [JsonProperty("issue_events_url")]
    public string IssueEventsUrl { get; set; }

    [JsonProperty("events_url")]
    public string EventsUrl { get; set; }

    [JsonProperty("assignees_url")]
    public string AssigneesUrl { get; set; }

    [JsonProperty("branches_url")]
    public string BranchesUrl { get; set; }

    [JsonProperty("tags_url")]
    public string TagsUrl { get; set; }

    [JsonProperty("blobs_url")]
    public string BlobsUrl { get; set; }

    [JsonProperty("git_tags_url")]
    public string GitTagsUrl { get; set; }

    [JsonProperty("git_refs_url")]
    public string GitRefsUrl { get; set; }

    [JsonProperty("trees_url")]
    public string TreesUrl { get; set; }

    [JsonProperty("statuses_url")]
    public string StatusesUrl { get; set; }

    [JsonProperty("languages_url")]
    public string LanguagesUrl { get; set; }

    [JsonProperty("stargazers_url")]
    public string StargazersUrl { get; set; }

    [JsonProperty("contributors_url")]
    public string ContributorsUrl { get; set; }

    [JsonProperty("subscribers_url")]
    public string SubscribersUrl { get; set; }

    [JsonProperty("subscription_url")]
    public string SubscriptionUrl { get; set; }

    [JsonProperty("commits_url")]
    public string CommitsUrl { get; set; }

    [JsonProperty("git_commits_url")]
    public string GitCommitsUrl { get; set; }

    [JsonProperty("comments_url")]
    public string CommentsUrl { get; set; }

    [JsonProperty("issue_comment_url")]
    public string IssueCommentUrl { get; set; }

    [JsonProperty("contents_url")]
    public string ContentsUrl { get; set; }

    [JsonProperty("compare_url")]
    public string CompareUrl { get; set; }

    [JsonProperty("merges_url")]
    public string MergesUrl { get; set; }

    [JsonProperty("archive_url")]
    public string ArchiveUrl { get; set; }

    [JsonProperty("downloads_url")]
    public string DownloadsUrl { get; set; }

    [JsonProperty("issues_url")]
    public string IssuesUrl { get; set; }

    [JsonProperty("pulls_url")]
    public string PullsUrl { get; set; }

    [JsonProperty("milestones_url")]
    public string MilestonesUrl { get; set; }

    [JsonProperty("notifications_url")]
    public string NotificationsUrl { get; set; }

    [JsonProperty("labels_url")]
    public string LabelsUrl { get; set; }

    [JsonProperty("releases_url")]
    public string ReleasesUrl { get; set; }

    [JsonProperty("deployments_url")]
    public string DeploymentsUrl { get; set; }

    [JsonProperty("created_at")]
    public DateTime CreatedAt { get; set; }

    [JsonProperty("updated_at")]
    public DateTime UpdatedAt { get; set; }

    [JsonProperty("pushed_at")]
    public DateTime PushedAt { get; set; }

    [JsonProperty("git_url")]
    public string GitUrl { get; set; }

    [JsonProperty("ssh_url")]
    public string SshUrl { get; set; }

    [JsonProperty("clone_url")]
    public string CloneUrl { get; set; }

    [JsonProperty("svn_url")]
    public string SvnUrl { get; set; }

    [JsonProperty("homepage")]
    public string Homepage { get; set; }

    [JsonProperty("size")]
    public int Size { get; set; }

    [JsonProperty("stargazers_count")]
    public int StargazersCount { get; set; }

    [JsonProperty("watchers_count")]
    public int WatchersCount { get; set; }

    [JsonProperty("language")]
    public string Language { get; set; }

    [JsonProperty("has_issues")]
    public bool HasIssues { get; set; }

    [JsonProperty("has_projects")]
    public bool HasProjects { get; set; }

    [JsonProperty("has_downloads")]
    public bool HasDownloads { get; set; }

    [JsonProperty("has_wiki")]
    public bool HasWiki { get; set; }

    [JsonProperty("has_pages")]
    public bool HasPages { get; set; }

    [JsonProperty("has_discussions")]
    public bool HasDiscussions { get; set; }

    [JsonProperty("forks_count")]
    public int ForksCount { get; set; }

    [JsonProperty("mirror_url")]
    public string MirrorUrl { get; set; }

    [JsonProperty("archived")]
    public bool Archived { get; set; }

    [JsonProperty("disabled")]
    public bool Disabled { get; set; }

    [JsonProperty("open_issues_count")]
    public int OpenIssuesCount { get; set; }

    [JsonProperty("license")]
    public string License { get; set; }

    [JsonProperty("allow_forking")]
    public bool AllowForking { get; set; }

    [JsonProperty("is_template")]
    public bool IsTemplate { get; set; }

    [JsonProperty("web_commit_signoff_required")]
    public bool WebCommitSignoffRequired { get; set; }

    [JsonProperty("topics")]
    public List<string> Topics { get; set; }

    [JsonProperty("visibility")]
    public string Visibility { get; set; }

    [JsonProperty("forks")]
    public int Forks { get; set; }

    [JsonProperty("open_issues")]
    public int OpenIssues { get; set; }

    [JsonProperty("watchers")]
    public int Watchers { get; set; }

    [JsonProperty("default_branch")]
    public string DefaultBranch { get; set; }

    [JsonProperty("temp_clone_token")]
    public string TempCloneToken { get; set; }

    [JsonProperty("template_repository")]
    public TemplateRepository TemplateRepository { get; set; }

    [JsonProperty("organization")]
    public Organization Organization { get; set; }

    [JsonProperty("network_count")]
    public int NetworkCount { get; set; }

    [JsonProperty("subscribers_count")]
    public int SubscribersCount { get; set; }
}

public class Owner
{
    [JsonProperty("login")]
    public string Login { get; set; }

    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("node_id")]
    public string NodeId { get; set; }

    [JsonProperty("avatar_url")]
    public string AvatarUrl { get; set; }

    [JsonProperty("gravatar_id")]
    public string GravatarId { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("html_url")]
    public string HtmlUrl { get; set; }

    [JsonProperty("followers_url")]
    public string FollowersUrl { get; set; }

    [JsonProperty("following_url")]
    public string FollowingUrl { get; set; }

    [JsonProperty("gists_url")]
    public string GistsUrl { get; set; }

    [JsonProperty("starred_url")]
    public string StarredUrl { get; set; }

    [JsonProperty("subscriptions_url")]
    public string SubscriptionsUrl { get; set; }

    [JsonProperty("organizations_url")]
    public string OrganizationsUrl { get; set; }

    [JsonProperty("repos_url")]
    public string ReposUrl { get; set; }

    [JsonProperty("events_url")]
    public string EventsUrl { get; set; }

    [JsonProperty("received_events_url")]
    public string ReceivedEventsUrl { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("site_admin")]
    public bool SiteAdmin { get; set; }
}

public class TemplateRepository
{
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("node_id")]
    public string NodeId { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("full_name")]
    public string FullName { get; set; }

    [JsonProperty("owner")]
    public Owner Owner { get; set; }

    [JsonProperty("private")]
    public bool Private { get; set; }

    [JsonProperty("html_url")]
    public string HtmlUrl { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("fork")]
    public bool Fork { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("archive_url")]
    public string ArchiveUrl { get; set; }

    [JsonProperty("assignees_url")]
    public string AssigneesUrl { get; set; }

    [JsonProperty("blobs_url")]
    public string BlobsUrl { get; set; }

    [JsonProperty("branches_url")]
    public string BranchesUrl { get; set; }

    [JsonProperty("collaborators_url")]
    public string CollaboratorsUrl { get; set; }

    [JsonProperty("comments_url")]
    public string CommentsUrl { get; set; }

    [JsonProperty("commits_url")]
    public string CommitsUrl { get; set; }

    [JsonProperty("compare_url")]
    public string CompareUrl { get; set; }

    [JsonProperty("contents_url")]
    public string ContentsUrl { get; set; }

    [JsonProperty("contributors_url")]
    public string ContributorsUrl { get; set; }

    [JsonProperty("deployments_url")]
    public string DeploymentsUrl { get; set; }

    [JsonProperty("downloads_url")]
    public string DownloadsUrl { get; set; }

    [JsonProperty("events_url")]
    public string EventsUrl { get; set; }

    [JsonProperty("forks_url")]
    public string ForksUrl { get; set; }

    [JsonProperty("git_commits_url")]
    public string GitCommitsUrl { get; set; }

    [JsonProperty("git_refs_url")]
    public string GitRefsUrl { get; set; }

    [JsonProperty("git_tags_url")]
    public string GitTagsUrl { get; set; }

    [JsonProperty("issue_comment_url")]
    public string IssueCommentUrl { get; set; }

    [JsonProperty("issue_events_url")]
    public string IssueEventsUrl { get; set; }

    [JsonProperty("issues_url")]
    public string IssuesUrl { get; set; }

    [JsonProperty("keys_url")]
    public string KeysUrl { get; set; }

    [JsonProperty("labels_url")]
    public string LabelsUrl { get; set; }

    [JsonProperty("languages_url")]
    public string LanguagesUrl { get; set; }

    [JsonProperty("merges_url")]
    public string MergesUrl { get; set; }

    [JsonProperty("milestones_url")]
    public string MilestonesUrl { get; set; }

    [JsonProperty("notifications_url")]
    public string NotificationsUrl { get; set; }

    [JsonProperty("pulls_url")]
    public string PullsUrl { get; set; }

    [JsonProperty("releases_url")]
    public string ReleasesUrl { get; set; }

    [JsonProperty("ssh_url")]
    public string SshUrl { get; set; }

    [JsonProperty("stargazers_url")]
    public string StargazersUrl { get; set; }

    [JsonProperty("statuses_url")]
    public string StatusesUrl { get; set; }

    [JsonProperty("subscribers_url")]
    public string SubscribersUrl { get; set; }

    [JsonProperty("subscription_url")]
    public string SubscriptionUrl { get; set; }

    [JsonProperty("tags_url")]
    public string TagsUrl { get; set; }

    [JsonProperty("teams_url")]
    public string TeamsUrl { get; set; }

    [JsonProperty("trees_url")]
    public string TreesUrl { get; set; }
}

public class Organization
{
    [JsonProperty("login")]
    public string Login { get; set; }

    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("node_id")]
    public string NodeId { get; set; }

    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("repos_url")]
    public string ReposUrl { get; set; }

    [JsonProperty("events_url")]
    public string EventsUrl { get; set; }

    [JsonProperty("hooks_url")]
    public string HooksUrl { get; set; }

    [JsonProperty("issues_url")]
    public string IssuesUrl { get; set; }

    [JsonProperty("members_url")]
    public string MembersUrl { get; set; }

    [JsonProperty("public_members_url")]
    public string PublicMembersUrl { get; set; }

    [JsonProperty("avatar_url")]
    public string AvatarUrl { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }
}
