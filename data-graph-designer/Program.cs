using data_graph_designer;
using Microsoft.EntityFrameworkCore;
using data_graph_designer.Controllers;
using data_graph_designer.Service;
using data_graph_designer.Repository;
using data_graph_designer.Interfaces;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Scopes
/*
* Repositories
*/
builder.Services.AddScoped<DashboardRepository>();
builder.Services.AddScoped<DashboardRowRepository>();
builder.Services.AddScoped<EndpointDetailRepository>();
builder.Services.AddScoped<EndpointRepository>();
builder.Services.AddScoped<EndpointTypeRepository>();
builder.Services.AddScoped<GraphTypeRepository>();
builder.Services.AddScoped<TypeOperationRepository>();


/*
* Services
*/
builder.Services.AddScoped<DashboardRowService>();
builder.Services.AddScoped<DashboardService>();
builder.Services.AddScoped<DimensionService>();
builder.Services.AddScoped<EndpointDetailsService>();
builder.Services.AddScoped<EndpointService>();
builder.Services.AddScoped<EndpointTypeService>();
builder.Services.AddScoped<GraphTypeService>();
builder.Services.AddScoped<TypeOperationService>();

var allowedOrigin = builder.Configuration.GetSection("AllowedOrigins").Get<string[]>();

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin",
        builder => builder.AllowAnyOrigin()
                          .AllowAnyMethod()
                          .AllowAnyHeader()) ;
});

//Databases
var appConnection = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new ArgumentException("No hay cadena");
var dataConnection = builder.Configuration.GetConnectionString("DataConnection") ?? throw new ArgumentException("No hay cadena de data");

builder.Services.AddDbContext<GraphDesignerContext>(opt => opt.UseNpgsql(appConnection));
builder.Services.AddDbContext<DataDbContext>(opt => opt.UseNpgsql(dataConnection));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.UseCors("AllowOrigin");

app.Run();