using System;
using System.ComponentModel;
using System.Resources;

namespace RuRayToolbox.CustomAttributes
{
    /// <summary>
    /// Defines the <see cref="LocalizedDescriptionAttribute" />.
    /// </summary>
    public class LocalizedDescriptionAttribute : DescriptionAttribute
    {
        /// <summary>
        /// Defines the _localizedResourceKey.
        /// </summary>
        private readonly string _localizedResourceKey;

        /// <summary>
        /// Defines the _resource.
        /// </summary>
        private readonly ResourceManager _resource;

        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizedDescriptionAttribute"/> class.
        /// </summary>
        /// <param name="resourceKey">The resourceKey<see cref="string"/>.</param>
        /// <param name="resourceType">The resourceType<see cref="Type"/>.</param>
        public LocalizedDescriptionAttribute(string resourceKey, Type resourceType)
        {
            _localizedResourceKey = resourceKey;
            _resource = new ResourceManager(resourceType);
        }

        /// <summary>
        /// Gets the Description.
        /// </summary>
        public override string Description =>
                 string.IsNullOrEmpty(_resource.GetString(_localizedResourceKey))
                    ? string.Format("[[{0}]]", _localizedResourceKey)
                    : _resource.GetString(_localizedResourceKey);
    }
}
