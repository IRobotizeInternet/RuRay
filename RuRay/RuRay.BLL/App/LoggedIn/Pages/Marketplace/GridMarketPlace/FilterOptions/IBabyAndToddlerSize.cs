using System;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="IBabyAndToddlerSize{TBabyAndToddlerSize}" />.
    /// </summary>
    /// <typeparam name="TBabyAndToddlerSize">.</typeparam>
    public interface IBabyAndToddlerSize<TBabyAndToddlerSize> where TBabyAndToddlerSize : struct, IConvertible
    {
        /// <summary>
        /// The BabyAndToddlerSize.
        /// </summary>
        /// <param name="bodyStyle">The bodyStyle<see cref="TBabyAndToddlerSize"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        IApplyFilter BabyAndToddlerSize(TBabyAndToddlerSize bodyStyle);
    }
}
