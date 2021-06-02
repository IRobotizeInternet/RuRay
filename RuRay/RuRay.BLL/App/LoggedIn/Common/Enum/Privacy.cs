using RuRay.BLL.Resources;
using RuRayToolbox.CustomAttributes;

namespace RuRayFacebook.App.LoggedIn.Enum
{
    /// <summary>
    /// Defines the Privacy.
    /// </summary>
    public enum Privacy
    {
        /// <summary>
        /// Defines the Private.
        /// </summary>
        [LocalizedDescription(nameof(ResMiscellaneous.Private), typeof(ResMiscellaneous))] Private = 0,

        /// <summary>
        /// Defines the Public.
        /// </summary>
        [LocalizedDescription(nameof(ResMiscellaneous.Public), typeof(ResMiscellaneous))] Public = 1,

        /// <summary>
        /// Defines the Friends.
        /// </summary>
        [LocalizedDescription(nameof(ResMiscellaneous.Friends), typeof(ResMiscellaneous))] Friends = 2,

        /// <summary>
        /// Defines the Group.
        /// </summary>
        [LocalizedDescription(nameof(ResMiscellaneous.Group), typeof(ResMiscellaneous))] Group = 3,

    }
}
