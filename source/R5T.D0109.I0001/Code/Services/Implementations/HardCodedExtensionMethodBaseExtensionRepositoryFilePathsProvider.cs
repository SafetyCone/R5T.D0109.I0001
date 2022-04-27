using System;
using System.Threading.Tasks;

using R5T.D0109.I001;using R5T.T0064;


namespace R5T.D0109.I0001
{[ServiceImplementationMarker]
    public class HardCodedExtensionMethodBaseExtensionRepositoryFilePathsProvider : IExtensionMethodBaseExtensionRepositoryFilePathsProvider,IServiceImplementation
    {
        public Task<string> GetDuplicateExtensionMethodBaseExtensionNamesTextFilePath()
        {
            var output = @"C:\Temp\Extension Method Base Extensions-Duplicate Name Selections.txt";

            return Task.FromResult(output);
        }

        public Task<string> GetExtensionMethodBaseExtensionSelectionsTextFilePath()
        {
            var output = @"C:\Temp\Extension Method Base Extensions-Selected.txt";

            return Task.FromResult(output);
        }

        public Task<string> GetExtensionMethodBaseExtensionsListingJsonFilePath()
        {
            var output = @"C:\Temp\Extension Method Base Extensions-All.json";

            return Task.FromResult(output);
        }

        public Task<string> GetIgnoredExtensionMethodBaseNamesTextFilePath()
        {
            var output = @"C:\Temp\Extension Method Base Extensions-Ignored Names.txt";

            return Task.FromResult(output);
        }

        public Task<string> GetToExtensionMethodBaseMappingsJsonFilePath()
        {
            var output = @"C:\Temp\Extension Method Base Extensions-To Extension Method Base Mappings.json";

            return Task.FromResult(output);
        }

        public Task<string> GetToProjectMappingsJsonFilePath()
        {
            var output = @"C:\Temp\Extension Method Base Extensions-To Project Mappings.json";

            return Task.FromResult(output);
        }
    }
}
