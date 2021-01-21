using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace RobotizeFacebook.Services
{
    public static class ServiceCulture
    {
        public static CultureInfo SetDefaultCulture(string defaultCulture)
        {
            try
            {
                var currentCulture = Thread.CurrentThread.CurrentCulture;

                if (string.IsNullOrEmpty(defaultCulture)) Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                else Thread.CurrentThread.CurrentCulture = GetCulture(defaultCulture);

                Debug.WriteLine($"The current culture changed from {currentCulture} To :{Thread.CurrentThread.CurrentCulture}");
                return Thread.CurrentThread.CurrentCulture;
            }
            catch(CultureNotFoundException ex)
            {
                throw new CultureNotFoundException($"Exception thrown while setting culutre: {defaultCulture}: {ex.Message}");
            }
        }

        private static CultureInfo GetCulture(string newCulture)
        {
            // Get culture info based on the EnglishName.
           return CultureInfo.GetCultures(CultureTypes.AllCultures)
                .Single(x => x.EnglishName == newCulture);
        }
    }
}
