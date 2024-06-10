using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using repoInsight.Models;
using repoInsight.Data;
using Microsoft.AspNetCore.Authentication;
using Microsoft.IdentityModel.Tokens;
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
        var repos = RepoService.ListRepos(_context, HttpContext.Session.GetString("email"));

        if (TempData["UpdatePassword"] != null)
        {
            if (TempData["UpdatePassword"] == "Error")
            {
                ViewBag.ErrorMessage = "Erro ao encontrar o usuário!";
            } else
            {
                ViewBag.SuccessMessage = "Senha atualizada com sucesso!";
            }
        }

        if (TempData["RepoDeleted"] != null)
        {
            if (TempData["UpdatePassword"] == "Error")
            {
                ViewBag.ErrorMessage = "Erro ao deletar o repositório!";
            } else
            {
                ViewBag.SuccessMessage = "Repositório deletado com sucesso!";
            }
        }

        return View(repos.ToTuple());
        
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult AddRepo()
    {
        var nome = HttpContext.Request.Form["Item2.Nome"].ToString();
        var response = GitHub.GetRepo(nome);
        if (response is null)
        {
            ViewBag.ErrorMessage = "Erro!";
        }
        else
        {
            var userId =(int) (from u in _context.Usuario where u.Email == HttpContext.Session.GetString("email") select u.Id).Single();
            _context.Add(new Repo(){Nome = nome, Descricao = response.Result?.Repository?.Description, IdUsuario = userId});
            _context.SaveChanges();
            ViewBag.SuccessMessage = "Sucesso!";
        }
        var repos = RepoService.ListRepos(_context, HttpContext.Session.GetString("email"));
        return View("Index", repos.ToTuple());
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
