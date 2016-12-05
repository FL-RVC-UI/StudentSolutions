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
    public class PPTFinalizeDocument : StudentSolutionsTestBase
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
            //ExecuteSiteLogout();
           // BaseTearDown(Driver);
        }
        #endregion
        #region Test Cases
        [TestMethod]
        [TestCategory("Smoke")]
        [TestProperty("TestArea", "")]
        [TestProperty("TestCaseID", "")]
        [TestProperty("TestCaseName", "")]
        public void PPTDocFinalizing()
        {
            var messagingpage = new Messaging(Driver);
            var myStudentsPg = new MyStudentsPage(Driver);
            var PPTDraftDoc = new PPTDocumentDetails(Driver);
            var MeetingInfoPage = new MeetingInformationPage(Driver);

            string MeetingDate = ("01/30/2016");
            string RecentAnnualReviewDate = ("08/02/2016");
            string CurrentGrade = ("07");
            string AdminGuardian = ("Automation QA UFT");
            try
            {
                {
                    messagingpage
                        .ClickMyStudentsButton();
                }
                {
                    myStudentsPg
                          .ClickDraftButton();
                }
                {
                    PPTDraftDoc
                        .ClickMeetingInformationButton();
                }
                {
                    MeetingInfoPage

                        .enter_creds(MeetingDate, RecentAnnualReviewDate, CurrentGrade, AdminGuardian)
                        .ClickMeetingReason();
                }
                {
                    MeetingInfoPage
                        .ClickSaveReturn();
                }
                {
                    PPTDraftDoc
                        .ClickEvaluationButton();
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
