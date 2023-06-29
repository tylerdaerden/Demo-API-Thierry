using F23L034_GestContact.Api.Models.Repositories;
using F23L034_GestContact.Api.Models.Services;
using System.Data.Common;
using System.Data.SqlClient;

namespace F23L034_GestContact.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            IConfiguration configuration = builder.Configuration;

            // Add services to the container.
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddTransient<DbConnection>(sp => new SqlConnection(configuration.GetConnectionString("F23L034_GestContact_Cqs")));
            builder.Services.AddScoped<IAuthRepository, AuthService>();
            builder.Services.AddScoped<IContactRepository, ContactService>();

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