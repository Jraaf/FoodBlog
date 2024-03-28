using FoodBlog.BLL.Services;
using FoodBlog.Common.DTO;
using FoodBlog.Common.Profiles;
using FoodBlog.DAL;
using FoodBlog.DAL.Entities;
using FoodBlog.DAL.Repository;
using FoodBlog.DAL.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddDbContext<ApplicationDBContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("FoodBlog"));
});

builder.Services.AddAutoMapper(typeof(PublicationProfile));

//repo
builder.Services.AddScoped<IPublicationRepository, PublicationRepository>();

//service
builder.Services.AddScoped<IPublicationService, PublicationService>();


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
