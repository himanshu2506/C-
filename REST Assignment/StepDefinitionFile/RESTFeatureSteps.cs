using System;
using NUnit.Framework;
using REST_Assignment.Logic;
using TechTalk.SpecFlow;

namespace REST_Assignment.StepDefinitionFile
{
    [Binding]
    public class RESTFeatureSteps
    {
        logic obj = new logic();
        [When(@"user sends a request")]
        public void WhenUserSendsARequest()
        {
            obj.invoke();
            obj.Post_request();
        }

        [When(@"Register a  User with '(.*)'  and '(.*)'")]
        public void WhenRegisterAUserWithAnd(string p, string pp)
        {
            
            obj.Register(p, pp);
        }

        [When(@"Register a new user with '(.*)' and '(.*)'")]
        public void WhenRegisterANewUserWithAnd(string p0, string p1)
        {
            
            obj.Register(p0, p1);
        }

        [When(@"user sends a request on users")]
        public void WhenUserSendsARequestOnUsers()
        {

            obj.invoke();
            obj.Get_request();
        }

        [Then(@"Registration is successful")]
        public void ThenRegistrationIsSuccessful()
        {
            Assert.IsTrue(obj.Valid());
        }

        [Then(@"Token is generated")]
        public void ThenTokenIsGenerated()
        {
            Assert.IsTrue(obj.Valid());
        }

        [Then(@"Registration is not successful")]
        public void ThenRegistrationIsNotSuccessful()
        {
            Assert.IsFalse(obj.Valid());
        }

        [Then(@"Token is not generated")]
        public void ThenTokenIsNotGenerated()
        {
            Assert.IsFalse(obj.Valid());
        }

        [Then(@"user will get list of users")]
        public void ThenUserWillGetListOfUsers()
        {
            obj.UserList();
        }
    }
}

