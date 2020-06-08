using BoDi;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using SeleniumProject.Pages;
using System;
using TechTalk.SpecFlow;

namespace SeleniumProject.Steps
{
    [Binding]
    public class SpecFlowFeatureSteps
    {
        IWebDriver webDriver = new ChromeDriver();
       
        public SpecFlowFeatureSteps(IWebDriver webDriver)
        {
          this.webDriver = webDriver;
            PageFactory.InitElements(this.webDriver, this);
        }


        [Given(@"I Navigate to the facebook Login page")]
        public void GivenINavigateToTheFacebookLoginPage()
        {
            webDriver.Navigate().GoToUrl("https://www.facebook.com/");
        }
        
        [When(@"I Login with Username '(.*)' and Password '(.*)' as inputs")]
        public void WhenILoginWithUsernameAndPasswordAsInputs(string username, string password)
        {
            LoginPObject loginPage = new LoginPObject(webDriver);
            loginPage.LoginAs(username, password);
        }
        
        [Then(@"I am on the facebook dashboard page")]
        public void ThenIAmOnTheFacebookDashboardPage()
        {
            DashboardPObject dashboardPage = new DashboardPObject(webDriver);
         //   Assert.IsTrue(dashboardPage.GetUser().Contains(expectedUser));
        }
    }
}

//taskkill /f /im chromedriver.exe