using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using ProjetoCarroAPI.Data.Contexto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjetoCarroAPI.Dominio.Dominio;
using ProjetoCarroAPI.Data.Repository.Interface;
using ProjetoCarroAPI.Data.Repository;
using ProjetoCarroAPI.Servico.Servico.Interface;
using ProjetoCarroAPI.Servico.Servico;
using ProjetoCarroAPI.Controllers;

namespace ProjetoCarroAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddDbContext<ProjetoCarroAPIContexto>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "ProjetoCarroAPI", Version = "v1" });
            });

            using IHost host = Host.CreateDefaultBuilder()
    .ConfigureServices(services =>
    {
        //injeção de depencia do repositorio e da interface
        services.AddTransient<ICarroRepository, CarroRepository>();
        services.AddScoped<IPagamentoRepository, PagamentoRepository>();
        services.AddSingleton<IPessoaRepository, PessoaRepository>();

        //injeção de dependencia do repositorio e do serviço
        services.AddSingleton<ICarroServico, CarroServico>();
        services.AddSingleton<IPagamentoServico, PagamentoServico>();
        services.AddSingleton<IPessoaServico, PessoaServico>();

        services.AddTransient<CarroController>();
    })
    .Build();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "ProjetoCarroAPI v1"));
            }

            

            app.UseHttpsRedirection();


            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
