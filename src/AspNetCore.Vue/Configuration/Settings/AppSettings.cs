namespace Nyami.AspNetCore.VueApp.Configuration.Settings
{
    /// <summary>
    /// Typed object for application settings, this can be injected using IOptions<AppSettings> or IOptionsSnapshot<AppSettings>
    /// </summary>
    public class AppSettings
    {
        /// <summary>
        /// Gets and sets an example setting
        /// </summary>
        public string ExampleSetting { get; set; }

        /// <summary>
        /// Gets and sets the connection strings for the application
        /// </summary>
        public ConnectionStrings ConnectionStrings { get; set; }
    }
}