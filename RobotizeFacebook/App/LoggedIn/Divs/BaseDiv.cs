using System;

namespace RobotizeFacebook.App.LoggedIn.Pages
{
    public class BaseDiv : BaseDriver
    {
        public virtual string BaseXPath { get; set; }
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
