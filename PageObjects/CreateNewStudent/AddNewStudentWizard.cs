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
    public class AddNewStudentWizard : BasePageObject
    {
        private IWebDriver Driver;


        #region Constructor

        public AddNewStudentWizard(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        #endregion

        #region UI Selectors
        [FindsBy(How = How.Id, Using = "NewAlternateHeader_tab_MENU_MYSTUDENTS")]
        private IWebElement MyStudents { get; set; }

        [FindsBy(How = How.Id, Using = "NewAlternateHeader_tab_NewStudent")]
        private IWebElement Student { get; set; }

        [FindsBy(How = How.Id, Using = "txtLastName")]
        private IWebElement LastName { get; set; }

        [FindsBy(How = How.Id, Using = "txtFirstName")]
        private IWebElement FirstName { get; set; }

        [FindsBy(How = How.Id, Using = "txtBirthDate")]
        private IWebElement BirthDate { get; set; }

        [FindsBy(How = How.Id, Using = "txtGenralEdID")]
        private IWebElement GenId { get; set; }

        [FindsBy(How = How.Id, Using = "btnNext1")]
        private IWebElement Next { get; set; }
        #endregion


        #region Page Actions

        internal void ClickNext()
        {
            Next.Click();
        }

        public bool IsDisplayed()
        {
            BaseWaitForPageToLoad(Driver, 30);
            return MyStudents.Displayed;
        }

        public AddNewStudentWizard enter_creds(string Lname, string Fname, string Bdate, string Gid)
        {
            LastName.SendKeys(Lname);
            FirstName.SendKeys(Fname);
            BirthDate.SendKeys(Bdate);
            GenId.SendKeys(Gid);
            return this;
        }



        #endregion
    }
}