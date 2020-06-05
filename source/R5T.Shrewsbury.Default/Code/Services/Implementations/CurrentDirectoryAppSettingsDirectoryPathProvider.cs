using System;


namespace R5T.Shrewsbury.Default
{
    public class CurrentDirectoryAppSettingsDirectoryPathProvider : IAppSettingsDirectoryPathProvider
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
