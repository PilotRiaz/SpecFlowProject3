using SpecFlowProject3.Page;
using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowProject3.Steps
{
    [Binding]
    public class TempcoverHomePageSteps
    {
        private TempcoverHomePage tempcoverHomePage;

        public TempcoverHomePageSteps(TempcoverHomePage tempcoverhomePage)
        {
            tempcoverHomePage = tempcoverhomePage;
        }

        [Given(@"I navigate to Tempcover website")]
        public async Task GivenINavigateToTempcoverWebsite()
        {
            await tempcoverHomePage.GoToURL();
        }
        
        [Then(@"I can see the HomePage")]
        public async Task ThenICanSeeTheHomePage()
        {
            await tempcoverHomePage.VerifyHomePageTitle();
        }
    }
}
