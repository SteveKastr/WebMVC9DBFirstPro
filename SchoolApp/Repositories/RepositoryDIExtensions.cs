namespace SchoolApp.Repositories
{
    public static class RepositoryDIExtensions
    {
        public static IServiceCollection AddRepositories(this IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork> ();
            return services;
        }
    }
}
