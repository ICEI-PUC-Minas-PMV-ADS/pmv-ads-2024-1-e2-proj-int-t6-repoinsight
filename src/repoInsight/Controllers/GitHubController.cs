using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using repoInsight.Models;

namespace repoInsight.Controllers
{
    public class GitHubController : Controller
    {
        private static readonly HttpClient client = new HttpClient();

        public GitHubController()
        {
            client.DefaultRequestHeaders.Add("User-Agent", "request");
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "GitHub";
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Repo(string owner, string repo)
        {
            string repoApiUrl = $"https://api.github.com/repos/{owner}/{repo}";
            string commitsApiUrl = $"https://api.github.com/repos/{owner}/{repo}/commits";

            var repoResponse = await client.GetAsync(repoApiUrl);
            var commitsResponse = await client.GetAsync(commitsApiUrl);

            if (repoResponse.IsSuccessStatusCode && commitsResponse.IsSuccessStatusCode)
            {
                string repoData = await repoResponse.Content.ReadAsStringAsync();
                GithubRepository repoDetails = JsonConvert.DeserializeObject<GithubRepository>(repoData);

                string commitsData = await commitsResponse.Content.ReadAsStringAsync();
                List<GitCommit> commitDetails = JsonConvert.DeserializeObject<List<GitCommit>>(commitsData);

                var viewModel = new RepoCommitsViewModel
                {
                    Repository = repoDetails,
                    Commits = commitDetails
                };

                return View(viewModel);
            }

            return View("Error");
        }
    }

    public class RepoCommitsViewModel
    {
        public GithubRepository Repository { get; set; }
        public List<GitCommit> Commits { get; set; }
    }
}
