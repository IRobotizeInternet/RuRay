namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class Header
    {
        public HeaderRightMenu RightMenu { get; }
        public HeaderMiddleMenu MiddleMenu { get; }
        public HeaderLeftMenu LeftMenu { get; }

        public Header()
        {
            RightMenu = new HeaderRightMenu();
            MiddleMenu = new HeaderMiddleMenu();
            LeftMenu = new HeaderLeftMenu();
        }

        public void Get()
        {

        }
    }
}
