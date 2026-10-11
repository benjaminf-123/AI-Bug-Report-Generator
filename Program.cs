using AiBugReport.Components;
using AiBugReport.Services;

var builder = WebApplication.CreateBuilder(args);

// Lägg till Blazor-komponenter
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Registrera vår Bug Report-service
builder.Services.AddHttpClient<AiBugReportService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseStatusCodePagesWithReExecute(
    "/not-found",
    createScopeForStatusCodePages: true);

app.UseHttpsRedirection();

app.UseAntiforgery();

app.MapStaticAssets();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();