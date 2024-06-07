using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using repoInsight.Models;
using repoInsight.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.IdentityModel.Tokens;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using repoInsight.Services;

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
        var repos = from r in _context.Repo join u in _context.Usuario on r.IdUsuario equals u.Id select r;
        var ultimos = repos.OrderByDescending(r => r.DataVisita).Take(3).Select(r => r).ToList();
        var tuple = new Tuple<List<Repo>, Repo, List<Repo>>(repos.ToList(), new Repo(), ultimos);
        return View(tuple);
        
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult AddRepo()
    {
        var nome = HttpContext.Request.Form["Item2.Nome"].ToString();
        string[] repoParts = nome.Split("/");
        (string owner, string repo) = (repoParts[0], repoParts[1]);
        var response = GitHub.GetRepo(owner, repo);
        if (response is null)
        {
            ViewBag.RepoNotFound = "Erro!";
        }
        else
        {
            var userId =(int) (from u in _context.Usuario select u.Id).Single();
            _context.Add(new Repo(){Nome = nome, IdUsuario = userId});
            _context.SaveChanges();
            ViewBag.RepoNotFound = "Sucesso!";
        }
        var repos = from r in _context.Repo join u in _context.Usuario on r.IdUsuario equals u.Id select r;
        var ultimos = repos.OrderByDescending(r => r.DataVisita).Take(3).Select(r => r).ToList();
        var tuple = new Tuple<List<Repo>, Repo, List<Repo>>(repos.ToList(), new Repo(), ultimos);
        return View("Index", tuple);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
