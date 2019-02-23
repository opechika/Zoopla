using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using ZooplaProject.Helper;

namespace ZooplaProject.StepDefiniton 
{
    [Binding]
    public sealed class ZooplaToBuySteps : BaseClass
    {
        [Given(@"I am on Zoopla homepage")]
        public void GivenIAmOnZooplaHomepage()
        {
            
        }

        [When(@"I enter ""(.*)"" into search feild")]
        public void WhenIEnterIntoSearchFeild(string p0)
        {
            
        }

        [When(@"I select ""(.*)"" as minimum price")]
        public void WhenISelectAsMinimumPrice(string p0)
        {
            
        }

        [When(@"I select ""(.*)"" as maximum price")]
        public void WhenISelectAsMaximumPrice(string p0)
        {
            
        }

        [When(@"I select ""(.*)"" from the property type")]
        public void WhenISelectFromThePropertyType(string p0)
        {
           
        }

        [When(@"I select ""(.*)"" as number room")]
        public void WhenISelectAsNumberRoom(string p0)
        {
            
        }

        [When(@"I click on search button")]
        public void WhenIClickOnSearchButton()
        {
            
        }

        [Then(@"the result of the ""(.*)"" is displayed")]
        public void ThenTheResultOfTheIsDisplayed(string p0)
        {
            
        }

    }
}
