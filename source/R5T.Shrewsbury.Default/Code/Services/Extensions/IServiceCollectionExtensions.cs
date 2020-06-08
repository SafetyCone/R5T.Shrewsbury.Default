using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;
using R5T.Ives;
using R5T.Lombardy;
using R5T.Macommania;


namespace R5T.Shrewsbury.Default
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ExecutableFileDirectoryAppSettingsDirectoryPathProvider"/> implementation of <see cref="IAppSettingsDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddExecutableFileDirectoryAppSettingsDirectoryPathProvider(this IServiceCollection services,
            IServiceAction<IExecutableFileDirectoryPathProvider> executableFileDirectoryPathProviderAction)
        {
            services
                .AddSingleton<IAppSettingsDirectoryPathProvider, ExecutableFileDirectoryAppSettingsDirectoryPathProvider>()
                .Run(executableFileDirectoryPathProviderAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ExecutableFileDirectoryAppSettingsDirectoryPathProvider"/> implementation of <see cref="IAppSettingsDirectoryPathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IAppSettingsDirectoryPathProvider> AddExecutableFileDirectoryAppSettingsDirectoryPathProvideAction(this IServiceCollection services,
            IServiceAction<IExecutableFileDirectoryPathProvider> executableFileDirectoryPathProviderAction)
        {
            var serviceAction = ServiceAction<IAppSettingsDirectoryPathProvider>.New(() => services.AddExecutableFileDirectoryAppSettingsDirectoryPathProvider(
               executableFileDirectoryPathProviderAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="DefaultAppSettingsJsonFileNameProvider"/> implementation of <see cref="IDefaultAppSettingsJsonFileNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultAppSettingsJsonFileNameProvider(this IServiceCollection services)
        {
            services.AddSingleton<IDefaultAppSettingsJsonFileNameProvider, DefaultAppSettingsJsonFileNameProvider>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DefaultAppSettingsJsonFileNameProvider"/> implementation of <see cref="IDefaultAppSettingsJsonFileNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDefaultAppSettingsJsonFileNameProvider> AddDefaultAppSettingsJsonFileNameProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<IDefaultAppSettingsJsonFileNameProvider>.New(() => services.AddDefaultAppSettingsJsonFileNameProvider());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="DefaultAppSettingsJsonFilePathProvider"/> implementation of <see cref="IDefaultAppSettingsJsonFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultAppSettingsJsonFilePathProvider(this IServiceCollection services,
            IServiceAction<IAppSettingsDirectoryPathProvider> appSettingsDirectoryPathProviderAction,
            IServiceAction<IDefaultAppSettingsJsonFileNameProvider> defaultAppSettingsJsonFileNameProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            services
                .AddSingleton<IDefaultAppSettingsJsonFilePathProvider, DefaultAppSettingsJsonFilePathProvider>()
                .Run(appSettingsDirectoryPathProviderAction)
                .Run(defaultAppSettingsJsonFileNameProviderAction)
                .Run(stringlyTypedPathOperatorAction)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="DefaultAppSettingsJsonFilePathProvider"/> implementation of <see cref="IDefaultAppSettingsJsonFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IDefaultAppSettingsJsonFilePathProvider> AddDefaultAppSettingsJsonFilePathProviderAction(this IServiceCollection services,
            IServiceAction<IAppSettingsDirectoryPathProvider> appSettingsDirectoryPathProviderAction,
            IServiceAction<IDefaultAppSettingsJsonFileNameProvider> defaultAppSettingsJsonFileNameProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperatorAction)
        {
            var serviceAction = ServiceAction<IDefaultAppSettingsJsonFilePathProvider>.New(() => services.AddDefaultAppSettingsJsonFilePathProvider(
                appSettingsDirectoryPathProviderAction,
                defaultAppSettingsJsonFileNameProviderAction,
                stringlyTypedPathOperatorAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="ConfigurationNameToAppSettingsFileNameTokenConverter"/> implementation of <see cref="IConfigurationNameToAppSettingsFileNameTokenConverter"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddDefaultConfigurationNameToAppSettingsFileNameTokenConverter(this IServiceCollection services)
        {
            services.AddSingleton<IConfigurationNameToAppSettingsFileNameTokenConverter, ConfigurationNameToAppSettingsFileNameTokenConverter>();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ConfigurationNameToAppSettingsFileNameTokenConverter"/> implementation of <see cref="IConfigurationNameToAppSettingsFileNameTokenConverter"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IConfigurationNameToAppSettingsFileNameTokenConverter> AddDefaultConfigurationNameToAppSettingsFileNameTokenConverterAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<IConfigurationNameToAppSettingsFileNameTokenConverter>.New(() => services.AddDefaultConfigurationNameToAppSettingsFileNameTokenConverter());
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="ConfigurationNameSpecificAppSettingsJsonFileNameProvider"/> implementation of <see cref="IConfigurationNameSpecificAppSettingsJsonFileNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddConfigurationNameSpecificAppSettingsJsonFileNameProvider(this IServiceCollection services, 
            IServiceAction<IConfigurationNameToAppSettingsFileNameTokenConverter> configurationNameToAppSettingsFileNameTokenConverterAction)
        {
            services
                .AddSingleton<IConfigurationNameSpecificAppSettingsJsonFileNameProvider, ConfigurationNameSpecificAppSettingsJsonFileNameProvider>()
                .Run(configurationNameToAppSettingsFileNameTokenConverterAction)
                ;

            return services;
        }
        /// <summary>
        /// Adds the <see cref="ConfigurationNameSpecificAppSettingsJsonFileNameProvider"/> implementation of <see cref="IConfigurationNameSpecificAppSettingsJsonFileNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IConfigurationNameSpecificAppSettingsJsonFileNameProvider> AddConfigurationNameSpecificAppSettingsJsonFileNameProviderAction(this IServiceCollection services,
            IServiceAction<IConfigurationNameToAppSettingsFileNameTokenConverter> configurationNameToAppSettingsFileNameTokenConverterAction)
        {
            var serviceAction = ServiceAction<IConfigurationNameSpecificAppSettingsJsonFileNameProvider>.New(() => services.AddConfigurationNameSpecificAppSettingsJsonFileNameProvider(
               configurationNameToAppSettingsFileNameTokenConverterAction));

            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="ConfigurationNameSpecificAppSettingsJsonFilePathProvider"/> implementation of <see cref="IConfigurationNameSpecificAppSettingsJsonFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddConfigurationNameSpecificAppSettingsJsonFilePathProvider(this IServiceCollection services,
            IServiceAction<IAppSettingsDirectoryPathProvider> appSettingsDirectoryPathProviderAction,
            IServiceAction<IConfigurationNameProvider> configurationNameProviderAction,
            IServiceAction<IConfigurationNameSpecificAppSettingsJsonFileNameProvider> configurationNameSpecificAppSettingsJsonFileNameProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperator)
        {
            services
                .AddSingleton<IConfigurationNameSpecificAppSettingsJsonFilePathProvider, ConfigurationNameSpecificAppSettingsJsonFilePathProvider>()
                .Run(appSettingsDirectoryPathProviderAction)
                .Run(configurationNameProviderAction)
                .Run(configurationNameSpecificAppSettingsJsonFileNameProviderAction)
                .Run(stringlyTypedPathOperator)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ConfigurationNameSpecificAppSettingsJsonFilePathProvider"/> implementation of <see cref="IConfigurationNameSpecificAppSettingsJsonFilePathProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceAction<IConfigurationNameSpecificAppSettingsJsonFilePathProvider> AddConfigurationNameSpecificAppSettingsJsonFilePathProviderAction(this IServiceCollection services,
            IServiceAction<IAppSettingsDirectoryPathProvider> appSettingsDirectoryPathProviderAction,
            IServiceAction<IConfigurationNameProvider> configurationNameProviderAction,
            IServiceAction<IConfigurationNameSpecificAppSettingsJsonFileNameProvider> configurationNameSpecificAppSettingsJsonFileNameProviderAction,
            IServiceAction<IStringlyTypedPathOperator> stringlyTypedPathOperator)
        {
            var serviceAction = ServiceAction<IConfigurationNameSpecificAppSettingsJsonFilePathProvider>.New(() => services.AddConfigurationNameSpecificAppSettingsJsonFilePathProvider(
               appSettingsDirectoryPathProviderAction,
               configurationNameProviderAction,
               configurationNameSpecificAppSettingsJsonFileNameProviderAction,
               stringlyTypedPathOperator));

            return serviceAction;
        }
    }
}
