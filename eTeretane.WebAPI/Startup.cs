using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eTeretane.Model.Requests;
using eTeretane.WebAPI.Database;
using eTeretane.WebAPI.EF;
using eTeretane.WebAPI.Security;
using eTeretane.WebAPI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;

namespace eTeretane.WebAPI
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
            services.AddAutoMapper(typeof(Startup));
            services.AddControllers();

            services.AddMvc();
            
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });

            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            var connection = @"Server=.;Database=160154_eTeretane;Trusted_Connection=True;MultipleActiveResultSets=true";
            services.AddDbContext<eTeretaneContext>(options => options.UseSqlServer(connection));


            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<IKorisnickiNalogService, KorisnickiNalogService>();

            services.AddScoped<IClanService, ClanService>();

            services.AddScoped<IService<Model.Uloge, object>, BaseService<Model.Uloge, object, Uloga>>();

            services.AddScoped<ICRUDService<Model.Grad, object, GradUpsetRequest, GradUpsetRequest>, BaseCRUDService<Model.Grad, object, Grad, GradUpsetRequest, GradUpsetRequest>>();
            services.AddScoped<ICRUDService<Model.Teretane, TeretanaSearchRequest, TeretanaUpsertRequest, TeretanaUpsertRequest>, TeretanaService>();
            services.AddScoped<ICRUDService<Model.Licence, object, LicencaUpsertRequest, LicencaUpsertRequest>, BaseCRUDService<Model.Licence, object, Licenca, LicencaUpsertRequest, LicencaUpsertRequest>>();
            services.AddScoped<ICRUDService<Model.KuponPopusti, object, KuponUpsertRequest, KuponUpsertRequest>, BaseCRUDService<Model.KuponPopusti, object, KuponPopust, KuponUpsertRequest, KuponUpsertRequest>>();
            services.AddScoped<ICRUDService<Model.TreningDetalji, TreningDetaljiSearchRequest, TreningDetaljiUpsertRequest, TreningDetaljiUpsertRequest>, BaseCRUDService<Model.TreningDetalji, TreningDetaljiSearchRequest, TreningDetalji, TreningDetaljiUpsertRequest, TreningDetaljiUpsertRequest>>();
            services.AddScoped<ICRUDService<Model.TreningZahtjev, object, TreningZahtjevUpsertRequest, TreningZahtjevUpsertRequest>, BaseCRUDService<Model.TreningZahtjev, object, TreningZahtjev, TreningZahtjevUpsertRequest, TreningZahtjevUpsertRequest>>();
            services.AddScoped<ICRUDService<Model.TreningDodatni, object, TreningDodatniUpsertRequest, TreningDodatniUpsertRequest>, BaseCRUDService<Model.TreningDodatni, object, TreningDodatni, TreningDodatniUpsertRequest, TreningDodatniUpsertRequest>>();

            
            services.AddScoped<ICRUDService<Model.Trening, object, TreningUpsertRequest, TreningUpsertRequest>, TreningService>();
            services.AddScoped<ITreningService, TreningService>();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
