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
    public class AddNewStudentWizardStep3B : BasePageObject
    {
        private IWebDriver Driver;


        #region Constructor

        public AddNewStudentWizardStep3B(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        #endregion

        #region UI Selectors

        [FindsBy(How = How.Id, Using = "smtxtLastName")]
        private IWebElement NCLastName { get; set; }

        [FindsBy(How = How.Id, Using = "smtxtFirstName")]
        private IWebElement NCFirstName { get; set; }

        [FindsBy(How = How.Id, Using = "smcboRelationship")]
        private IWebElement NCRelationShip { get; set; }

        internal void ClickSave()
        { Save.Click(); }
        [FindsBy(How = How.Id, Using = "btnSave1")]
        private IWebElement Save { get; set; }

        #endregion


        #region Page Actions

        public bool IsDisplayed()
        {
            BaseWaitForPageToLoad(Driver, 30);
            return NCLastName.Displayed;
        }

        public AddNewStudentWizardStep3B enter_creds(string NCLname, string NCFname, string NCRelation)
        {
            NCLastName.SendKeys(NCLname);
            NCFirstName.SendKeys(NCFname);
            NCRelationShip.SendKeys(NCRelation);
            return this;
        }


        public void ClickSaveButton()

        {
            var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            wait.Until(ExpectedConditions.ElementToBeClickable(Save));
            Save.Click();

        }
        #endregion
    }
}