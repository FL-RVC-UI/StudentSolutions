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
    public class AddNewStudentWizardStep2 : BasePageObject
    {
        private IWebDriver Driver;


        #region Constructor

        public AddNewStudentWizardStep2(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        #endregion

        #region UI Selectors
        [FindsBy(How = How.Id, Using = "cboCommitteeResp")]
        private IWebElement Committee { get; set; }

        [FindsBy(How = How.Id, Using = "cboGender")]
        private IWebElement Gender { get; set; }

        [FindsBy(How = How.Id, Using = "txtAddress1")]
        private IWebElement Address { get; set; }

        [FindsBy(How = How.Id, Using = "txtCity")]
        private IWebElement City { get; set; }

        [FindsBy(How = How.Id, Using = "txtState")]
        private IWebElement State { get; set; }

        [FindsBy(How = How.Id, Using = "txtZip")]
        private IWebElement Zip { get; set; }
        [FindsBy(How = How.Id, Using = "cboCounty")]
        private IWebElement County { get; set; }

        [FindsBy(How = How.Id, Using = "cboCommitteeResp")]
        private IWebElement Team { get; set; }


        internal void ClickNext()
        {
            Next.Click();
        }
        [FindsBy(How = How.Id, Using = "btnNext1")]
        private IWebElement Next { get; set; }
        #endregion


        #region Page Actions

        public bool IsDisplayed()
        {
            BaseWaitForPageToLoad(Driver, 30);
            return Committee.Displayed;
        }

        public AddNewStudentWizardStep2 enter_creds(string TeamResponsible, string GenderName, string AddressName, string CityName, string StateName, string ZipCode, string CountyName)
        {
            Committee.SendKeys(TeamResponsible);
            Gender.SendKeys(GenderName);
            Address.SendKeys(AddressName);
            City.SendKeys(CityName);
            State.SendKeys(StateName);
            Zip.SendKeys(ZipCode);
            County.SendKeys(CountyName);
            return this;
        }

        #endregion
    }
}
