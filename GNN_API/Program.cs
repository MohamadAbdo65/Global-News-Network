
using GNN_DAL.Data;
using GNN_DAL.Repos;
using GNN_Logic.Services;
using Microsoft.EntityFrameworkCore;

void RegisterServices(IServiceCollection services)
{
    // category
    services.AddScoped<CategoryRepo>();
    services.AddScoped<CategoryService>();
}



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<GNNDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("constr")));


RegisterServices(builder.Services);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


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

app.Run();
