using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

//Area de servicios
//builder.Services.AddControllers();
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles; //esto es temporal para ignorar el error de referencia cíclica que se produce al serializar los objetos Author y Book, ya que ambos tienen una relación de uno a muchos. Esto es un problema común en las aplicaciones que utilizan Entity Framework Core y se puede solucionar de varias maneras, como por ejemplo utilizando DTOs (Data Transfer Objects) o configurando la serialización para ignorar las referencias cíclicas. Se deben usar DTOs
});
builder.Services.AddDbContext<SA.APILibrary.Data.ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//Area de middlewares
app.MapControllers(); //le estamos diciendo que usemos los controladores para dar respuestas a las peticiones que lleguen a la API

app.Run();
