using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ContactManager.Application.Abstractions;
using ContactManager.Application.Services;
using ContactManager.Infrastructure.Persistence;
using ContactManager.WinForms.UI.Features.Login.Forms;
using System.Diagnostics;

namespace ContactManagerTest
{
    internal static class Program
    {
        [STAThread] // zwingend für WinForms/OLE
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // optional: zur Kontrolle
            Debug.Assert(Thread.CurrentThread.GetApartmentState() == ApartmentState.STA, "Main-Thread ist nicht STA!");

            // DB path
            var dbPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "ContactManager",
                "contactmanager.sqlite");
            Directory.CreateDirectory(Path.GetDirectoryName(dbPath)!);

            var services = new ServiceCollection()
                // EF Core + SQLite (scoped! -> kein Singleton)
                .AddDbContext<ContactManagerDbContext>(opt =>
                {
                    opt.UseSqlite($"Data Source={dbPath}");
#if DEBUG
                    opt.EnableSensitiveDataLogging();
                    opt.EnableDetailedErrors();
#endif
                }, contextLifetime: ServiceLifetime.Scoped, optionsLifetime: ServiceLifetime.Scoped)

                // Repos/Services
                .AddScoped<IUserRepository, UserRepository>()
                .AddScoped<IAuthService, AuthService>()
                .AddScoped<ICustomerService, CustomerService>()
                .AddScoped<ICustomerRepository, CustomerRepository>()
                .AddScoped<ICustomerNoteService, CustomerNoteService>()
                .AddScoped<ICustomerNoteRepository, CustomerNoteRepository>()
                .AddScoped<IEmployeeService, EmployeeService>()
                .AddScoped<IEmployeeRepository, EmployeeRepository>()
                .AddScoped<IContactHistoryRepository, ContactHistoryRepository>()

                // Forms
                .AddScoped<FormMain>()
                .AddScoped<LoginForm>();

            var provider = services.BuildServiceProvider();

            // DB migrieren + Admin seeden (synchron auf STA-Thread)
            using (var scope = provider.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<ContactManagerDbContext>();
                db.Database.Migrate(); // sync

                var users = scope.ServiceProvider.GetRequiredService<IUserRepository>();
                var hasUsers = users.AnyAsync().GetAwaiter().GetResult();
                if (!hasUsers)
                {
                    var auth = scope.ServiceProvider.GetRequiredService<IAuthService>();
                    auth.CreateUserAsync("admin", "admin123", "Administrator").GetAwaiter().GetResult();
                }
            }

            // Login anzeigen und dann Hauptfenster starten (alles auf STA)
            using (var scope = provider.CreateScope())
            {
                var login = scope.ServiceProvider.GetRequiredService<LoginForm>();
                if (login.ShowDialog() != DialogResult.OK) return;

                var main = scope.ServiceProvider.GetRequiredService<FormMain>();
                Application.Run(main); // läuft auf dem STA-Hauptthread
            }
        }
    }
}
