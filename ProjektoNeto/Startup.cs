using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ProjektoNeto.Models;
using System;
using System.Threading.Tasks;

namespace ProjektoNeto
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AppDbContext>();
            services.AddTransient<ISamochodRepository, SamochodRepository>();
            services.AddTransient<IOpiniaRepository, OpiniaRepository>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IServiceProvider serviceProvider)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });

            CreateRolesAndAdminUser(serviceProvider);
        }

        private static void CreateRolesAndAdminUser(IServiceProvider serviceProvider)
        {
            const string adminRoleName = "Administrator";
            
            CreateRole(serviceProvider, adminRoleName);

            AddUserToRole(serviceProvider, adminRoleName);
        }

        private static void CreateRole(IServiceProvider serviceProvider, string roleName)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            Task<bool> roleExists = roleManager.RoleExistsAsync(roleName);
            roleExists.Wait();

            if (!roleExists.Result)
            {
                Task<IdentityResult> roleResult = roleManager.CreateAsync(new IdentityRole(roleName));
                roleResult.Wait();
            }
        }

        private static void AddUserToRole(IServiceProvider serviceProvider, string adminRoleName)
        {
            var userManager = serviceProvider.GetRequiredService<UserManager<IdentityUser>>();
            var checkAppUser = userManager.FindByEmailAsync("admin@o2.pl");
            checkAppUser.Wait();

            var appUser = checkAppUser.Result;

            if (checkAppUser.Result == null)
            {
                var newAppUser = new IdentityUser
                {
                    Email = "admin@o2.pl",
                    UserName = "admin@o2.pl"
                };

                var taskCreateAppUser = userManager.CreateAsync(newAppUser, "123$qweR");
                taskCreateAppUser.Wait();

                if (taskCreateAppUser.Result.Succeeded)
                {
                    appUser = newAppUser;
                }
            }
            var newUserRole = userManager.AddToRoleAsync(appUser, adminRoleName);
            newUserRole.Wait();
        }
    }
}
