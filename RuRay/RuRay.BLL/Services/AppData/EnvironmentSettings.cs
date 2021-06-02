using System;
using System.IO;
using RuRayFacebook.Utilities;

namespace RuRayFacebook.Services
{
    /// <summary>
    /// Defines the <see cref="EnvironmentSettings" />.
    /// </summary>
    public class EnvironmentSettings
    {
        /// <summary>
        /// Gets the DirectoryPath.
        /// </summary>
        public static string DirectoryPath =>
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), AppSettings.RuRayDataDirectory);

        /// <summary>
        /// Gets or sets the _fileNameWithPath.
        /// </summary>
        private string _fileNameWithPath { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentSettings"/> class.
        /// </summary>
        /// <param name="fileName">The fileName<see cref="string"/>.</param>
        public EnvironmentSettings(string fileName)
        {
            fileName = fileName ?? AppSettings.EnvironmentSettingsFile;
            _fileNameWithPath = Path.Combine(DirectoryPath, fileName);

            if (Directory.Exists(DirectoryPath) == false)
            {
                Directory.CreateDirectory(DirectoryPath);
            }
        }

        /// <summary>
        /// Gets or sets the Details.
        /// </summary>
        public EnvironmentSettingsDTO Details { get => FileOperations.Deserialize<EnvironmentSettingsDTO>(_fileNameWithPath); set => FileOperations.Serialize(_fileNameWithPath, value); }

        /// <summary>
        /// The SettingsData.
        /// </summary>
        /// <param name="fileName">The fileName<see cref="string"/>.</param>
        /// <returns>The <see cref="EnvironmentSettings"/>.</returns>
        public static EnvironmentSettings SettingsData(string fileName = null) => new EnvironmentSettings(fileName);
    }
}
