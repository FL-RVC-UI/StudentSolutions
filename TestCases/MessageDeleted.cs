using StudentSolutions.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using StudentSolutions.PageObjects;
using StudentSolutions.PageObject;
namespace StudentSolutions.TestCases
{
    [TestClass]
    public class MessageDeleted : StudentSolutionsTestBase
    {
        #region Setup and TearDown

        [TestInitialize]
        public void _setup()
        {
            SetupStudentSolutionsTestBase();
            ExecuteSiteLogin();
        }
        [TestCleanup]
        public void _cleanup()
        {
            ExecuteSiteLogout();
            BaseTearDown(Driver);
        }
        #endregion

        #region Test Cases
        [TestMethod]
        [TestCategory("Smoke")]
        [TestProperty("TestArea", "")]
        [TestProperty("TestCaseID", "")]
        [TestProperty("TestCaseName", "")]
        public void MessageDeletion()
        {
           
            var messagingpage = new Messaging(Driver);
          
            try
            {

                {
                    messagingpage
                        .Checkamessage();
                }
                {
                    messagingpage
                        .ClickDelete();
                }

            }
            catch (Exception e)
            {
                HandleError(e, Driver);
                throw;
            }
        }
        #endregion
    }
}
