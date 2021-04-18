using System;
using System.IO;
using RobotizeFacebook.Utilities;

namespace RobotizeFacebook.Services
{
    public class EnvironmentSettings
    {
        public static string DirectoryPath =>
            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), AppSettings.RobotizeDataDirectory);
        
        private string _fileNameWithPath { get; set; }
        public EnvironmentSettings(string fileName) 
        {
            fileName = fileName ?? AppSettings.EnvironmentSettingsFile;
            _fileNameWithPath = Path.Combine(DirectoryPath, fileName);

            if (Directory.Exists(DirectoryPath) == false) Directory.CreateDirectory(DirectoryPath);
        }

        public EnvironmentSettingsDTO Details
        {
            get => FileOperations.Deserialize<EnvironmentSettingsDTO>(_fileNameWithPath);
            set => FileOperations.Serialize(_fileNameWithPath, value);
        }

        public static EnvironmentSettings SettingsData(string fileName = null) => new EnvironmentSettings(fileName);
    }


}
