using System;


namespace R5T.Shrewsbury.Default
{
    public class DefaultAppSettingsJsonFileNameProvider : IDefaultAppSettingsJsonFileNameProvider
    {
        public string GetDefaultAppSettingsJsonFileName()
        {
            var appSettingsJsonFileName = FileNames.DefaultAppSettingsJsonFileName;
            return appSettingsJsonFileName;
        }
    }
}
