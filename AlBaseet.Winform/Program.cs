using AlBaseet.Core.Services;
using AlBaseet.Core;
using System.Configuration;
using AlBaseet.Winform.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using AlBaseet.Core.Repositories;


namespace AlBaseet.Winform;

static class Program
{
    [STAThread]
    static void Main()
    {
        var Host = CreateHostBuilder().Build();
        var serviceProvider = Host.Services;

        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var loginForm = serviceProvider.GetRequiredService<LoginForm>();
        Application.Run(loginForm);
    }
    public static IServiceProvider ServiceProvider { get; private set; }
    private static IHostBuilder CreateHostBuilder() => Host.CreateDefaultBuilder()
        .ConfigureServices((context, services) =>
        {
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Mr.Robot\source\repos\AlBaseet\AlBaseet.Core\Database\AlBaseetDB.mdf;Integrated Security=SSPI"));
            services.AddTransient<ILoginService, LoginService>();
            services.AddTransient<LoginForm>();
            services.AddTransient<IUserRepository, UserRepository>();

        });
    
}