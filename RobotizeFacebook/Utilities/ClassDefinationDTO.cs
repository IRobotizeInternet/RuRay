using Newtonsoft.Json;
using System.Collections.Generic;

namespace RobotizeFacebook.Utilities
{
    public class ClassDefinationDTO
    {
        public Defiantion NameSpace { get; set; }

        [JsonProperty("Directives")]
        public IEnumerable<string> Directives { get; set; }
        public Defiantion ClassDefination { get; set; }

        [JsonProperty("Methods")]
        public IEnumerable<MethodDefination> Methods { get; set; }

        [JsonProperty("Properties")]
        public IEnumerable<Defiantion> Properties { get; set; }
    }

    public class MethodDefination : Defiantion
    {
        public string ReturnType { get; set; }
    }

    public class Parameter 
    {

    }

    public class Defiantion
    {
        public string Name { get; set; }
        public IEnumerable<string> Comments;
    }
}
