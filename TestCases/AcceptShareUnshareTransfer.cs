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
    public class AcceptShareUnshareTransfer : StudentSolutionsTestBase
    {
        #region Setup and TearDown
        /**
        * This region contains the Setup and Teardown methods for tests.
        * If each test needs to perform an action, i.e. setting up the webdriver and browsing to an URL,
        * they should be put here.
        */


        /// <summary>
        /// TestSetup will run before each test case in this class
        /// </summary>


        [TestInitialize]
        public void _setup()
        {
            SetupStudentSolutionsTestBase();
            ExecuteSiteLogin();
        }

        /// <summary>
        /// TestTearDown will run after each test in this class
        /// </summary>
      

        [TestCleanup]
        public void _cleanup()
        {
            ExecuteSiteLogout();
            BaseTearDown(Driver);
        }
        // This method will quit the driver and handle different grids, i.e. sending the results to Sauce Labs

        #endregion


        #region Test Cases

        /**
     * This region should contain all the test cases
     */

        //string SubjectName = "Something Cool";
        //string TheMessage = "YOU SHOULDN'T BE READING THIS!!!";
        //string Listname = "IEP Direct - All Users";
        
        [TestMethod]
        [TestCategory("Smoke")]
        [TestProperty("TestArea", "")]
        [TestProperty("TestCaseID", "")]
        [TestProperty("TestCaseName", "")]
        public void AcceptShareTransfer()
        {
            // page objects
            var myStudentsPg = new MyStudentsPage(Driver);
            var messagingpage = new Messaging(Driver);
            var shareunsharetransfer = new ShareUnshareTransfer(Driver);

            // test data 



            try
            {// Contains contents of the test

                {
                    myStudentsPg
                          .ClickMessaging();
                }

                {
                    messagingpage
                        .ClickShareTransfer();
                    // assert that the sign in page opens
                    // Assert.IsTrue(signInPage.IsDisplayed());
                }
                {
                    var acceptButtons = shareunsharetransfer.AcceptButtons2;
                    acceptButtons.First().Click();

                
                    //shareunsharetransfer
                    //      .ClickAcceptButton();
                }
            }

            catch (Exception e)  // Fail the test if an error occurs
            {
                HandleError(e, Driver);
                throw;
            }
        }

        #endregion
    }

}