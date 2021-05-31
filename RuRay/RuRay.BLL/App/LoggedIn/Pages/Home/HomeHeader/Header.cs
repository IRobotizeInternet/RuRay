using RuRayLibrary.Components.Eidtor;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    public class Header : IHeaderNavigation
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
