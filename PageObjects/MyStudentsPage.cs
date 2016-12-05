using Automation;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentSolutions.PageObjects
{
    public class MyStudentsPage : BasePageObject
    {
        private IWebDriver local_driver;
        public MyStudentsPage(IWebDriver driver)
        {
            local_driver = driver;
            PageFactory.InitElements(local_driver, this);
        }


        [FindsBy(How = How.Id, Using = "NewAlternateHeader_tab_MENU_MYSTUDENTS")]
        public IWebElement MyStudentsHeaderLink { get; set; }

        [FindsBy(How = How.Id, Using = "NewAlternateHeader_tab_NewStudent")]
        public IWebElement NewStudentHeaderLink { get; set; }

        [FindsBy(How = How.Id, Using = "NewAlternateHeader_tab_MENU_MESSAGING")]
        private IWebElement Message { get; set; }

        [FindsBy(How = How.Id, Using = "btnDraft5224")]
        private IWebElement DraftButton { get; set; }


        #region PageActions
        internal void ClickMessaging()
        {
            Message.Click();
        }

        internal void ClickDraftButton()
        {
            DraftButton.Click();
        }


        #endregion
    }
}
