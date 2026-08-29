var builder = WebApplication.CreateBuilder(args);

//Area de servicios
builder.Services.AddControllers();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//Area de middlewares
app.MapControllers(); //le estamos diciendo que usemos los controladores para dar respuestas a las peticiones que lleguen a la API

app.Run();
