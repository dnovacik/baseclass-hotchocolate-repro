using BaseClassRepro.Mutation;
using BaseClassRepro.Query;
using BaseClassRepro.Types.Output.Block;
using BaseClassRepro.Types.Output.Section;
using HotChocolate.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BaseClassRepro
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddGraphQLServer()
                .InitializeOnStartup()
                .AddQueryType<QueryType>()
                .AddMutationType<MutationType>()
                .ModifyOptions(options =>
                {
                    options.EnableOneOf = true;
                    options.DefaultBindingBehavior = BindingBehavior.Explicit;
                });

            services.AddHttpResultSerializer<HttpSerializerExtension>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapGraphQL();

                endpoints.MapGet("/", async context =>
                {
                    await context.Response.WriteAsync("Hello World!");
                });
            });
        }
    }
}
