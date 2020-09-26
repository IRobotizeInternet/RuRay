namespace RobotizeYoutubeLibrary.WebDrivers
{
    public class WebDriver
    {
        public static string BaseURL { get; set; }
        protected static string DriverLocation { get; set; } = ".";
        protected static int WebDriverTimeoutInSeconds { get; set; } = 200;
    }
}
