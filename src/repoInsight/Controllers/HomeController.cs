using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using repoInsight.Models;
using repoInsight.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.IdentityModel.Tokens;

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
        if(HttpContext.Session.GetString("email").IsNullOrEmpty()){
            return RedirectToAction("Login", "User");
        }
        var repo = _context.Repo.FirstOrDefault();
        var lista = new List<repoInsight.Models.Repo>();
        if(repo != null){
            lista.Add(repo);
        }
        return View(lista);
        
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
