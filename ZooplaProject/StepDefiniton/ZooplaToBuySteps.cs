using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using ZooplaProject.Helper;
using ZooplaProject.Pages;

namespace ZooplaProject.StepDefiniton 
{
    [Binding]
    public sealed class ZooplaToBuySteps : BaseClass
    {
        HomePage homePage = new HomePage();
        ResultPage resultPage = new ResultPage();

        [Given(@"I am on Zoopla homepage")]
        public void GivenIAmOnZooplaHomepage()
        {
            homePage.IsHomepageDisplayed();
        }

        [When(@"I enter ""(.*)"" into search feild")]
        public void WhenIEnterIntoSearchFeild(string destination)
        {
            homePage.EnteraAnItemToSearchBar(destination);
        }

        [When(@"I select ""(.*)"" as minimum price")]
        public void WhenISelectAsMinimumPrice(string miniprice)
        {
            homePage.EnterMinimumPrice(miniprice);
        }

        [When(@"I select ""(.*)"" as maximum price")]
        public void WhenISelectAsMaximumPrice(string maxprice)
        {
            homePage.EnterMaxPrice(maxprice);
        }

        [When(@"I select ""(.*)"" from the property type")]
        public void WhenISelectFromThePropertyType(string building)
        {
           homePage.SelectPropertyType(building);
        }

        [When(@"I select ""(.*)"" as number room")]
        public void WhenISelectAsNumberRoom(string rooms)
        {
           homePage.SelectBedroom(rooms); 
        }

        [When(@"I click on search button")]
        public void WhenIClickOnSearchButton()
        {
            resultPage = homePage.ClickOnButton();
        }

        [Then(@"the result of the ""(.*)"" is displayed")]
        public void ThenTheResultOfTheIsDisplayed(string p0)
        {
            
        }

    }
}
