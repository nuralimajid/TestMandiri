using TestMandiri.Data;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestMandiri.Repository.Interfaces;
using TestMandiri.Repository;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var connectionString = builder.Configuration.GetConnectionString("testDBM");
        builder.Services.AddDbContext<AppDBContext>(options =>
            options.UseSqlServer(connectionString));
        builder.Services.AddScoped<IBukuRepository, BukuRepository>();
        builder.Services.AddScoped<IPenulisRepository, PenulisRepository>();
        builder.Services.AddScoped<IKategoriRepository, KategoriRepository>();

        // Add services to the container.

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
    }
}