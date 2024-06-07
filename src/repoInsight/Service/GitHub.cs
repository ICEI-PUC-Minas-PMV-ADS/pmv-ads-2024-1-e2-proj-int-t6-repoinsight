using Newtonsoft.Json;
using repoInsight.Models;

namespace repoInsight.Services;

public static class GitHub
{
    public static async Task<RepoCommitsViewModel?> GetRepo(string owner, string repo)
    {
        string repoApiUrl = $"https://api.github.com/repos/{owner}/{repo}";
        string commitsApiUrl = $"https://api.github.com/repos/{owner}/{repo}/commits";

        using HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Add("User-Agent", "request");
        var repoResponse = await client.GetAsync(repoApiUrl);
        var commitsResponse = await client.GetAsync(commitsApiUrl);

        if (repoResponse.IsSuccessStatusCode && commitsResponse.IsSuccessStatusCode)
        {
            string repoData = await repoResponse.Content.ReadAsStringAsync();
            GithubRepository repoDetails = JsonConvert.DeserializeObject<GithubRepository>(repoData);

            string commitsData = await commitsResponse.Content.ReadAsStringAsync();
            List<GitCommit> commitDetails = JsonConvert.DeserializeObject<List<GitCommit>>(commitsData);

            return new RepoCommitsViewModel
            {
                Repository = repoDetails,
                Commits = commitDetails
            };
        }
        return null;
    }
}

public class RepoCommitsViewModel
{
    public GithubRepository Repository { get; set; }
    public List<GitCommit> Commits { get; set; }
}
