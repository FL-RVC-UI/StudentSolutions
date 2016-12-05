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
    public class WrittingMessage : BasePageObject
    {
        private IWebDriver Driver;


        #region Constructor

        public WrittingMessage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        #endregion

        #region UI Selectors
        

        [FindsBy(How = How.Id, Using = "Subject")]
        private IWebElement SubjectBox { get; set; }

        [FindsBy(How = How.Id, Using = "radEditorMessage_contentIframe")]
        private IWebElement WriteMessage { get; set; }


        internal void ClickContinue()
        {
            ContinueButton.Click();
        }
        [FindsBy(How = How.Id, Using = "MessagingActionsTop_Continue")]
        private IWebElement ContinueButton { get; set; }

        #endregion


        #region Page Actions

        public bool IsDisplayed()
        {
            BaseWaitForPageToLoad(Driver, 30);
            return SubjectBox.Displayed;
        }

        public WrittingMessage enter_creds(string SubjectName, string TheMessage)
        {
            SubjectBox.SendKeys(SubjectName);
            WriteMessage.SendKeys(TheMessage);
            return this;
        }


        #endregion
    }
}