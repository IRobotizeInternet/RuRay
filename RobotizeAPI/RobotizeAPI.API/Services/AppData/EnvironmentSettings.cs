using System;
using System.IO;
using RobotizeFacebook.Utilities;

namespace RobotizeFacebook.Services
{
    public class EnvironmentSettings
    {
        private string _directoryPath { get; set; }
        private string _fileNameWithPath { get; set; }
        public EnvironmentSettings() 
        {
            _directoryPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), AppSettings.RobotizeDataDirectory);
            _fileNameWithPath = Path.Combine(_directoryPath, AppSettings.EnvironmentSettingsFile);

            if (Directory.Exists(_directoryPath) == false) Directory.CreateDirectory(_directoryPath);
        }

        public EnvironmentSettingsDTO Details
        {
            get => FileOperations.Deserialize<EnvironmentSettingsDTO>(_fileNameWithPath);
            set => FileOperations.Serialize(_fileNameWithPath, value);
        }

        public static EnvironmentSettings SettingsData => new EnvironmentSettings();
    }
}
