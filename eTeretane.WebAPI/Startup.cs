using System.Collections.Generic;
using AutoMapper;
using eTeretane.Model.Requests;
using eTeretane.WebAPI.Database;
using eTeretane.WebAPI.EF;
using eTeretane.WebAPI.Security;
using eTeretane.WebAPI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
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
                c.AddSecurityDefinition("basicAuth", new OpenApiSecurityScheme()
                {
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    Description = "Input your username and password to access this API",
                    In = ParameterLocation.Header,
                });

                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference {
                                Type = ReferenceType.SecurityScheme,
                                Id = "basicAuth" }
                        }, new List<string>() }
                });
            });

            services.AddAuthentication("BasicAuthentication")
                .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddDbContext<eTeretaneContext>();


            services.AddScoped<IKorisniciService, KorisniciService>();
            services.AddScoped<IKorisnickiNalogService, KorisnickiNalogService>();
            services.AddScoped<IClanService, ClanService>();
            services.AddScoped<IClanarina, ClanarinaService>();
            services.AddScoped<IPlacanjeClanarine, PlacanjeClanarineService>();

            services.AddScoped<IService<Model.Uloge, object>, BaseService<Model.Uloge, object, Uloga>>();
            services.AddScoped<IService<Model.TipClanarine, object>, BaseService<Model.TipClanarine, object, TipClanarine>>();

            services.AddScoped<ICRUDService<Model.Grad, object, GradUpsetRequest, GradUpsetRequest>, BaseCRUDService<Model.Grad, object, Grad, GradUpsetRequest, GradUpsetRequest>>();
            services.AddScoped<ICRUDService<Model.Teretane, TeretanaSearchRequest, TeretanaUpsertRequest, TeretanaUpsertRequest>, TeretanaService>();
            services.AddScoped<ICRUDService<Model.Licenca, object, LicencaUpsertRequest, LicencaUpsertRequest>, BaseCRUDService<Model.Licenca, object, Licenca, LicencaUpsertRequest, LicencaUpsertRequest>>();
            services.AddScoped<ICRUDService<Model.KuponPopusti, KuponSearchRequest, KuponUpsertRequest, KuponUpsertRequest>, KuponService>();
            services.AddScoped<ICRUDService<Model.TreningDetalji, TreningDetaljiSearchRequest, TreningDetaljiUpsertRequest, TreningDetaljiUpsertRequest>, TreningDetaljiService>();

            services.AddScoped<ICRUDService<Model.TreningZahtjev, TreningZahtjevSearchRequest, TreningZahtjevUpsertRequest, TreningZahtjevUpsertRequest>, TreningZahtjevService>();
            services.AddScoped<ICRUDService<Model.TreningDodatni, TreningDodatniSearchRequest, TreningDodatniUpsertRequest, TreningDodatniUpsertRequest>, TreningDodatniService>();

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
            app.UseRouting();
            app.UseAuthorization();
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
