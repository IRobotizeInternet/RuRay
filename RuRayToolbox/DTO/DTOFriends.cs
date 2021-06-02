using System.Collections.Generic;
using OpenQA.Selenium;

namespace RuRayLibrary.DTO
{
    /// <summary>
    /// Defines the <see cref="DTOFriends" />.
    /// </summary>
    public class DTOFriends
    {
        /// <summary>
        /// Gets or sets the FirendsElementList.
        /// </summary>
        public IEnumerable<IWebElement> FirendsElementList { get; set; }
    }
}
