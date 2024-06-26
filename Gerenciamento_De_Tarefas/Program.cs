using FluentValidation;
using FluentValidation.AspNetCore;
using Gerenciamento_De_Tarefas.Domain.ModeloPadrao;
using Gerenciamento_De_Tarefas.Domain.TarefasModel;
using Gerenciamento_De_Tarefas.Domain.UsuarioModel;
using Gerenciamento_De_Tarefas.Domain.Validacoes;
using Gerenciamento_De_Tarefas.Infra.Data;
using Gerenciamento_De_Tarefas.Infra.RepositorioPadrao;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddControllers().AddFluentValidation(config =>
//{
//    config.RegisterValidatorsFromAssemblies((IEnumerable<System.Reflection.Assembly>)typeof(Program).Assembly);
//});

builder.Services.AddScoped<IModeloPadraoRepositorio<Usuario>, UsuarioRepositorio>();
builder.Services.AddScoped<IModeloPadraoRepositorio<Tarefas>, TarefasRepositorio>();

builder.Services.AddScoped<IModeloPadraoServices<Tarefas>, ServicoTarefa>();
builder.Services.AddScoped<IModeloPadraoServices<Usuario>, ServicoUsuario>();

builder.Services.AddScoped<IValidator<Usuario>,ValidacaoUsuario>();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
