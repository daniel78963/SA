using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//Area de servicios
builder.Services.AddControllers();
builder.Services.AddDbContext<SA.APILibrary.Data.ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//Area de middlewares
app.MapControllers(); //le estamos diciendo que usemos los controladores para dar respuestas a las peticiones que lleguen a la API

app.Run();
