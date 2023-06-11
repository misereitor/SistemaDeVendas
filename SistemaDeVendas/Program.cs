using FluentValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SistemaDeVendas.Auth;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models.UsuariosModels;
using SistemaDeVendas.Repositorios;
using SistemaDeVendas.Repositorios.Interfaces;
using SistemaDeVendas.Validacoes;
using System.Text;

namespace SistemaDeVendas
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var connectionString = builder.Configuration.GetConnectionString("Database");
            // Add services to the container.

            builder.Services.AddControllers();
            var key = Encoding.ASCII.GetBytes(Settings.Secret);
            builder.Services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<ConexaoDBContext>(options =>
                options.UseNpgsql(connectionString));

            //injeções 
            builder.Services.AddTransient<IUsuariosRepositorio, UsuarioRepositorio>();
            builder.Services.AddTransient<ILoginRepositorio, LoginRepositorio>();
            builder.Services.AddTransient<IEmpresaRepositorio, EmpresaRepositorio>();
            builder.Services.AddTransient<IEnderecoRepositorio, EnderecoRepositorio>();
            builder.Services.AddScoped<IUsuarioValidadorRepositorio, UsuarioValidadorRepositorio>();

            //Validações
            builder.Services.AddValidatorsFromAssemblyContaining<UsuarioModelValidador>();
            builder.Services.AddValidatorsFromAssemblyContaining<SenhaValidador>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}