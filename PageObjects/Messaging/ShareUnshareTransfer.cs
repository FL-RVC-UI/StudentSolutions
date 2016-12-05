using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Automation;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System.Collections;

namespace StudentSolutions.PageObject
{
    public class ShareUnshareTransfer : BasePageObject
    {
        private IWebDriver Driver;


        #region Constructor

        public ShareUnshareTransfer(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
        }

        #endregion

        #region UI Selectors

        [FindsBy(How = How.Id, Using = "tabDemographics")]
        private IWebElement DemographicUpdates { get; set; }


        //internal void ClickAcceptButton()
        //{
        //    AcceptButton.Click();
        //}
        //[FindsBy(How = How.Id, Using = "ImageButton1")]
        //private IWebElement AcceptButton { get; set; }

        #endregion


        #region Page Actions

        public bool IsDisplayed()
        {
            BaseWaitForPageToLoad(Driver, 30);
            return DemographicUpdates.Displayed;
        }

        //public void ClickTheAcceptButton()
        ////{
        ////    var wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
        ////    wait.Until(ExpectedConditions.ElementToBeClickable(AcceptButton));
        ////    AcceptButton.Click();
        ////}

        [FindsBy(How = How.CssSelector, Using = "a[href *= StudentHoldingControl]  img[src *= accept]")]
        public  IList<IWebElement> AcceptButtons2 { get; set; }


        #endregion
    }
}