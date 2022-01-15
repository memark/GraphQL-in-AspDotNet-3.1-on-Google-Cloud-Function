using Google.Cloud.Functions.Hosting;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace MyApi
{
    public class Startup : FunctionsStartup
    {
        public override void ConfigureServices(WebHostBuilderContext context, IServiceCollection services)
        {
            services
                .AddGraphQLServer()
                .AddQueryType<Query>();
        }

        public override void Configure(WebHostBuilderContext context, IApplicationBuilder app)
        {
            app
                .UseRouting()
                .UseEndpoints(endpoints => endpoints.MapGraphQL("/graphql"));
        }
    }
}
