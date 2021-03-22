using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
