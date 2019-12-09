using System;


namespace R5T.Shrewsbury.Default
{
    /// <summary>
    /// Assumes the the configuration name IS the appsettings file-name token.
    /// </summary>
    public class DefaultConfigurationNameToAppSettingsFileNameTokenConverter : IConfigurationNameToAppSettingsFileNameTokenConverter
    {
        public string ConvertConfigurationNameToAppSettingsFileNameToken(string configurationName)
        {
            string appSettingsFileNameToken = configurationName;
            return appSettingsFileNameToken;
        }
    }
}
