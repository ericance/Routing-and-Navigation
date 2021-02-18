using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace RoutingAndNavigation
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddControllersWithViews();
		}

		public void Configure(IApplicationBuilder app)
		{
			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseRouting();

			app.UseEndpoints(endpoints =>
			{
				/* 
				 * This is taken from the book because setting up routing
				 * with the navigation bar is a nightmare.
				 * 
				 * I really hope we go over navigation bars and admin because
				 * at the moment I am not sure how to do either of those
				 * topics.
				 */
				endpoints.MapAreaControllerRoute(
					name: "admin",
					areaName: "Admin",
					pattern: "Admin/{controller=Home}/{action=Index}/{id?}");

				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller=Home}/{action=Index}/{id?}");
			});
		}
	}
}
