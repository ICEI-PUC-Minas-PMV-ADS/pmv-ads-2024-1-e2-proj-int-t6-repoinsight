using Microsoft.AspNetCore.Mvc;
using repoInsight.Models;
using repoInsight.Data;
using repoInsight.Services;

namespace repoInsight.Controllers
{
    public class GitHubController : Controller
    {
        private readonly ILogger<GitHubController> _logger;
        private readonly RepoInsightContext _context;

        public GitHubController(ILogger<GitHubController> logger, RepoInsightContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Repo(string owner, string repo)
        {
            var response = await GitHub.GetRepo(owner+"/"+repo);
            if (response is null)
            {
                return View("Error");
            }
            var repositorio = _context.Repo.FirstOrDefault(r => r.Nome == response.Repository.FullName);
            if(repositorio is null)
            {
                return View("Error");
            }
            repositorio.DataVisita = DateTime.Now;
            _context.SaveChanges();

            return View(response);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(string owner, string repo)
        {
            _logger.LogInformation(repo);
            _logger.LogInformation(owner);
            var repositorio = _context.Repo.FirstOrDefault(r => r.Nome == owner+"/"+repo);
            _logger.LogInformation(repositorio.ToString());
            if(repositorio is null)
            {
                TempData["RepoDeleted"] = "Error";
                return RedirectToAction("Index", "Home");
            }
            _context.Repo.Remove(repositorio);
            _context.SaveChanges();

            TempData["RepoDeleted"] = "Success";

            return RedirectToAction("Index", "Home");
        }
    }
}
