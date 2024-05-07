using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/weatherforecast", () =>
{
    var forecast =  Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.MapPost("/createUser", async (HttpContext context) =>
{
    var request = await context.Request.ReadFromJsonAsync<User>();

    if (request != null)
    {
        // Conexão com o banco de dados MySQL
        string connectionString = "server=127.0.0.1;user=root;database=repos;password=3503;";
        using MySqlConnection connection = new MySqlConnection(connectionString);

        try
        {
            // Abra a conexão
            await connection.OpenAsync();

            // Comando SQL para inserir dados do usuário
            string sql = "INSERT INTO TbUsuario (id, nome, email, githubId, senha, dataCriacao, ultimoAcesso) " +
                         "VALUES (@id, @nome, @email, @githubId, @senha, @dataCriacao, @ultimoAcesso)";

            // Crie e configure um comando MySQL
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@id", request.Id);
            command.Parameters.AddWithValue("@nome", request.Nome);
            command.Parameters.AddWithValue("@email", request.Email);
            command.Parameters.AddWithValue("@githubId", request.GithubId);
            command.Parameters.AddWithValue("@senha", request.Senha);
            command.Parameters.AddWithValue("@dataCriacao", DateTime.Now);
            command.Parameters.AddWithValue("@ultimoAcesso", DateTime.Now);

            // Execute o comando SQL
            await command.ExecuteNonQueryAsync();

            // Responda com sucesso
            context.Response.StatusCode = StatusCodes.Status201Created;
            await context.Response.WriteAsync("Usuário criado com sucesso.");
        }
        catch (Exception ex)
        {
            // Responda com erro
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;
            await context.Response.WriteAsync($"Erro: {ex.Message}");
        }
    }
    else
    {
        // Responda com erro se os dados não forem fornecidos
        context.Response.StatusCode = StatusCodes.Status400BadRequest;
        await context.Response.WriteAsync("Dados do usuário não fornecidos.");
    }
    return Results.NoContent();
})
    .WithName("CreateUser")
    .WithOpenApi()
    .Accepts<User>("application/json"); 


app.Run();



record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}

record User(int Id, string Nome, string Email, string GithubId, string Senha);