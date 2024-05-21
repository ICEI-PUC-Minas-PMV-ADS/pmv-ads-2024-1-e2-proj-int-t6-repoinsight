using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using repoInsight.Models;
using repoInsight.Data;

namespace repoInsight.Controllers;

public class LoginController : Controller
{
    private readonly ILogger<LoginController> _logger;
    private readonly RepoInsightContext _context;

    public LoginController(ILogger<LoginController> logger, RepoInsightContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Validate(Usuario user)
    {
        var login = _context.Usuario.FirstOrDefault(u => u.Email == user.Email);
        if(login != null && login.Senha == user.Senha){
            return RedirectToAction("Index", "Home");
        }
        return NotFound("Nao achei :(");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
