using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using RobotizeFacebook.Pages.LoggedIn;
using System.Collections.Generic;
using System.IO;

namespace RobotizeFacebook.Pages.LoggedUser
{
    public class PageHome : PageBase
    {
        public PageHome(RemoteWebDriver driver, WebDriverWait wait)
        {
        }

        public PageHome()
        {

        }

        public override string PageUrl => "https://www.facebook.com/marketplace/111906762160356/garden";
        public HomePageHeaderSection HeaderSection => new HomePageHeaderSection(Driver, Wait);
        public MainSection MainSection => new MainSection(Driver, Wait);

        public void GenerateAllElements()
        {
            var rootFolderPath = @"D:\Dev\Robotize\RobotizeFacebook\Pages\LoggedIn\Components\Grid\Family\FamilyFilter\";
            var fileBaseName = "Family";
            var xPath = "//a[@href='/marketplace/111906762160356/garden/']//span[text()='Garden & Outdoor']/../../../../../../../../../..//span[contains(@class,'fjf4s8hc')]";
            foreach (var element in Driver.FindElements(By.XPath(xPath)))
            {
                var destPath = $@"D:\Dev\Robotize\RobotizeFacebook\Pages\LoggedIn\Components\Grid\GardenAndOutdoor\{element.Text}Filter";

                Directory.CreateDirectory(destPath);
                foreach (var file in Directory.GetFiles(rootFolderPath))
                {
                    var newFileName = element.Text.Replace("&", "And");
                    newFileName = newFileName.Replace("'", "");
                    newFileName = newFileName.Replace(" ", "");

                    var destFile = Path.Combine(destPath, newFileName);
                    File.Copy(file, destFile, true);
                    var text = File.ReadAllText(destFile);
                    text.Replace(fileBaseName, newFileName);
                    File.WriteAllText(destFile, text);
                }
            }
        }
    }
}
