using SpecFlowProject3.Page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecFlowProject3.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        //private Interactions _interactions;

        [Scope(Tag = "Tempcover")]
        [BeforeScenario("Tempcover")]
        public async Task BeforeScenario(TempcoverHomePage tempcoverHomePage)
        {
            //await _interactions.GoToUrl("https://www.tempcover.com");
            await tempcoverHomePage.GoToURL();

        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            // Example of ordering the execution of hooks
            // See https://docs.specflow.org/projects/specflow/en/latest/Bindings/Hooks.html?highlight=order#hook-execution-order

            //TODO: implement logic that has to run before executing each scenario
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
