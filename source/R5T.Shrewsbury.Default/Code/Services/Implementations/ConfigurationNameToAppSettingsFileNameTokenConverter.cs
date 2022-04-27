using System;

using R5T.T0064;


namespace R5T.Shrewsbury.Default
{
    /// <summary>
    /// Assumes the the configuration name IS the appsettings file-name token.
    /// </summary>
    [ServiceImplementationMarker]
    public class ConfigurationNameToAppSettingsFileNameTokenConverter : IConfigurationNameToAppSettingsFileNameTokenConverter, IServiceImplementation
    {
        public string ConvertConfigurationNameToAppSettingsFileNameToken(string configurationName)
        {
            string appSettingsFileNameToken = configurationName;
            return appSettingsFileNameToken;
        }
    }
}
