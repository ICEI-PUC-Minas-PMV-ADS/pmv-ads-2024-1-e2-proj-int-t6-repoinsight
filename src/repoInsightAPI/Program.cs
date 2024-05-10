using Banco;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapPost("/signin", (Usuario login) => {
    RepoDb db = new RepoDb();
    var user = db.Usuarios
        .Where(u => u.Nome == login.Nome && u.Senha == login.Senha);

    return Results.Ok("Logado com sucesso");
});

app.MapPost("/signup", (Usuario user) => {
    RepoDb db = new RepoDb();
    db.Usuarios.Add(user);
    db.SaveChanges();

    return Results.Created($"/user/{user.Id}", user);
});

app.Run();
