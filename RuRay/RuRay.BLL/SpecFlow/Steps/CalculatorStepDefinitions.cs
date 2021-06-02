using TechTalk.SpecFlow;

namespace SpecFlowProject1.Steps
{
    /// <summary>
    /// Defines the <see cref="CalculatorStepDefinitions" />.
    /// </summary>
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        /// <summary>
        /// Defines the _scenarioContext.
        /// </summary>
        private readonly ScenarioContext _scenarioContext;

        /// <summary>
        /// Initializes a new instance of the <see cref="CalculatorStepDefinitions"/> class.
        /// </summary>
        /// <param name="scenarioContext">The scenarioContext<see cref="ScenarioContext"/>.</param>
        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        //[Given("the first number is (.*)")]
        //public void GivenTheFirstNumberIs(int number)
        //{
        //    //TODO: implement arrange (precondition) logic
        //    // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
        //    // To use the multiline text or the table argument of the scenario,
        //    // additional string/Table parameters can be defined on the step definition
        //    // method. 

        //    _scenarioContext.Pending();
        //}
        /// <summary>
        /// The GivenTheSecondNumberIs.
        /// </summary>
        /// <param name="number">The number<see cref="int"/>.</param>
        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            _scenarioContext.Pending();
        }

        /// <summary>
        /// The WhenTheTwoNumbersAreAdded.
        /// </summary>
        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

            _scenarioContext.Pending();
        }

        /// <summary>
        /// The ThenTheResultShouldBe.
        /// </summary>
        /// <param name="result">The result<see cref="int"/>.</param>
        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            _scenarioContext.Pending();
        }
    }
}
