using StudentSolutions.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using StudentSolutions.PageObjects;

namespace StudentSolutions.TestCases
{
    [TestClass]
    public class StudentCreation: StudentSolutionsTestBase
    {


        #region Setup/Teardown

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


        #region Test Case

        [TestMethod]
        public void CreateNewStudent()
        {
            var myStudentsPg = new MyStudentsPage(Driver);
            var addnewstudent = new PageObject.AddNewStudentWizard(Driver);
            var addnewstudent2 = new PageObject.AddNewStudentWizardStep2(Driver);
            var addnewstudent3A = new PageObject.AddNewStudentWizardStep3A(Driver);
            var addnewstudent3B = new PageObject.AddNewStudentWizardStep3B(Driver);
            var addnewstudent4 = new PageObject.AddNewStudentWizardStep4(Driver);
            var addnewstudent5 = new PageObject.AddNewStudentWizardStep5(Driver);

            //Step 1
            string Lname = "Baratheon";
            string Fname = "Tommen";
            string Bdate = "11/17/2006";
            string Gid = "995877";

            //Step 2
            string TeamResponsible = "PPT";
            string GenderName = "Male";
            string AddressName = "100Street";
            string CityName = "Rockville";
            string StateName = "NY";
            string Zip = "11377";
            string CountyName = "Albany";

            //Step 3
            string NCLname = "Cersie";
            string NCFname = "Lannister";
            string NCRelation = "Mother";

            {
                myStudentsPg
                      .NewStudentHeaderLink
                      .Click();
            }

            {
                addnewstudent
                    .enter_creds(Lname, Fname, Bdate, Gid)
                    .ClickNext();
            }
            {
                addnewstudent2
                   .enter_creds(TeamResponsible, GenderName, AddressName, CityName, StateName, Zip, CountyName)
                   .ClickNext();
            }
            {
                addnewstudent3A
                      .ClickAddNewContact();
            }
            {
                addnewstudent3B
                      .enter_creds(NCLname, NCFname, NCRelation)
                      .ClickSave();
                }
            {
                addnewstudent3A
                      .ClickNextButton();
            }
            {
                addnewstudent4
                      .ClickNextButton();
                    }
            {
                addnewstudent5
                      .ClickSaveandCreate();
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
