using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.D0109.I001;
using R5T.T0063;


namespace R5T.D0109.I0001
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="HardCodedExtensionMethodBaseExtensionRepositoryFilePathsProvider"/> implementation of <see cref="IExtensionMethodBaseExtensionRepositoryFilePathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddHardCodedExtensionMethodBaseExtensionRepositoryFilePathsProvider(this IServiceCollection services)
        {
            services.AddSingleton<IExtensionMethodBaseExtensionRepositoryFilePathsProvider, HardCodedExtensionMethodBaseExtensionRepositoryFilePathsProvider>();

            return services;
        }
    }
}
