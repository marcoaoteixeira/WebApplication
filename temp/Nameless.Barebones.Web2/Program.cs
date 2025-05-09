using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.FluentUI.AspNetCore.Components;
using Nameless.Barebones.Aspire;
using Nameless.Barebones.Web.Configs;
using Nameless.Barebones.Web2.Components;
using Nameless.Barebones.Web2.Components.Account;
using Nameless.Barebones.Web2.Data;

namespace Nameless.Barebones.Web2;
public class Program {
    public static void Main(string[] args) {
        var builder = WebApplication.CreateBuilder(args);

        //// Add services to the container.
        //builder.Services.AddRazorComponents()
        //    .AddInteractiveServerComponents();
        //builder.Services.AddFluentUIComponents();

        //builder.Services.AddCascadingAuthenticationState();
        //builder.Services.AddScoped<IdentityUserAccessor>();
        //builder.Services.AddScoped<IdentityRedirectManager>();
        //builder.Services.AddScoped<AuthenticationStateProvider, IdentityRevalidatingAuthenticationStateProvider>();

        //builder.Services.AddAuthentication(options => {
        //    options.DefaultScheme = IdentityConstants.ApplicationScheme;
        //    options.DefaultSignInScheme = IdentityConstants.ExternalScheme;
        //})
        //    .AddIdentityCookies();

        //var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
        //builder.Services.AddDbContext<ApplicationDbContext>(options =>
        //    options.UseSqlite(connectionString));
        //builder.Services.AddDatabaseDeveloperPageExceptionFilter();

        //builder.Services.AddIdentityCore<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
        //    .AddEntityFrameworkStores<ApplicationDbContext>()
        //    .AddSignInManager()
        //    .AddDefaultTokenProviders();

        //builder.Services.AddSingleton<IEmailSender<ApplicationUser>, IdentityNoOpEmailSender>();

        //var app = builder.Build();

        //// Configure the HTTP request pipeline.
        //if (app.Environment.IsDevelopment()) {
        //    app.UseMigrationsEndPoint();
        //} else {
        //    app.UseExceptionHandler("/Error");
        //    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
        //    app.UseHsts();
        //}

        //app.UseHttpsRedirection();

        //app.UseAntiforgery();

        //app.MapStaticAssets();
        //app.MapRazorComponents<App>()
        //    .AddInteractiveServerRenderMode();

        //// Add additional endpoints required by the Identity /Account Razor components.
        //app.MapAdditionalIdentityEndpoints();

        //app.Run();

        builder.RegisterAspireServices();

        builder.Services
               .RegisterRazorServices()
               .RegisterIdentityServices()
               .RegisterDatabaseServices(builder.Configuration)
               .RegisterNotificationServices()
               .RegisterLocalizationServices()
               .RegisterNavigationServices()
               .RegisterFastEndpointsServices();

        builder.Build()
               .UseSecurityServices()
               .UseRazorServices()
               .UseFastEndpointsServices()
               .UseHealthCheckServices()
               .Run();
    }
}
