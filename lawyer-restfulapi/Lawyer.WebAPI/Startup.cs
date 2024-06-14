using System.Text;
using System.Threading.Tasks;
using Lawyer.Repository;
using Lawyer.Repository.BaseRepository;
using Lawyer.Repository.LawyerOfficeRepository;
using Lawyer.Repository.LawyerRepository;
using Lawyer.Repository.UnitOfWork;
using Lawyer.Repository.UserRepository;
using Lawyer.Service.LawyerOfficeService;
using Lawyer.Service.UserService;
using Lawyer.WebAPI.Configurations;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace Lawyer.WebAPI
{
    public class Startup
    {
        private readonly IWebHostEnvironment _env;

        private readonly IConfiguration _configuration;

        public Startup(IWebHostEnvironment env, IConfiguration configuration)
        {
            _env = env;
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var appSettingsSection = _configuration.GetSection("ApplicationSettings");

            services.Configure<ApplicationSettings>(appSettingsSection);

            services.AddDbContext<ApplicationContext>(options => options.UseSqlServer(_configuration.GetConnectionString("IdentityConnection")));

            services.AddCors();

            services.AddControllers();

            AddAuthentication(services, appSettingsSection);

            AddDependencyInjectionServices(services);
        }

        private static void AddDependencyInjectionServices(IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

            services.AddScoped(typeof(IUnitOfWork<>), typeof(UnitOfWork<>));

            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<IUserService, UserService>();

            services.AddScoped<ILawyerOfficeRepository, LawyerOfficeRepository>();

            services.AddScoped<ILawyerOfficeService, LawyerOfficeService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {

            var appSettings = _configuration.GetSection("ApplicationSettings").Get<ApplicationSettings>();

            loggerFactory.AddFile(appSettings.LogFilePath);

            app.UseRouting();

            // global cors policy
            app.UseCors(x => x
                .AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod()
            );

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints => endpoints.MapControllers());
        }

        private static void AddAuthentication(IServiceCollection services, IConfigurationSection appSettingsSection)
        {
            var appSettings = appSettingsSection.Get<ApplicationSettings>();

            var key = Encoding.UTF8.GetBytes(appSettings.JWT_secret);

            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.Events = new JwtBearerEvents
                {
                    OnTokenValidated = context =>
                    {
                        IUserService userService = context.HttpContext.RequestServices.GetRequiredService<IUserService>();
                        var userId = int.Parse(context.Principal.Identity.Name);
                        var user = userService.Get(userId);
                        if (user == null)
                        {
                            // return unauthorized if user no longer exists
                            context.Fail("Unauthorized");
                        }
                        return Task.CompletedTask;
                    }
                };
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false,
                };
            });
        }
    }
}
