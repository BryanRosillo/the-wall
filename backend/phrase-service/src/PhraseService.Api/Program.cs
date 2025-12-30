using PhraseService.Application.UseCases.PublishPhrase;
using PhraseService.Application.UseCases.SeeTheWall;
using PhraseService.Application.Ports;
using PhraseService.Infrastructure.Persistence;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<PublishPhraseUseCase>();
builder.Services.AddScoped<SeeTheWallUseCase>();
builder.Services.AddSingleton<IPhraseRepository, InMemoryPhraseRepository>();


var app = builder.Build();


app.UseHttpsRedirection();

app.MapControllers();

app.Run();



public partial class Program{}
