namespace ChatApplication.API.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options => options.AddPolicy("default", policy =>
            {
                policy.AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials();
            }));
        }
        public static void ConfigureAuthentication(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddAuthentication();
            services.AddAuthorization();
        }

        public static void ConfigureSwagger(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

        }
    }
}
