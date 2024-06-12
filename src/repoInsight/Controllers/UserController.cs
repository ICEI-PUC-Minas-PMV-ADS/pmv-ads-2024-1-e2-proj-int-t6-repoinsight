using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using repoInsight.Models;
using repoInsight.Data;
using repoInsight.Services;

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
        string valorVariavelAmbiente = Environment.GetEnvironmentVariable("RepoInsightContext");
        _logger.LogInformation("Valor da variável de ambiente: " + valorVariavelAmbiente);
        user.Senha = user.ToPassword();
        _context.Add(user);
        _context.SaveChanges();
        return RedirectToAction("Index", "Home");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Validate(Usuario user)
    {
        var login = _context.Usuario.FirstOrDefault(u => u.Email == user.Email);
        if(login != null && login.VerifyPassword(user.Senha)){
            HttpContext.Session.SetString("email", login.Email);
            HttpContext.Session.SetString("nome", login.Nome);
            login.UltimoAcesso = DateTime.Now;
            _context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        ViewBag.UserNotFound = "Email ou Senha incorreto!";
        return View("Login");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult UpdatePassword(string password)
    {
        if (string.IsNullOrEmpty(password))
        {
            // Handle empty password
            return BadRequest("Password cannot be empty");
        }

        var user = _context.Usuario.FirstOrDefault(u => u.Email == HttpContext.Session.GetString("email"));
        if (user is null)
        {
            TempData["UpdatePassword"] = "Error";
        }
        user.Senha = user.ToPassword(password);
        _context.SaveChanges();
        TempData["UpdatePassword"] = "Success";
        return RedirectToAction("Index", "Home");

    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

}
