using System;

using R5T.Lombardy;using R5T.T0064;


namespace R5T.Shrewsbury.Default
{[ServiceImplementationMarker]
    public class AppSettingsFilePathProvider : IAppSettingsFilePathProvider,IServiceImplementation
    {
        private IAppSettingsDirectoryPathProvider AppSettingsDirectoryPathProvider { get; }
        private IStringlyTypedPathOperator StringlyTypedPathOperator { get; }


        public AppSettingsFilePathProvider(IAppSettingsDirectoryPathProvider appSettingsDirectoryPathProvider, IStringlyTypedPathOperator stringlyTypedPathOperator)
        {
            this.AppSettingsDirectoryPathProvider = appSettingsDirectoryPathProvider;
            this.StringlyTypedPathOperator = stringlyTypedPathOperator;
        }

        public string GetAppSettingsFilePath(string appSettingsFileName)
        {
            var appSettingsDirectoryPath = this.AppSettingsDirectoryPathProvider.GetAppSettingsDirectoryPath();

            var appSettingsFilePath = this.StringlyTypedPathOperator.GetFilePath(appSettingsDirectoryPath, appSettingsFileName);
            return appSettingsFilePath;
        }
    }
}
