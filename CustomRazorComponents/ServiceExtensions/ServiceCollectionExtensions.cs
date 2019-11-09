using CustomRazorComponents.Localization;

namespace Microsoft.Extensions.DependencyInjection
{
    /// <summary>
    /// Class that contains the Telerik service extensions.
    /// </summary>
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCustomRazorComponents(this IServiceCollection services)
        {
            services.AddSingleton<ICustomLocalizer, CustomLocalizer>();

            return services;
        }
    }
}