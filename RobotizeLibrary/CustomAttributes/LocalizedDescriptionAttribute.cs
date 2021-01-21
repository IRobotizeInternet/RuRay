using System;
using System.ComponentModel;
using System.Resources;

namespace RobotizeToolbox.CustomAttributes
{
    public class LocalizedDescriptionAttribute : DescriptionAttribute
    {
        private readonly string _localizedResourceKey;
        private readonly ResourceManager _resource;

        public LocalizedDescriptionAttribute(string resourceKey, Type resourceType)
        {
            _localizedResourceKey = resourceKey;
            _resource = new ResourceManager(resourceType);
        }

        public override string Description =>
                 string.IsNullOrEmpty(_resource.GetString(_localizedResourceKey))
                    ? string.Format("[[{0}]]", _localizedResourceKey)
                    : _resource.GetString(_localizedResourceKey);
    }
}
