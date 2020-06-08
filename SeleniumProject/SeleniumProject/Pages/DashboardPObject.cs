using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using FindsByAttribute = SeleniumExtras.PageObjects.FindsByAttribute;
using How = SeleniumExtras.PageObjects.How;

namespace SeleniumProject.Pages
{
    public class DashboardPObject
    {
        [FindsBy(How = How.CssSelector, Using = "#wp-admin-bar-my-account .ab-item")]
        protected IWebElement UserNameTxt { get; set; }


        private IWebDriver _driver;

        public DashboardPObject(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(_driver, this);
        }


        /// <summary>
        /// Get Displayed User Name 
        /// </summary>
        /// <returns></returns>
        public string GetUser()
        {
            return UserNameTxt.Text;
        }
    }
}