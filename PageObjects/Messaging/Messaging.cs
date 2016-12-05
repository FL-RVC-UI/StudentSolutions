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
    public class Messaging : BasePageObject
    {
        private IWebDriver Driver;


        #region Constructor

        public Messaging(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        #endregion

        #region UI Selectors
        [FindsBy(How = How.Id, Using = "NewAlternateHeader_tab_MSGS_UNREAD")]
        private IWebElement UnreadMessage { get; set; }

        [FindsBy(How = How.Id, Using = "NewAlternateHeader_tab_MSGS_NEW")]
        private IWebElement PostMessage { get; set; }

        [FindsBy(How = How.Id, Using = "tabShares")]
        private IWebElement ShareTransfer { get; set; }

        [FindsBy(How = How.Id, Using = "dtgMessages_ctl03_chkSelection")]
        private IWebElement amessage { get; set; }

        [FindsBy(How = How.Id, Using = "MessagingActionsTop_DeleteAll")]
        private IWebElement DeleteButton { get; set; }

        [FindsBy(How = How.Id, Using = "NewAlternateHeader_tab_MENU_MYSTUDENTS")]
        private IWebElement MyStudentsButton { get; set; }

        #endregion


        #region Page Actions

        internal void ClickPostMessage()
        {
            PostMessage.Click();
        }

        internal void ClickShareTransfer()
        {
            ShareTransfer.Click();
        }

        internal void Checkamessage()
        {
            amessage.Click();
        }

        internal void ClickDelete()
        {
            DeleteButton.Click();
        }

        internal void ClickMyStudentsButton()
        {
            MyStudentsButton.Click();
        }

        public bool IsDisplayed()
        {
            BaseWaitForPageToLoad(Driver, 30);
            return UnreadMessage.Displayed;
        }


        }
    #endregion
}
