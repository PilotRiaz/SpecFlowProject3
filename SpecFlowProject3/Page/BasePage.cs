using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;
using SpecFlow.Actions.Playwright;


namespace SpecFlowProject3.Page
{
    public class BasePage
    {
        public readonly Task<IPage> _page;

        public BasePage(BrowserDriver browserDriver)
        {
            _page = CreatePageAsync(browserDriver.Current);
        }

        private async Task<IPage> CreatePageAsync(Task<IBrowser> browser)
        {
            return await (await browser).NewPageAsync();
        }
    }
}