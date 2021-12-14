using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using business_logic.Model;
using business_logic.Data;
using business_logic.Model.Mediator;
using business_logic.Model.UserPack;
using business_logic.Model.PetPack;
using business_logic.Model.MessagePack;
using business_logic.Model.RequestPack;
using Entities;

namespace business_logic
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

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "business_logic", Version = "v1" });
            });
            //services.AddSingleton<IPetsData ,PetsData>();
            services.AddSingleton<IModel,Model.Model>();
            //services.AddSingleton<ITier2Mediator, Tier2>();
            services.AddSingleton<ITier2Singleton, Tier2>();

            services.AddSingleton<ITier2User, Tier2User>();
            services.AddSingleton<ITier2Status, Tier2Status>();
            services.AddSingleton<ITier2Pets, Tier2Pets>();
            services.AddSingleton<ITier2Country, Tier2Country>();
            services.AddSingleton<ITier2City, Tier2City>();
            services.AddSingleton<ITier2Message,Tier2Message>();

            services.AddSingleton<IUserManager,UserManager>();
            services.AddSingleton<IPetManager, PetManager>();
            services.AddSingleton<IRequestManager<Request,string>>((thing) => {
                return new RequestManager<Request,string>(
                (request)=> {return request.petId;},(request)=> {return request.userEmail;});
            });
            services.AddSingleton<IMessageManager, MessageController>();
            services.AddSingleton<IEmailHandler, EmailHandler>();

            //services.AddSingleton<ITier2Mediator>((service) => {return Tier2.getInstance();});
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "business_logic v1"));
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
