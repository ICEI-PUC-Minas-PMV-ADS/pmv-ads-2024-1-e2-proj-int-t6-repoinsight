using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using repoInsight.Models;
using repoInsight.Data;

namespace repoInsight.Controllers;

public class UserController : Controller
{
    private readonly ILogger<UserController> _logger;
    private readonly RepoInsightContext _context;

    public UserController(ILogger<UserController> logger, RepoInsightContext context)
    {
        _logger = logger;
        _context = context;
    }

    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Login");
    }

    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Insert(Usuario user)
    {
        _context.Add(user);
        _context.SaveChanges();
        return RedirectToAction("Index", "Home");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Validate(Usuario user)
    {
        var login = _context.Usuario.FirstOrDefault(u => u.Email == user.Email);
        if(login != null && login.Senha == user.Senha){
            HttpContext.Session.SetString("email", user.Email);       
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
