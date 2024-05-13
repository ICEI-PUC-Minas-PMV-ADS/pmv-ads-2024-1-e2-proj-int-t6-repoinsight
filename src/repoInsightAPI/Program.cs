using Banco;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();

var app = builder.Build();

app.UseCors(builder => builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.MapPost("/signin", (Usuario login) => {
    RepoDb db = new RepoDb();
        var email = db.Usuarios.FirstOrDefault(u => u.Email == login.Email);
    if (email == null || email.Senha != login.Senha) {
        return Results.BadRequest(new { error = "Credenciais inválidas" });
    }
    return Results.Ok(new { message = "Usuário autenticado com sucesso"});
});

app.MapPost("/signup", (Usuario user) => {
    RepoDb db = new RepoDb();
    var existingUser = db.Usuarios.FirstOrDefault(u => u.Nome == user.Nome);
    if (existingUser != null) {
        return Results.Conflict(new { error = "Usuário já existe"});
    }
    db.Usuarios.Add(user);
    db.SaveChanges();
    return Results.Created($"/user/{user.Id}", user);
});

app.MapPost("/repos", (Repo novoRepo) => {
    RepoDb db = new RepoDb();
        db.Repos.Add(novoRepo);
    db.SaveChanges();
    return Results.Created($"/repos/{novoRepo.Id}", novoRepo);
});

app.MapGet("/repos", () => {
    RepoDb db = new RepoDb();
    var repos = db.Repos.ToList();
    return Results.Ok(repos);
});

app.MapGet("/repos/{id}", (HttpContext context, int id) => {
    using var db = new RepoDb();
    var repo = db.Repos.FirstOrDefault(r => r.Id == id);
    if (repo == null) {
        context.Response.StatusCode = StatusCodes.Status404NotFound;
        return context.Response.WriteAsync("Repositório não encontrado");
    }
    var json = JsonSerializer.Serialize(repo);
    context.Response.ContentType = "application/json";
    return context.Response.WriteAsync(json);
});

app.Run("http://localhost:3000");
