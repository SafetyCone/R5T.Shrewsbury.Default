using System;using R5T.T0064;


namespace R5T.Shrewsbury.Default
{[ServiceImplementationMarker]
    public class DefaultAppSettingsJsonFileNameProvider : IDefaultAppSettingsJsonFileNameProvider,IServiceImplementation
    {
        public string GetDefaultAppSettingsJsonFileName()
        {
            var appSettingsJsonFileName = FileNames.DefaultAppSettingsJsonFileName;
            return appSettingsJsonFileName;
        }
    }
}
