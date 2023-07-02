using FluentValidation;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SistemaDeVendas.Auth;
using SistemaDeVendas.Auth.Politicas;
using SistemaDeVendas.Data;
using SistemaDeVendas.Models.UsuariosModels;
using SistemaDeVendas.Repositorios;
using SistemaDeVendas.Repositorios.Interfaces.InteerfaceEmpresa;
using SistemaDeVendas.Repositorios.Interfaces.InterfaceFornecedor;
using SistemaDeVendas.Repositorios.Interfaces.InterfaceLogin;
using SistemaDeVendas.Repositorios.Interfaces.InterfaceModelsGeral;
using SistemaDeVendas.Repositorios.Interfaces.InterfaceUsuario;
using SistemaDeVendas.TratamentoDeErros;
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
            builder.Services.AddScoped<IFornecedorRepositorio, FornecedorRepositorio>();

            //Validações
            builder.Services.AddValidatorsFromAssemblyContaining<UsuarioModelValidador>();
            builder.Services.AddValidatorsFromAssemblyContaining<SenhaValidador>();

            //Politicas
            builder.Services.AddAuthorization(options =>
            {
                Autorizacao.PoliticasAutorizacao(options);
                options.AddPolicy("Master", policy =>
                {
                    policy.RequireRole("Master");
                });
            });


            var app = builder.Build();
            //Tratamento de erros
            app.UseMiddleware<ShowException>();

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