using Automation;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentSolutions.PageObjects;
using StudentSolutions.PageObject;

namespace StudentSolutions.Helpers
{
    public abstract class StudentSolutionsTestBase : BaseFrameWork
    {

        protected IWebDriver Driver;

        protected string DistId = "998";
        protected string UserID = "301875";
        protected string PW = "Password2";

        public StudentSolutionsTestBase()
        {
        }

        #region Constructor
        protected void SetupStudentSolutionsTestBase()
        {
            Driver = SetUp(_BT);
            BrowseTo(_baseURL, Driver);
        }

        #endregion

        protected void ExecuteSiteLogin()
        {
            var loginPg = new LoginPage(Driver);
            
                loginPg
                    .enter_creds(DistId, UserID, PW)
                    .ClickLogin();
        }

        protected void ExecuteSiteLogout()
        {
            Driver.FindElement(By.Id("btn_Logout")).Click();
        }
    }

    public class BaseFrameWork
    {
    }
}
