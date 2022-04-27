using System;

using R5T.Ives;
using R5T.Lombardy;using R5T.T0064;


namespace R5T.Shrewsbury.Default
{[ServiceImplementationMarker]
    public class ConfigurationNameSpecificAppSettingsJsonFilePathProvider : IConfigurationNameSpecificAppSettingsJsonFilePathProvider,IServiceImplementation
    {
        private IAppSettingsDirectoryPathProvider AppSettingsDirectoryPathProvider { get; }
        private IConfigurationNameProvider ConfigurationNameProvider { get; }
        private IConfigurationNameSpecificAppSettingsJsonFileNameProvider ConfigurationNameSpecificAppSettingsJsonFileNameProvider { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public ConfigurationNameSpecificAppSettingsJsonFilePathProvider(
            IAppSettingsDirectoryPathProvider appSettingsDirectoryPathProvider,
            IConfigurationNameProvider configurationNameProvider,
            IConfigurationNameSpecificAppSettingsJsonFileNameProvider configurationNameSpecificAppSettingsJsonFileNameProvider,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.AppSettingsDirectoryPathProvider = appSettingsDirectoryPathProvider;
            this.ConfigurationNameProvider = configurationNameProvider;
            this.ConfigurationNameSpecificAppSettingsJsonFileNameProvider = configurationNameSpecificAppSettingsJsonFileNameProvider;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public string GetConfigurationNameSpecificAppSettingsJsonFilePath()
        {
            var appSettingsDirectoryPath = this.AppSettingsDirectoryPathProvider.GetAppSettingsDirectoryPath();
            var configurationName = this.ConfigurationNameProvider.GetConfigurationName();
            var configurationNameSpecificAppSettingsJsonFileName = this.ConfigurationNameSpecificAppSettingsJsonFileNameProvider.GetConfigurationNameSpecificAppSettingsJsonFileName(configurationName);

            var configurationNameSpecificAppSettingsJsonFilePath = this.StringlyTypedPathOperator.GetFilePath(appSettingsDirectoryPath, configurationNameSpecificAppSettingsJsonFileName);
            return configurationNameSpecificAppSettingsJsonFilePath;
        }
    }
}
