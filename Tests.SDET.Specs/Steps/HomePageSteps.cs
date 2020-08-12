using Microsoft.AspNetCore.TestHost;
using System;
using System.Net.Http;
using Microsoft.AspNetCore.Hosting;
using TechTalk.SpecFlow;
using Xunit;
using Microsoft.AspNetCore.Mvc.Testing;

namespace Tests.SDET.Specs.Steps
{
    [Binding]
    public class HomePageSteps: IClassFixture<WebApplicationFactory<Tests.SDET.Startup>>, IDisposable
    {
        private readonly WebApplicationFactory<Tests.SDET.Startup> _factory;
        private readonly ScenarioContext _scenarioContext;

        public HomePageSteps(WebApplicationFactory<Tests.SDET.Startup> factory, ScenarioContext scenarioContext)
        {
            _factory = factory;
            _scenarioContext = scenarioContext;
        }

        [Given(@"I am a normal user")]
        public void GivenIAmANormalUser()
        {
            // Arrange
            var client = _factory.CreateClient();
            _scenarioContext["client"] = client;
        }
        
        [When(@"I visit the home page")]
        public void WhenIVisitTheHomePage()
        {
            // Act
            var response = ((HttpClient)_scenarioContext["client"]).GetAsync("/").Result;
            _scenarioContext["response"] = response;
        }
        
        [Then(@"there is a link to facebook\.com")]
        public void ThereIsALinkToFacebook_Com()
        {
            Assert.Contains("www.facebook.com", ((HttpResponseMessage)_scenarioContext["response"]).Content.ReadAsStringAsync().Result);
        }

        [Then(@"there is a link to twitter\.com")]
        public void ThenThereIsALinkToTwitter_Com()
        {
            Assert.Contains("www.twitter.com", ((HttpResponseMessage)_scenarioContext["response"]).Content.ReadAsStringAsync().Result);
        }

        [Then(@"there is a link to youtube\.com")]
        public void ThenThereIsALinkToYoutube_Com()
        {
            Assert.Contains("www.youtube.com", ((HttpResponseMessage)_scenarioContext["response"]).Content.ReadAsStringAsync().Result);
        }

        public void Dispose()
        {
            _factory.Dispose();
        }
    }
}
