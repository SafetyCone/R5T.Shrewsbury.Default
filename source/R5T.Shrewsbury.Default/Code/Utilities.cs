using System;

using R5T.Cherusci;


namespace R5T.Shrewsbury.Default
{
    public static class Utilities
    {
        public static string GetConfigurationNameSpecificAppSettingsJsonFileName(string baseAppsettingsFileNameWithoutExtension, string configurationNameAppsettingsFileNameToken)
        {
            var appSettingsJsonFileName = $"{baseAppsettingsFileNameWithoutExtension}.{configurationNameAppsettingsFileNameToken}.{FileExtensions.Json}";
            return appSettingsJsonFileName;
        }

        public static string GetConfigurationNameSpecificAppSettingsJsonFileName(string configurationNameAppsettingsFileNameToken)
        {
            var appsSettingsJsonFileName = Utilities.GetConfigurationNameSpecificAppSettingsJsonFileName(Constants.DefaultBaseAppSettingsFileNameWithoutExtension, configurationNameAppsettingsFileNameToken);
            return appsSettingsJsonFileName;
        }
    }
}
