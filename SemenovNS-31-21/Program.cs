using Microsoft.EntityFrameworkCore;
using NLog;
using NLog.Web;
using SemenovNS_31_21.Database;
using SemenovNS_31_21.Middlewares;
using SemenovNS_31_21.ServiceExtensions;

var builder = WebApplication.CreateBuilder(args);

var logger = LogManager.Setup()
                    .LoadConfigurationFromAppSettings()
                    .GetCurrentClassLogger();

try
{

    builder.Logging.ClearProviders();
    builder.Host.UseNLog();

    // Add services to the container.

    builder.Services.AddControllers();
    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    builder.Services.AddDbContext<StudentDbContext>(options =>
        options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));

    builder.Services.AddControllersWithViews()
                .AddNewtonsoftJson(options =>
                options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
            );

    builder.Services.AddServices();

    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseMiddleware<ExceptionHandlerMiddleware>();

    app.UseAuthorization();

    app.MapControllers();

    app.Run();

}
catch (Exception ex)
{
    logger.Error(ex, "Error! Stopped by exception.");
}
finally
{
    LogManager.Shutdown();
}