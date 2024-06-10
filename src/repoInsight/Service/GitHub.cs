using Newtonsoft.Json;
using repoInsight.Models;
using System.Text.RegularExpressions;

namespace repoInsight.Services;

public static class GitHub
{
    public static async Task<RepoCommitsViewModel?> GetRepo(string nome)
    {
        JsonSerializerSettings settings = new JsonSerializerSettings
        {
            Error = null
        };

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


        if (repoResponse.IsSuccessStatusCode && commitsResponse.IsSuccessStatusCode && contributorsResponse.IsSuccessStatusCode && pullsResponse.IsSuccessStatusCode && branchesResponse.IsSuccessStatusCode)
        {
            string pullsData = await pullsResponse.Content.ReadAsStringAsync();
            var pullsDetails = JsonConvert.DeserializeObject<List<GithubPulls>>(pullsData, settings);

            string branchesData = await branchesResponse.Content.ReadAsStringAsync();
            var branchesDetails = JsonConvert.DeserializeObject<List<GithubBranches>>(branchesData, settings);

            string contributorsData = await contributorsResponse.Content.ReadAsStringAsync();
            var contributorsDetails = JsonConvert.DeserializeObject<List<GithubContributors>>(contributorsData, settings);

            string repoData = await repoResponse.Content.ReadAsStringAsync();
            GithubRepository repoDetails = JsonConvert.DeserializeObject<GithubRepository>(repoData, settings);

            string commitsData = await commitsResponse.Content.ReadAsStringAsync();
            List<GitCommit> commitDetails = JsonConvert.DeserializeObject<List<GitCommit>>(commitsData, settings);

            return new RepoCommitsViewModel
            {
                Repository = repoDetails,
                Commits = commitDetails,
                Pulls = pullsDetails.Count,
                Branches = branchesDetails.Count,
                Contributors = contributorsDetails.Count,
                Merges = commitDetails.Where(c => Regex.Match(c.Commit.Message, @"\#\d{1,}").Success).ToList().Count
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