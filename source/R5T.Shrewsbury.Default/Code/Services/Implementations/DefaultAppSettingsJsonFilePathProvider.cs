using System;

using R5T.Lombardy;using R5T.T0064;


namespace R5T.Shrewsbury.Default
{[ServiceImplementationMarker]
    public class DefaultAppSettingsJsonFilePathProvider : IDefaultAppSettingsJsonFilePathProvider,IServiceImplementation
    {
        private IAppSettingsDirectoryPathProvider AppSettingsDirectoryPathProvider { get; }
        private IDefaultAppSettingsJsonFileNameProvider DefaultAppSettingsJsonFileNameProvider { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public DefaultAppSettingsJsonFilePathProvider(
            IAppSettingsDirectoryPathProvider appSettingsDirectoryPathProvider,
            IDefaultAppSettingsJsonFileNameProvider defaultAppSettingsJsonFileNameProvider,
            IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.AppSettingsDirectoryPathProvider = appSettingsDirectoryPathProvider;
            this.DefaultAppSettingsJsonFileNameProvider = defaultAppSettingsJsonFileNameProvider;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public string GetDefaultAppSettingsJsonFilePath()
        {
            var appSettingsDirectoryPath = this.AppSettingsDirectoryPathProvider.GetAppSettingsDirectoryPath();
            var defaultAppSettingsJsonFileName = this.DefaultAppSettingsJsonFileNameProvider.GetDefaultAppSettingsJsonFileName();

            var defaultAppSettingsJsonFilePath = this.StringlyTypedPathOperator.GetFilePath(appSettingsDirectoryPath, defaultAppSettingsJsonFileName);
            return defaultAppSettingsJsonFilePath;
        }
    }
}
