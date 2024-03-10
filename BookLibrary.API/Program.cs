
using BookLibrary.DataStore.SQLServer;
using BookLibrary.DataStore.SQLServer.Interface;
using BookLibrary.DataStore.SQLServer.Repositories;
using BookLibrary.Models;
using BookLibrary.Services.Implementation;
using BookLibrary.Services.Interface;
using Microsoft.EntityFrameworkCore;

namespace BookLibrary.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var configuration = builder.Configuration;

            // Add services to the container.
            builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("localdb")));

            builder.Services.AddAutoMapper(typeof(MappingProfile));



            builder.Services.AddScoped<IBookService, BookService>();
            builder.Services.AddScoped<IBookRepository, BookRepository>();



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
}