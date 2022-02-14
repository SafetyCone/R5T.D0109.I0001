using System;

using R5T.D0109.I001;
using R5T.T0062;
using R5T.T0063;


namespace R5T.D0109.I0001
{
    public static class IServiceActionExtensions
    {
        /// <summary>
        /// Adds the <see cref="HardCodedExtensionMethodBaseExtensionRepositoryFilePathsProvider"/> implementation of <see cref="IExtensionMethodBaseExtensionRepositoryFilePathsProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IExtensionMethodBaseExtensionRepositoryFilePathsProvider> AddHardCodedExtensionMethodBaseExtensionRepositoryFilePathsProviderAction(this IServiceAction _)
        {
            var serviceAction = _.New<IExtensionMethodBaseExtensionRepositoryFilePathsProvider>(services => services.AddHardCodedExtensionMethodBaseExtensionRepositoryFilePathsProvider());
            return serviceAction;
        }
    }
}
