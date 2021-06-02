using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace RuRayFacebook.Services
{
    /// <summary>
    /// Defines the <see cref="ServiceCulture" />.
    /// </summary>
    public static class ServiceCulture
    {
        /// <summary>
        /// The SetDefaultCulture.
        /// </summary>
        /// <param name="defaultCulture">The defaultCulture<see cref="string"/>.</param>
        /// <returns>The <see cref="CultureInfo"/>.</returns>
        public static CultureInfo SetDefaultCulture(string defaultCulture)
        {
            try
            {
                var currentCulture = Thread.CurrentThread.CurrentCulture;

                if (string.IsNullOrEmpty(defaultCulture))
                {
                    Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                }
                else
                {
                    Thread.CurrentThread.CurrentCulture = GetCulture(defaultCulture);
                }

                Debug.WriteLine($"The current culture changed from {currentCulture} To :{Thread.CurrentThread.CurrentCulture}");
                return Thread.CurrentThread.CurrentCulture;
            }
            catch (CultureNotFoundException ex)
            {
                throw new CultureNotFoundException($"Exception thrown while setting culutre: {defaultCulture}: {ex.Message}");
            }
        }

        /// <summary>
        /// The GetCulture.
        /// </summary>
        /// <param name="newCulture">The newCulture<see cref="string"/>.</param>
        /// <returns>The <see cref="CultureInfo"/>.</returns>
        private static CultureInfo GetCulture(string newCulture)
        {
            // Get culture info based on the EnglishName.
            return CultureInfo.GetCultures(CultureTypes.AllCultures)
                 .Single(x => x.EnglishName == newCulture);
        }
    }
}
