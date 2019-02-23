using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using ZooplaProject.Helper;

namespace ZooplaProject
{
    [Binding]
    public sealed class ZooplaHooks :BaseClass
    {
        

        [BeforeScenario]
        public void BeforeScenario()
        {
           LaunchBrowser("Chrome"); 
           LaunchUrl("https://www.zoopla.co.uk/");
        }

        [AfterScenario]
        public void AfterScenario()
        {
           CloseBrowser(); 
        }
    }
}
