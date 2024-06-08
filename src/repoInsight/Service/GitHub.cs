using Newtonsoft.Json;
using repoInsight.Models;

namespace repoInsight.Services;

public static class GitHub
{
    public static async Task<RepoCommitsViewModel?> GetRepo(string nome)
    {
        string[] repoParts = nome.Split("/");
        (string owner, string repo) = (repoParts[0], repoParts[1]);

        string repoApiUrl = $"https://api.github.com/repos/{owner}/{repo}";
        string commitsApiUrl = $"https://api.github.com/repos/{owner}/{repo}/commits";
        string contributorsApiUrl = $"https://api.github.com/repos/{owner}/{repo}/contributors";
        string pullsApiUrl = $"https://api.github.com/repos/{owner}/{repo}/pulls";
        string branchesApiUrl = $"https://api.github.com/repos/{owner}/{repo}/branches";

        using HttpClient client = new HttpClient();
        client.DefaultRequestHeaders.Add("User-Agent", "request");
        var repoResponse = await client.GetAsync(repoApiUrl);
        var commitsResponse = await client.GetAsync(commitsApiUrl);
        var contributorsResponse = await client.GetAsync(contributorsApiUrl);
        var pullsResponse = await client.GetAsync(pullsApiUrl);
        var branchesResponse = await client.GetAsync(branchesApiUrl);

        string pullsData = await pullsResponse.Content.ReadAsStringAsync();
        var pullsDetails = JsonConvert.DeserializeObject<List<GithubPulls>>(pullsData);

        string branchesData = await branchesResponse.Content.ReadAsStringAsync();
        var branchesDetails = JsonConvert.DeserializeObject<List<GithubBranches>>(branchesData);

        string contributorsData = await contributorsResponse.Content.ReadAsStringAsync();
        var contributorsDetails = JsonConvert.DeserializeObject<List<GithubContributors>>(contributorsData);

        if (repoResponse.IsSuccessStatusCode && commitsResponse.IsSuccessStatusCode)
        {
            string repoData = await repoResponse.Content.ReadAsStringAsync();
            GithubRepository repoDetails = JsonConvert.DeserializeObject<GithubRepository>(repoData);

            string commitsData = await commitsResponse.Content.ReadAsStringAsync();
            List<GitCommit> commitDetails = JsonConvert.DeserializeObject<List<GitCommit>>(commitsData);

            return new RepoCommitsViewModel
            {
                Repository = repoDetails,
                Commits = commitDetails,
                Pulls = pullsDetails.Count,
                Branches = branchesDetails.Count,
                Contributors = contributorsDetails.Count,
                Merges = commitDetails.Where(c => !c.Commit.Message.Contains("Merge pull request #")).ToList().Count
            };
        }
        return null;
    }
}

public class RepoCommitsViewModel
{
    public GithubRepository Repository { get; set; }
    public List<GitCommit> Commits { get; set; }
    public int Pulls { get; set; }
    public int Branches { get; set; }
    public int Contributors { get; set; }
    public int Merges { get; set; }
}
