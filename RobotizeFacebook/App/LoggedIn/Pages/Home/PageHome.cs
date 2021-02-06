using OpenQA.Selenium;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class PageHome : BasePage
    {
        public PageHome()
        {
            
        }

        public override string PageUrl => "/";
        public Header Header => new Header();
        public MenuItemsHome MenuItems => new MenuItemsHome();
        public FeedHome MainSection => new FeedHome();

        public override By ByForPage => throw new System.NotImplementedException();

        public override void RunConformance()
        {
                   
        }

        //public void GenerateAllElements()
        //{
        //    Driver.FindElementByXPath("//span[text()='Marketplace']").Click();
        //    Thread.Sleep(3000);
        //    Driver.FindElementByXPath("//span[text()='Garden & Outdoor']").Click();
        //    var rootFolderPath = @"D:\Dev\Robotize\RobotizeFacebook\Pages\LoggedIn\Components\Grid\Family\FamilyFilter\";
        //    var fileBaseName = "Family";
        //    var xPath = "//a[@href='/marketplace/111906762160356/toys/']//span[text()='Toys & Games']/../../../../../../../../../..//span[contains(@class,'fjf4s8hc')]";
        //    foreach (var element in Driver.FindElements(By.XPath(xPath)))
        //    {
        //        var destPath = $@"D:\Dev\Robotize\RobotizeFacebook\Pages\LoggedIn\Components\Grid\ToysAndGames\";
        //        var newDirName = element.Text.Replace("&", "And");
        //        newDirName = newDirName.Replace("'", "");
        //        newDirName = newDirName.Replace(" ", "");
        //        var newDir = $"{destPath}{newDirName}";
        //        Directory.CreateDirectory(newDir);
        //        foreach (var file in Directory.GetFiles(rootFolderPath))
        //        {
        //            var fi = Path.GetFileName(file).Replace(fileBaseName, newDirName);
        //            var destFile = Path.Combine(newDir, fi);
        //            File.Copy(file, destFile, true);
        //            var text = File.ReadAllText(destFile);
        //            File.WriteAllText(destFile, text.Replace(fileBaseName, newDirName));
        //        }
        //    }
        //}
    }
}
