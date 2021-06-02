using System;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="DivVideoChatHomeUnit" />.
    /// </summary>
    public class DivVideoChatHomeUnit : BaseDriver
    {
        /// <summary>
        /// Defines the BaseXPath.
        /// </summary>
        public string BaseXPath = "//div[@data-pagelet='VideoChatHomeUnit']";

        /// <summary>
        /// Initializes a new instance of the <see cref="DivVideoChatHomeUnit"/> class.
        /// </summary>
        public DivVideoChatHomeUnit()
        {
        }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
