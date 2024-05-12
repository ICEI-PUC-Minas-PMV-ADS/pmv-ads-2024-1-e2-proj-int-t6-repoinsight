using Banco;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();
var app = builder.Build();

app.UseCors(builder => builder
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

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


app.Run("http://localhost:3000");
