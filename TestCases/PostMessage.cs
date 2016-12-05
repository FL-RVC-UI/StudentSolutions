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
    public class PostMessage : StudentSolutionsTestBase
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
        public void WrittingAMessage()
        {
            var myStudentsPg = new MyStudentsPage(Driver);
            var messagingpage = new Messaging(Driver);
            var writesomething = new WrittingMessage(Driver);
            var sendmessageto = new SendTo(Driver);

            string SubjectName = "Something Cool";
            string TheMessage = "YOU SHOULDN'T BE READING THIS!!!";
            string Listname = "IEP Direct - All Users";
            
            { myStudentsPg
                    .ClickMessaging();
            }

            {
                messagingpage
                      .ClickPostMessage();
            }

            {
                writesomething
                    .enter_creds(SubjectName, TheMessage)
                    .ClickContinue();
                // Assert.IsTrue(signInPage.IsDisplayed());
            }
            {
                sendmessageto
                       .enter_creds(Listname)
                       .ClickTheUser();
            }
            {
                sendmessageto
                       .ClickSend();
            }

            try { }
            catch (Exception e) 
            {
                HandleError(e, Driver);
                throw;
            }
        }

        #endregion
    }

}