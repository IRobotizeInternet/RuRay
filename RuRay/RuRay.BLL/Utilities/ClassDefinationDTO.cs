using System.Collections.Generic;
using Newtonsoft.Json;

namespace RuRayFacebook.Utilities
{
    /// <summary>
    /// Defines the <see cref="ClassDefinationDTO" />.
    /// </summary>
    public class ClassDefinationDTO
    {
        /// <summary>
        /// Gets or sets the NameSpace.
        /// </summary>
        public Defiantion NameSpace { get; set; }

        /// <summary>
        /// Gets or sets the Directives.
        /// </summary>
        [JsonProperty("Directives")]
        public IEnumerable<string> Directives { get; set; }

        /// <summary>
        /// Gets or sets the ClassDefination.
        /// </summary>
        public Defiantion ClassDefination { get; set; }

        /// <summary>
        /// Gets or sets the Methods.
        /// </summary>
        [JsonProperty("Methods")]
        public IEnumerable<MethodDefination> Methods { get; set; }

        /// <summary>
        /// Gets or sets the Properties.
        /// </summary>
        [JsonProperty("Properties")]
        public IEnumerable<Defiantion> Properties { get; set; }
    }

    /// <summary>
    /// Defines the <see cref="MethodDefination" />.
    /// </summary>
    public class MethodDefination : Defiantion
    {
        /// <summary>
        /// Gets or sets the ReturnType.
        /// </summary>
        public string ReturnType { get; set; }
    }

    /// <summary>
    /// Defines the <see cref="Parameter" />.
    /// </summary>
    public class Parameter
    {
    }

    /// <summary>
    /// Defines the <see cref="Defiantion" />.
    /// </summary>
    public class Defiantion
    {
        /// <summary>
        /// Gets or sets the Name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Defines the Comments.
        /// </summary>
        public IEnumerable<string> Comments;
    }
}
