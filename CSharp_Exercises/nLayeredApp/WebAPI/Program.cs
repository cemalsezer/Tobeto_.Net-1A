using DataAccess;
using Business;
using Business.Profiles;
using Core.CrossCuttingConcerns.Exceptions.Extensions;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            //builder.Services.AddAutoMapper(typeof(ProductMapping));
            builder.Services.AddBusinessServices();
            builder.Services.AddDataAccessServices(builder.Configuration);
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

            app.UseAuthorization();
            app.ConfigureCustomExceptionMiddleware();

            app.MapControllers();

            app.Run();
        }
    }
}