using System;
using TechTalk.SpecFlow;

namespace AppDocumentation.FeatureSteps
{
    [Binding]
    public class AdoptingPuppiesSteps
    {
        [Given(@"I am on the puppy adoption site")]
        public void GivenIAmOnThePuppyAdoptionSite()
        {
            
        }
        
        [When(@"I complete the adoption of a puppy")]
        public void WhenICompleteTheAdoptionOfAPuppy()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see ""(.*)""")]
        public void ThenIShouldSee(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
