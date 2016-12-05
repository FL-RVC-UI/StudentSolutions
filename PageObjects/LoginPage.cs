using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace StudentSolutions.PageObject
{
    public class LoginPage : BasePageObject
    {
        private IWebDriver Driver;


        #region Constructor

        public LoginPage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        #endregion

        #region UI Selectors
        [FindsBy(How = How.Id, Using = "txtDistrict")]
        private IWebElement DistrictField { get; set; }

        [FindsBy(How = How.Id, Using = "txtUser")]
        private IWebElement UseridField { get; set; }

        [FindsBy(How = How.Id, Using = "txtPass")]
        private IWebElement PasswordField { get; set; }


        internal void ClickLogin()
        {
            LoginButton.Click();
        }
        [FindsBy(How = How.ClassName, Using = "LoginButton")]
        private IWebElement LoginButton { get; set; }



        #endregion


        #region Page Actions

        public bool IsDisplayed()
        {
            BaseWaitForPageToLoad(Driver, 30);
            return DistrictField.Displayed;
        }

        public LoginPage enter_creds(string DistId, string UserID, string PW)
        {
            DistrictField.SendKeys(DistId);
            UseridField.SendKeys(UserID);
            PasswordField.SendKeys(PW);
            
            return this;
        }


        public void ClickLoginButton()

        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(LoginButton));
            LoginButton.Click();

        }
        #endregion
    }
}