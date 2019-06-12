using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;

namespace Nyami.AspNetCore.VueApp.Configuration.Startup
{
    public static partial class ConfigurationExtensions
    {
        public static IApplicationBuilder ConfigureExceptions(this IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");

            }

            return app;
        }
    }
}