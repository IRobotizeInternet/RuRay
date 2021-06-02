using OpenQA.Selenium.Remote;

namespace RuRayFacebook.App.LoggedIn
{
    /// <summary>
    /// Defines the <see cref="BabyClothingFilter" />.
    /// </summary>
    public class BabyClothingFilter : BaseFilter, IBabyClothingFilter, IBabyClothingFilterOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BabyClothingFilter"/> class.
        /// </summary>
        /// <param name="driver">The driver<see cref="RemoteWebDriver"/>.</param>
        public BabyClothingFilter(RemoteWebDriver driver) : base(driver)
        {
        }

        /// <summary>
        /// Gets the FilterBy.
        /// </summary>
        public IBabyClothingFilterOptions FilterBy => throw new System.NotImplementedException();

        /// <summary>
        /// The BabyAndToddlerSize.
        /// </summary>
        /// <param name="bodyStyle">The bodyStyle<see cref="BabyAndToddlerSize"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        public IApplyFilter BabyAndToddlerSize(BabyAndToddlerSize bodyStyle)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// The ItemCondition.
        /// </summary>
        /// <param name="condition">The condition<see cref="ItemCondition"/>.</param>
        /// <returns>The <see cref="IFilterOptions"/>.</returns>
        public IFilterOptions ItemCondition(ItemCondition condition)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// The Price.
        /// </summary>
        /// <param name="min">The min<see cref="double?"/>.</param>
        /// <param name="max">The max<see cref="double?"/>.</param>
        /// <returns>The <see cref="IApplyFilter"/>.</returns>
        public IApplyFilter Price(double? min = null, double? max = null)
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// The ClickFilterButton.
        /// </summary>
        protected override void ClickFilterButton()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        /// The SetFilterCriteria.
        /// </summary>
        protected override void SetFilterCriteria()
        {
            throw new System.NotImplementedException();
        }
    }
}
