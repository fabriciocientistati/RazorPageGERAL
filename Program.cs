var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages(); //Informa que irá trabalhar com RazorPage

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.UseHttpsRedirection(); //Evita erros de HTTP/HTTPS
app.UseStaticFiles(); //Para o funcionamento das pastas estaticas wwwroot

app.UseRouting(); //Pode criar URL customizadas
app.MapRazorPages(); //Mapea as paginas

app.Run();
