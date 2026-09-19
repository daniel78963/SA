using Microsoft.EntityFrameworkCore;
using SA.APILibrary;
using SA.APILibrary.Interfaces;
using SA.APILibrary.Repositories;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

//Area de servicios
//builder.Services.AddControllers();

builder.Services.AddTransient<TransientService>();
builder.Services.AddScoped<ScopedService>();
builder.Services.AddSingleton<SingletonService>();

builder.Services.AddSingleton<IRepositoryValues, RepositoryValues>();
//builder.Services.AddTransient<IRepositoryValues, RepositoryValuesOracle>();

builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles; //esto es temporal para ignorar el error de referencia cíclica que se produce al serializar los objetos Author y Book, ya que ambos tienen una relación de uno a muchos. Esto es un problema común en las aplicaciones que utilizan Entity Framework Core y se puede solucionar de varias maneras, como por ejemplo utilizando DTOs (Data Transfer Objects) o configurando la serialización para ignorar las referencias cíclicas. Se deben usar DTOs
});
builder.Services.AddDbContext<SA.APILibrary.Data.ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

var app = builder.Build();

//Area de middlewares

//app.MapGet("/", () => "Hello World!");

//app.Use(async (context, next) =>
//{
//    var logger = context.RequestServices.GetRequiredService<ILogger<Program>>();
//    logger.LogInformation("Handling request: {Method} {Path}", context.Request.Method, context.Request.Path);
//    await next.Invoke(); //Esto permite continuar con la ejecución del siguiente middleware en la cadena de middlewares (MapControllers();). Si no se llama a next.Invoke(), la solicitud se detendrá y no se ejecutarán los siguientes middlewares, lo que puede resultar en una respuesta incompleta o en un error.
//    logger.LogInformation("Finished handling request. Status: {StatusCode}", context.Response.StatusCode);
//}); 
//app.UseLogRequestMiddleware(); //esto reemplaza las líneas de arriba. Esto es un middleware que se encarga de loguear las peticiones que llegan a la API, y el status code de la respuesta. Se puede usar para debuggear la API y ver que peticiones llegan y que respuestas se envían. Se puede usar para medir el rendimiento de la API y ver que peticiones tardan más en procesarse. Se puede usar para detectar errores en la API y ver que peticiones generan errores. Se puede usar para auditar la API y ver que peticiones se hacen a la API. Se puede usar para monitorear la API y ver que peticiones se hacen a la API. Se puede usar para analizar la API y ver que peticiones se hacen a la API. Se puede usar para optimizar la API y ver que peticiones se hacen a la API. Se puede usar para mejorar la API y ver que peticiones se hacen a la API. Se puede usar para escalar la API y ver que peticiones se hacen a la API. Se puede usar para mantener la API y ver que peticiones se hacen a la API. Se puede usar para evolucionar la API y ver que peticiones se hacen a la API. Se puede usar para innovar en la API y ver que peticiones se hacen a la API. Se puede usar para transformar la API y ver que peticiones se hacen a la API. Se puede usar para revolucionar la API y ver que peticiones se hacen a la API. Se puede usar para cambiar el mundo con la API y ver que peticiones se hacen a la API.

//app.Use(async (context, next) =>
//{
//    //if (context.Request.Path.StartsWith("/api/"))
//    if (context.Request.Path == "/bloqueado")
//    {
//        context.Response.StatusCode = 403; // Forbidden
//        await context.Response.WriteAsync("Access to this resource is forbidden.");
//    }
//    else
//    {
//        await next.Invoke();
//    }
//});
//app.UseBlockRequestMiddleware(); //esto reemplaza las líneas de arriba. Esto es un middleware que se encarga de bloquear las peticiones que llegan a la API, y el status code de la respuesta. Se puede usar para bloquear peticiones maliciosas, o para bloquear peticiones que no cumplen con ciertos requisitos. Se puede usar para bloquear peticiones que no tienen autorización, o para bloquear peticiones que no tienen autenticación. Se puede usar para bloquear peticiones que no tienen permisos, o para bloquear peticiones que no tienen roles. Se puede usar para bloquear peticiones que no tienen claims, o para bloquear peticiones que no tienen scopes. Se puede usar para bloquear peticiones que no tienen tokens, o para bloquear peticiones que no tienen cookies. Se puede usar para bloquear peticiones que no tienen headers, o para bloquear peticiones que no tienen query strings. Se puede usar para bloquear peticiones que no tienen body, o para bloquear peticiones que no tienen form data. Se puede usar para bloquear peticiones que no tienen files, o para bloquear peticiones que no tienen streams. Se puede usar para bloquear peticiones que no tienen websockets, o para bloquear peticiones que no tienen server-sent events. Se puede usar para bloquear peticiones que no tienen gRPC, o para bloquear peticiones que no tienen SignalR. Se puede usar para bloquear peticiones que no tienen GraphQL, o para bloquear peticiones que no tienen OData. Se puede usar para bloquear peticiones que no tienen REST, o para bloquear peticiones que no tienen SOAP. Se puede usar para bloquear peticiones que no tienen XML, o para bloquear peticiones que no tienen JSON. Se puede usar para bloquear peticiones que no tienen CSV, o para bloquear peticiones que no tienen YAML. Se puede usar para bloquear peticiones que no tienen Protobuf, o para bloquear peticiones que no tienen Avro. Se puede usar para bloquear peticiones que no tienen Thrift, o para bloquear peticiones que no tienen Cap'n Proto. Se puede usar para bloquear peticiones que no tienen FlatBuffers, o para bloquear peticiones que no tienen MessagePack.

app.MapControllers(); //le estamos diciendo que usemos los controladores para dar respuestas a las peticiones que lleguen a la API

app.Run();
