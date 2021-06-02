using System;

namespace RuRayFacebook.App.LoggedIn.Pages
{
    /// <summary>
    /// Defines the <see cref="BaseDiv" />.
    /// </summary>
    public class BaseDiv : BaseDriver
    {
        /// <summary>
        /// Gets or sets the BaseXPath.
        /// </summary>
        public virtual string BaseXPath { get; set; }

        /// <summary>
        /// The RunConformance.
        /// </summary>
        public override void RunConformance()
        {
            throw new NotImplementedException();
        }
    }
}
