using APILayer;
using BoardGameFront.Client.Pages;
using BoardGameFront.Components;
using APILayer.DataHandlers;
using Models;
using System.Net.Http.Headers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .AddInteractiveWebAssemblyComponents();

//DI
builder.Services.AddHttpClient<BoardGameModel>("rootApi", c =>
{
    c.BaseAddress = new Uri(builder.Configuration.GetValue<string>("ServerApi"));
    var apiKey = builder.Configuration.GetValue<string>("apiKey");
    c.DefaultRequestHeaders.Add("X-Api-Key", apiKey);
    c.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json")); 
});

builder.Services.AddTransient<IDataHandler, DataHandler>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(BoardGameFront.Client._Imports).Assembly);

app.Run();
