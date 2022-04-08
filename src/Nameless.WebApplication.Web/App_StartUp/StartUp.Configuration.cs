namespace Nameless.WebApplication.Web {

    public partial class StartUp {

        #region Public Methods

        public void ConfigureConfiguration(IServiceCollection services) {
            //var fileSystemStorageOptions = Configuration
            //    .GetSection(nameof(FileSystemStorageOptions))
            //    .Get<FileSystemStorageOptions>() ?? new FileSystemStorageOptions {
            //        Root = typeof(StartUp).Assembly.GetDirectoryPath()
            //    };
            //services.ConfigureOptions(Configuration, () => fileSystemStorageOptions);

            //var localizationOptions = Configuration
            //    .GetSection(nameof(LocalizationOptions))
            //    .Get<LocalizationOptions>() ?? new();
            //services.ConfigureOptions(Configuration, () => localizationOptions);

            //var loggingOptions = Configuration
            //    .GetSection(nameof(LoggingOptions))
            //    .Get<LoggingOptions>() ?? new();
            //services.ConfigureOptions(Configuration, () => loggingOptions);

            //var nhibernateOptions = Configuration
            //    .GetSection(nameof(NHibernateOptions))
            //    .Get<NHibernateOptions>() ?? new();
            //services.ConfigureOptions(Configuration, () => nhibernateOptions);
        }

        #endregion
    }
}
