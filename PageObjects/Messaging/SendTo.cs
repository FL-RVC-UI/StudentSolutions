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
    public class SendTo : BasePageObject
    {
        private IWebDriver Driver;


        #region Constructor

        public SendTo(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        #endregion

        #region UI Selectors


        [FindsBy(How = How.Id, Using = "CMBStartUPSelection")]
        private IWebElement Allusers { get; set; }


        internal void ClickTheUser()
        {
            TheUser.Click();
        }
        [FindsBy(How = How.Id, Using = "Users_0")]
        private IWebElement TheUser { get; set; }

        internal void ClickSend()
        {
            SendButton.Click();
        }
        [FindsBy(How = How.Id, Using = "MessagingActionsTop_Send")]
        private IWebElement SendButton { get; set; }


        #endregion


        #region Page Actions

        public bool IsDisplayed()
        {
            BaseWaitForPageToLoad(Driver, 30);
            return Allusers.Displayed;
        }

        public SendTo enter_creds(string Listname)
        {
            Allusers.SendKeys(Listname);
          return this;
        }

        #endregion
    }
}