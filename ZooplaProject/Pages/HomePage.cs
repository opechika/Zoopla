using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using ZooplaProject.Helper;
using ZooplaProject.Pages;

namespace ZooplaProject
{
    public class HomePage : BaseClass
    {
        private IWebElement logo;
        private IWebElement searchbar;
        private IWebElement price;
        private IWebElement maprice;
        private IWebElement property;
        private IWebElement bedroom;
        private IWebElement submit;

        public void IsHomepageDisplayed()
        {
            logo = GetElementByCssSelector(".icon--logo");
            Assert.True(logo.Displayed);
        }

        public void EnteraAnItemToSearchBar(string item)
        {
            searchbar = GetElementByCssSelector(".search-input-location-placeholder-1");
            searchbar.SendKeys(item);
        }

        public void EnterMinimumPrice(string miniprice)
        {
            price = GetElementById("forsale_price_min");
            SelectByText(price, miniprice);
           
        }

        public void EnterMaxPrice(string maxiprice)
        {
            maprice = GetElementById("forsale_price_max");
            SelectByText(maprice, maxiprice);
        }

        public void SelectPropertyType(string prop)
        {
            property = GetElementById("property_type");
            SelectByText(property, prop);
        }

        public void SelectBedroom(string broom)
        {
            bedroom = GetElementById("beds_min");
            SelectByText(bedroom, broom);
        }

        public ResultPage ClickOnButton()
        {
            submit = GetElementById("search-submit");
            submit.Click();
            return new ResultPage();
        }
    }
}
