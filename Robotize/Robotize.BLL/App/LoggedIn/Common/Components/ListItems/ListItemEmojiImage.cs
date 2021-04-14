using OpenQA.Selenium;
using Robotize.BLL.Resources;
using RobotizeToolbox.CommonControls;
using RobotizeToolbox.Components;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class ListItemEmojiImage : BaseDiv, IListItem
    {
        public Button ButtonRecentlyUsedEmoji => 
            new Button(Driver, By.XPath($"//div[@class='uiScrollableAreaContent']/div/div/div/h3[text()='{ResHomePage.RecentlyUsed}']/following-sibling::div/div/span[{XIndex}]"));

        public Button ButtonRecentlySmileysAndPeople =>
           new Button(Driver, By.XPath($"//div[@class='uiScrollableAreaContent']/div/div/div/h3[text()='{ResHomePage.SmileysAndPeople}']/following-sibling::div/div[{XIndex}]//span[{YIndex}]"));
        
        public ListItemEmojiImage(
            string baseXPath, 
            int xIndex = 1,
            int yIndex = 1)
        {
            XIndex = xIndex;
            YIndex = yIndex;
            BaseXPath = baseXPath;
        }

        public int XIndex { get; set; }
        public int YIndex { get; set; }
    }
}
