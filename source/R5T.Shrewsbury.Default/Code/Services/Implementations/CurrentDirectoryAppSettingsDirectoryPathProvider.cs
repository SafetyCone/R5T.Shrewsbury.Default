using System;using R5T.T0064;


namespace R5T.Shrewsbury.Default
{[ServiceImplementationMarker]
    public class CurrentDirectoryAppSettingsDirectoryPathProvider : IAppSettingsDirectoryPathProvider,IServiceImplementation
    {
        public string GetAppSettingsDirectoryPath()
        {
            //// For testing in EF tools.
            //Console.WriteLine("HERE!!!");
            //Console.WriteLine($"Current directory:\n{Environment.CurrentDirectory}");
            //Console.WriteLine($"Command-line args:\n{Environment.GetCommandLineArgs()[0]}");
            //Console.WriteLine($"EntryAssembly:\n{System.Reflection.Assembly.GetEntryAssembly().Location}");

            var currentDirectory = Environment.CurrentDirectory;

            return currentDirectory;
        }
    }
}
