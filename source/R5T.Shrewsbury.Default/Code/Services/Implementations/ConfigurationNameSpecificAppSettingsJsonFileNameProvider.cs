using System;


namespace R5T.Shrewsbury.Default
{
    public class ConfigurationNameSpecificAppSettingsJsonFileNameProvider : IConfigurationNameSpecificAppSettingsJsonFileNameProvider
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
