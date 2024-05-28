using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using repoInsight.Models;
using repoInsight.Data;

namespace repoInsight.Controllers;

public class RegisterController : Controller
{
    private readonly ILogger<RegisterController> _logger;
    private readonly RepoInsightContext _context;

    public RegisterController(ILogger<RegisterController> logger, RepoInsightContext context)
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
    public IActionResult Insert(Usuario user)
    {
        _context.Add(user);
        _context.SaveChanges();
        return RedirectToAction("Index", "Home");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
