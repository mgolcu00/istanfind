using istanfind.Data;
using istanfind.Models;
using istanfind.Resources;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace istanfind
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
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDefaultIdentity<User>(options => options.SignIn.RequireConfirmedAccount = true)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();
            services.AddControllersWithViews();
            services.AddRazorPages();

            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = false;
                options.Password.RequireLowercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = false;

                options.Password.RequiredLength = 2;

                //options.Lockout.AllowedForNewUsers = false;

            });


            services.AddSingleton<LocService>();
            services.AddLocalization(opts => { opts.ResourcesPath = "Resources"; });

            services.AddMvc()
                .AddViewLocalization(
                    LanguageViewLocationExpanderFormat.Suffix,
                    opts => { opts.ResourcesPath = "Resources"; })
                .AddDataAnnotationsLocalization();

            services.Configure<RequestLocalizationOptions>(
       opts =>
       {
           var supportedCultures = new List<CultureInfo>
           {
                new CultureInfo("en-US"),
                new CultureInfo("tr-TR")
           };

           opts.DefaultRequestCulture = new RequestCulture("tr-TR");
           // Formatting numbers, dates, etc.
           opts.SupportedCultures = supportedCultures;
           // UI strings that we have localized.
           opts.SupportedUICultures = supportedCultures;
       });
        }



        //---------------------------------ROLE-----------------------------------------------------------------------


        private static async Task EnsureRolesAsync(RoleManager<IdentityRole> roleManager)
        {
            var alreadyExists = await roleManager.RoleExistsAsync(Constants.AdministratorRole);

            if (alreadyExists) return;

            await roleManager.CreateAsync(new IdentityRole(Constants.AdministratorRole));
        }

        private static async Task EnsureTestAdminAsync(UserManager<User> userManager)
        {
            var testAdmin = await userManager.Users
                .Where(x => x.UserName == "g181210110@sakarya.edu.tr")
                .SingleOrDefaultAsync();

            if (testAdmin != null)
            {
                await userManager.AddToRoleAsync(testAdmin, Constants.AdministratorRole);
                return;
            }
            else
            {

            }
            //buralar de?i?ecek
            testAdmin = new User { Ad = "Admin", Soyad = "Web", UserName = "g181210110@sakarya.edu.tr", Email = "g181210110@sakarya.edu.tr" };
            await userManager.CreateAsync(testAdmin, "123");
            var token = await userManager.GenerateEmailConfirmationTokenAsync(testAdmin);
            await userManager.ConfirmEmailAsync(testAdmin, token);
            await userManager.AddToRoleAsync(testAdmin, Constants.AdministratorRole);
        }


        //---------------------------------ROLE-----------------------------------------------------------------------

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();

                EnsureRolesAsync(roleManager).Wait();
                EnsureTestAdminAsync(userManager).Wait();


            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            // localization
            var options = app.ApplicationServices.GetService<IOptions<RequestLocalizationOptions>>();
            app.UseRequestLocalization(options.Value);

            // localization
            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });

        }
    }
}
