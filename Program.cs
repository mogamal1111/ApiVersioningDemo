
using Asp.Versioning;

var builder = WebApplication.CreateBuilder(args);

// Register Controllers
builder.Services.AddControllers();

// Configure API Versioning
builder.Services
    .AddApiVersioning(options =>
    {
        options.DefaultApiVersion = new ApiVersion(1, 0);

        options.AssumeDefaultVersionWhenUnspecified = false;

        options.ReportApiVersions = true;

        options.ApiVersionReader =
            new UrlSegmentApiVersionReader();
    })
    .AddMvc();

var app = builder.Build();

app.MapControllers();

app.Run();
