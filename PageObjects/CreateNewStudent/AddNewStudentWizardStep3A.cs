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
    public class AddNewStudentWizardStep3A : BasePageObject
    {
        private IWebDriver Driver;


        #region Constructor

        public AddNewStudentWizardStep3A(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        #endregion

        #region UI Selectors


        internal void ClickAddNewContact()
        { AddNewContact.Click(); }
        [FindsBy(How = How.Id, Using = "cmdAddNew")]
        private IWebElement AddNewContact { get; set; }
        


        internal void ClickNext()
        { Next.Click(); }
        [FindsBy(How = How.Id, Using = "btnNext1")]
        private IWebElement Next { get; set; }
        #endregion


        #region Page Actions

        public bool IsDisplayed()
        {
            BaseWaitForPageToLoad(Driver, 30);
            return AddNewContact.Displayed;
        }



        public void ClickNextButton()

        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(Next));
            Next.Click();

        }
        #endregion
    }
}