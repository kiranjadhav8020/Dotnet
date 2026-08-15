
using CurdOperation_RestAPI.Data;
using CurdOperation_RestAPI.Service;
using CurdOperation_RestAPI.Services;
using Microsoft.EntityFrameworkCore;

namespace CurdOperation_RestAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Register DB call to program file

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseOracle(builder.Configuration.GetConnectionString("OracleDbConnection")));

            // Add services to the container.
            builder.Services.AddScoped<IStudentService, StudentService>();


            builder.Services.AddControllers();
            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
            builder.Services.AddOpenApi();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.MapOpenApi();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
