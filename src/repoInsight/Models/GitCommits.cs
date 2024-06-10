using System;
using Newtonsoft.Json;

namespace repoInsight.Models
{
    public class GitCommit
    {
        [JsonProperty("sha")]
        public string Sha { get; set; }

        [JsonProperty("commit")]
        public CommitDetails Commit { get; set; }

        [JsonProperty("author")]
        public User Author { get; set; }

        [JsonProperty("committer")]
        public User Committer { get; set; }

        public class CommitDetails
        {
            [JsonProperty("url")]
            public string URL { get; set; }
            
            [JsonProperty("author")]
            public CommitAuthor Author { get; set; }

            [JsonProperty("committer")]
            public CommitAuthor Committer { get; set; }

            [JsonProperty("message")]
            public string Message { get; set; }

            // Propriedade para a URL modificada
            public string GitHubURL
            {
                get
                {
                    if (string.IsNullOrEmpty(URL))
                    {
                        return URL;
                    }

                    return URL.Replace("api.github.com/repos", "github.com")
                              .Replace("/git/commits", "/commit");
                }
            }
        }

        public class CommitAuthor
        {
            [JsonProperty("name")]
            public string Name { get; set; }

            [JsonProperty("email")]
            public string Email { get; set; }

            [JsonProperty("date")]
            public DateTime Date { get; set; }
        }

        public class User
        {
            [JsonProperty("login")]
            public string Login { get; set; }

            [JsonProperty("id")]
            public int Id { get; set; }

            [JsonProperty("avatar_url")]
            public string AvatarUrl { get; set; }

            [JsonProperty("html_url")]
            public string HtmlUrl { get; set; }
        }
    }
}
