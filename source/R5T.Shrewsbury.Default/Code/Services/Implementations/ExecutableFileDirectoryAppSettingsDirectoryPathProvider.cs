using System;

using R5T.Macommania;


namespace R5T.Shrewsbury.Default
{
    /// <summary>
    /// Assumes that appsettings files are in the same directory as the executable.
    /// </summary>
    public class ExecutableFileDirectoryAppSettingsDirectoryPathProvider : IAppSettingsDirectoryPathProvider
    {
        private IExecutableFileDirectoryPathProvider ExecutableFileDirectoryPathProvider { get; set; }


        public ExecutableFileDirectoryAppSettingsDirectoryPathProvider(IExecutableFileDirectoryPathProvider executableFileDirectoryPathProvider)
        {
            this.ExecutableFileDirectoryPathProvider = executableFileDirectoryPathProvider;
        }

        public string GetAppSettingsDirectoryPath()
        {
            var executableFileDirectoryPath = this.ExecutableFileDirectoryPathProvider.GetExecutableFileDirectoryPath();

            // Assume appsettings files are in the same directory as the executable.
            var appSettingsDirectoryPath = executableFileDirectoryPath;

            return appSettingsDirectoryPath;
        }
    }
}
