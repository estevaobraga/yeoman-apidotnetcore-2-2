using <%= nomeProj %>.domain.domain.Interfaces;
using <%= nomeProj %>.domain.domain.Validations;
using <%= nomeProj %>.infra.Data.MSSQL.Context;
using <%= nomeProj %>.infra.Data.MSSQL.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace <%= nomeProj %>.infra.CrossCutting.IoC
{
    public class NativeInjectorBootStrapper
    {
        public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
        {
            #region Repositories
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
            services.AddTransient<ILivrosRepository, LivrosRepository>();
            #endregion

            #region Validations
            services.AddScoped<UsuarioValidations>();
            services.AddScoped<LivrosValidations>();
            #endregion

            services.AddDbContext<Context>(o => o.UseSqlServer("Server=myServerAddress;Database=myDataBase;User Id=sa;Password=sa@12345;"));
        }
    }
}
