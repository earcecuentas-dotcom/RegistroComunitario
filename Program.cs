var builder = WebApplication.CreateBuilder(args);

// Agregar servicios MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configuración de entorno
if (!app.Environment.IsDevelopment())
{
	app.UseExceptionHandler("/Home/Error");
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// Ruta por defecto
app.MapControllerRoute(
	name: "default",
	pattern: "{controller=Vecino}/{action=Index}/{id?}");

app.Run();
