var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseDefaultFiles();   // enables index.html
app.UseStaticFiles();    // serves wwwroot

app.Run();
