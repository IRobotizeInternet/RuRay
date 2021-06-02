namespace RuRay.API.Models
{
    /// <summary>
    /// Defines the <see cref="AppSettings" />.
    /// </summary>
    public class AppSettings
    {
        /// <summary>
        /// Gets or sets the AppPrefixPath.
        /// </summary>
        public string AppPrefixPath { get; set; }

        /// <summary>
        /// Gets or sets the JwtSecretKey.
        /// </summary>
        public string JwtSecretKey { get; set; }

        /// <summary>
        /// Gets or sets the WebApiUrl.
        /// </summary>
        public string WebApiUrl { get; set; }

        /// <summary>
        /// Gets or sets the AllowedOrigins.
        /// </summary>
        public string[] AllowedOrigins { get; set; }
    }
}
