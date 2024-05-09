using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using loginback.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace loginback.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext _context;

        public UserController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Users
        public async Task<IActionResult> Index()
        {
            return View(await _context.Users.ToListAsync());
        }

        // Login
        public IActionResult Login()
        {
            // Retorne a view correspondente à página de login Vue
            return View("/frontend/src/views/SignIn.vue");
        }

        [HttpPost]
        public async Task<IActionResult> Login(User user)
        {
            var dados = await _context.Users.FindAsync(user.Email);
            if (dados == null)
            {
                // ViewBag.Message = "Usuário e/ou senha inválidos!";
                return View("/frontend/src/views/SignIn.vue");
            }
            bool senhaOk = BCrypt.Net.BCrypt.Verify(user.Senha, dados.Senha);
            if (senhaOk)
            {
                var claims = new[]
                {
                    new Claim(ClaimTypes.Name, dados.Nome),
                    new Claim(ClaimTypes.NameIdentifier, dados.Id.ToString())
                };
                var usuarioidentity = new ClaimsIdentity(claims, "login");
                var principal = new ClaimsPrincipal(usuarioidentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(8),
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(principal, props);
                return Redirect("/");
            }
            else
            {
                // ViewBag.Message = "Usuário e/ou senha inválidos!";
                return View("/frontend/src/views/SignIn.vue");
            }
        }

        // Logout
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
