using Core.ServiceApp.Services;
using Core.ServiceApp.Services.ServicesContracts;
using DataAccess.DBContexts;
using DataAccess.DBContexts.IDBContracts;
using DataAccess.MDCG_Repositories.GLOB;
using DataAccess.MDCG_Repositories.MDCG;
using DataAccess.MDCG_Repositories.MDCG_RepositoriesContracts.GLOB;
using DataAccess.MDCG_Repositories.MDCG_RepositoriesContracts.MDCG;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Cross_Cutting.Register
{
    //Cross Layer
    public static class IoCRegister
    {
        public static IServiceCollection AddRegistration(this IServiceCollection services)
        {
            services.AddScoped<IMDCG_DBContext, MDCG_DBContext>();
            AddRegisterRepositories(services);
            AddRegisterServices(services);

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }

        private static IServiceCollection AddRegisterServices(this IServiceCollection services)
        {

            services.AddTransient<ICatalogos_Service, Catalogos_Service>();
            services.AddTransient<IFuncionario_Service, Funcionario_Service>();
            services.AddTransient<IDependientes_Service, Dependientes_Service>();
            services.AddTransient<IAcreditaciones_Service, Acreditaciones_Service>();
            services.AddTransient<IRecepcionPNC_Service, RecepcionPNC_Service>();
            services.AddTransient<ITransito_Service, Transito_Service>();
            services.AddTransient<IDireccionPNC_Service, DireccionPNC_Service>();

            return services;
        }

        private static IServiceCollection AddRegisterRepositories(this IServiceCollection services)
        {

            services.AddScoped<IGLOB_GENERO_REPO, GLOB_GENERO_REPO>();
            services.AddScoped<IGLOB_ESTADO_CIVIL_REPO, GLOB_ESTADO_CIVIL_REPO>();
            services.AddScoped<IGLOB_PAIS_REPO, GLOB_PAIS_REPO>();
            services.AddScoped<IGLOB_TIPO_PASAPORTE_REPO, GLOB_TIPO_PASAPORTE_REPO>();
            services.AddScoped<IGLOB_TIPO_FUNCIONARIO_REPO, GLOB_TIPO_FUNCIONARIO_REPO>();
            services.AddScoped<IGLOB_GRADO_ACADEMICO, GLOB_GRADO_ACADEMICO>();
            services.AddScoped<IGLOB_TIPO_LICENCIA_REPO, GLOB_TIPO_LICENCIA_REPO>();
            services.AddScoped<IGLOB_PARENTESCO_REPO, GLOB_PARENTESCO_REPO>();
            services.AddScoped<IGLOB_MISIONES_ESTERIOR_REPO, GLOB_MISIONES_ESTERIOR_REPO>();
            services.AddScoped<IGLOB_TRATAMIENTO_REPO, GLOB_TRATAMIENTO_REPO>();
            


            services.AddScoped<IMCDG_FUNCIONARIO_REPO, MCDG_FUNCIONARIO_REPO>();
            services.AddScoped<IMDCG_DEPENDIENTES_REPO, MDCG_DEPENDIENTES_REPO>();
            services.AddScoped<IMDCG_ACREDITACIONES_REPO, MDCG_ACREDITANCIONES_REPO>();
            services.AddScoped<IMDCG_TIPO_ACREDITACION_REPO, MDCG_TIPO_ACREDITACION_REPO>();
            services.AddScoped<IMDCG_CARGO_REPO, MDCG_CARGO_REPO>();

            return services;
        }
    }
}
