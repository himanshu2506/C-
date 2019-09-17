using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using WebPageTestSearch.BusinessLogic;

namespace WebPageTestSearch.StepDefinitionFile
{
     [Binding]
    public class SearchSteps
    {
        Logic call =new Logic();
        [When(@"user launch the browser")]
        public void WhenUserLaunchTheBrowser()
        {
            call.invoke();
        }
        
        [When(@"User is on HomePage")]
        public void WhenUserIsOnHomePage()
        {
            call.open();
        }
        
        [Then(@"user select flight")]
        public void ThenUserSelectFlight()
        {
            call.selectFlight();
        }
        
        [Then(@"select multi city")]
        public void ThenSelectMultiCity()
        {
            call.selectMultiCity();
        }
        
        [Then(@"add another flight")]
        public void ThenAddAnotherFlight()
        {
            call.AddAnotherFlight();
        }
        
        [Then(@"Search for flights between different airport (.*),(.*),(.*) on dates (.*),(.*),(.*)  for (.*)  adults")]
        public void ThenSearchForFlightsBetweenDifferentAirportOnDatesForAdults(string p0, string p1, string p2, string p3, string p4, string p5, string p6)
        {
            call.fillData(p0, p1, p2, p3, p4, p5, p6);
        }
        
        [Then(@"click on search option")]
        public void ThenClickOnSearchOption()
        {
            call.selectSearch();
        }
        
        [Then(@"select the flight")]
        public void ThenSelectTheFlight()
        {
            call.select();
            call.close();
        }
    }
}
