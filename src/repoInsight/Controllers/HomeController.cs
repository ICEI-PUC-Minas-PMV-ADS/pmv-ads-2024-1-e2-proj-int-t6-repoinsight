using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using repoInsight.Models;
using repoInsight.Data;

namespace repoInsight.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly RepoInsightContext _context;

    public HomeController(ILogger<HomeController> logger, RepoInsightContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        // Usuario user = new Usuario();
        // user.Nome = "test";
        // user.Senha = "123";
        // user.Email = "meu@email.com";
        // user.GithubId = "1";
        // _context.Add(user);
        // _context.SaveChanges();
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
