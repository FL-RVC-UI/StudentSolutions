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
    public class MeetingInformationPage : BasePageObject
    {
        private IWebDriver Driver;
        #region Constructor
        public MeetingInformationPage(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
        }
        #endregion
        #region UI Selectors
        [FindsBy(How = How.Id, Using = "txtMeetingDT")]
        private IWebElement MeetingDateBox { get; set; }

        [FindsBy(How = How.Id, Using = "ddlInitialReeval")]
        private IWebElement InitialReferralList { get; set; }

        [FindsBy(How = How.Id, Using = "txtbxAnnualReview")]
        private IWebElement RecentAnnualReviewBox { get; set; }

        [FindsBy(How = How.Id, Using = "ddlGrade")]
        private IWebElement CurrentGradeList { get; set; }

        [FindsBy(How = How.Id, Using = "chk0")]
        private IWebElement MeetingReasonsButton { get; set; }

        [FindsBy(How = How.Id, Using = "ddladmindesgn")]
        private IWebElement AdminGuardianList { get; set; }

        [FindsBy(How = How.Id, Using = "cmdSaveReturn")]
        private IWebElement SaveReturnButton { get; set; }

        #endregion


        #region Page Actions


        internal void ClickMeetingReason()
        {
            MeetingReasonsButton.Click();
        }

        internal void ClickSaveReturn()
        {
            SaveReturnButton.Click();
        }

        


        public MeetingInformationPage enter_creds(string MeetingDate, string RecentAnnualReviewDate, string CurrentGrade, string AdminGuardian)
        {
            MeetingDateBox.SendKeys(MeetingDate);
            RecentAnnualReviewBox.SendKeys(RecentAnnualReviewDate);
            CurrentGradeList.SendKeys(CurrentGrade);
            AdminGuardianList.SendKeys(AdminGuardian);
            return this;
        }

        public bool IsDisplayed()
        {
            BaseWaitForPageToLoad(Driver, 30);
            return MeetingDateBox.Displayed;
        }

        #endregion
    }
}