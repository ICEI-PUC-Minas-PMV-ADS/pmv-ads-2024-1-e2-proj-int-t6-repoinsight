using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace repoInsightAPI.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly RepoDb _context;

        public UsuariosController(RepoDb context)
        {
            _context = context;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SignIn([FromBody] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                var user = await _context.Usuarios.FirstOrDefaultAsync(u => u.Email == usuario.Email);

                if (user != null && BCrypt.Net.BCrypt.Verify(usuario.Senha, user.Senha))
                {
                    return Ok(user);
                }
                else
                {  
                    return Unauthorized();
                }
            }
            else
            {
                return BadRequest();
            }
        }
    }
}