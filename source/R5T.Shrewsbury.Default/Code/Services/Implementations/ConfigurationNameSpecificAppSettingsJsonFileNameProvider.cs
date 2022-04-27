using System;using R5T.T0064;


namespace R5T.Shrewsbury.Default
{[ServiceImplementationMarker]
    public class ConfigurationNameSpecificAppSettingsJsonFileNameProvider : IConfigurationNameSpecificAppSettingsJsonFileNameProvider,IServiceImplementation
    {
        private IConfigurationNameToAppSettingsFileNameTokenConverter ConfigurationNameToAppSettingsFileNameTokenConverter { get; }


        public ConfigurationNameSpecificAppSettingsJsonFileNameProvider(IConfigurationNameToAppSettingsFileNameTokenConverter configurationNameToAppSettingsFileNameTokenConverter)
        {
            this.ConfigurationNameToAppSettingsFileNameTokenConverter = configurationNameToAppSettingsFileNameTokenConverter;
        }

        public string GetConfigurationNameSpecificAppSettingsJsonFileName(string configurationName)
        {
            var appSettingsFileNameToken = this.ConfigurationNameToAppSettingsFileNameTokenConverter.ConvertConfigurationNameToAppSettingsFileNameToken(configurationName);

            var appSettingsFileName = Utilities.GetConfigurationNameSpecificAppSettingsJsonFileName(appSettingsFileNameToken);
            return appSettingsFileName;
        }
    }
}
