using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using FluentAssertions.Execution;
using Microsoft.VisualBasic;
using SpecFlow.Actions.Playwright;

namespace SpecFlowProject3.Page
{
    public class TempcoverHomePage : BasePage
    {
        private static string TempcoverUrl = "https://www.tempcover.com";
        private Interactions _interactions;

        private static string PageTitleH1Heading => "xpath=//section[@id='MainCTA']//h1";

        private static string CookieConsentButton => "#CookieConsentButton";

        private static string temporaryVanInsuranceQuote => "ProductTileVan";

        public TempcoverHomePage(BrowserDriver browserDriver) : base(browserDriver)
        {
            _interactions = new Interactions(_page);
        }

        public async Task VerifyHomePageTitle()
        {
            using (new AssertionScope())
            {
                PageTitleH1Heading.Should().Contain("Quick & Easy Temporary Car Insurance");
                //PageTitleH1Heading.Text.Should().Contain("Quick & Easy Temporary Car Insurance");
                //Assert.IsTrue(PageTitleH1Heading.Text.Contains("Quick & Easy Temporary Car Insurance"));
            }
        }

        public async Task ClickCookieConsent()
        {
            _interactions.ClickAsync(CookieConsentButton);
            //CookieConsentButton.Click();
        }

        public async Task ClickTemporaryVanInsurancePage()
        {
            _interactions.ClickAsync(temporaryVanInsuranceQuote);
            //temporaryVanInsuranceQuote.Click();
        }

        public async Task GoToURL()
        {
            await _interactions.GoToUrl("https://www.tempcover.com");
        }
    }
}