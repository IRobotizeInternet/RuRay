using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace RobotizeLibrary.CustomAttributes
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
