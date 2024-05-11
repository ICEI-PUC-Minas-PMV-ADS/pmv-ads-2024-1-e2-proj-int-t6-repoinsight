using Banco;

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

app.Run();
