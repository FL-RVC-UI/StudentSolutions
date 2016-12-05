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
    public class PPTDocumentDetails : BasePageObject
    {
        private IWebDriver Driver;
        #region Constructor
        public PPTDocumentDetails(IWebDriver driver)
        {
            this.Driver = driver;
            PageFactory.InitElements(driver, this);
        }
        #endregion

        #region UI Selectors

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_uxIEPDirectHeader_NewAlternateHeader_tab_MENU_DOCDETAILS")]
        public IWebElement DocDetails { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_MainPageContentPlaceHolder_MainPageContentPlaceHolder_uxContainerForMeetingInfo_Ver_2_editMeetingInfo_Ver_2")]
        private IWebElement MeetingInformationButton { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_MainPageContentPlaceHolder_MainPageContentPlaceHolder_uxContainerForEvaluations_Ver_2_editEvaluations_Ver_2")]
        private IWebElement EvaluationButton { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_MainPageContentPlaceHolder_MainPageContentPlaceHolder_uxContainerForCommitteeRecommendations_editCommitteeRecommendations")]
        private IWebElement TeamRecommendationsButton { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_MainPageContentPlaceHolder_MainPageContentPlaceHolder_uxContainerForPriorNotice_Ver_2_editPriorNotice_Ver_2")]
        private IWebElement PriorWrittenNoticeButton { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_MainPageContentPlaceHolder_MainPageContentPlaceHolder_uxContainerForPresentLevelsofPerformance_Ver_2_editPresentLevelsofPerformance_Ver_2")]
        private IWebElement PresentLevelsofAcademicandFunctionalPerformanceButton { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_MainPageContentPlaceHolder_MainPageContentPlaceHolder_uxContainerForTransitionPlanning_Ver_2_editTransitionPlanning_Ver_2")]
        private IWebElement TransitionPlanningButton { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_MainPageContentPlaceHolder_MainPageContentPlaceHolder_uxContainerForGoalsAndObjectives_editGoalsAndObjectives")]
        private IWebElement GoalsAndObjectivesButton { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_MainPageContentPlaceHolder_MainPageContentPlaceHolder_uxContainerForProgramModifications_Ver_2_editProgramModifications_Ver_2")]
        private IWebElement ProgramAccommodationsAndModificationsButton { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_MainPageContentPlaceHolder_MainPageContentPlaceHolder_uxContainerForTestingAccommodations_SBAC_editTestingAccommodations_SBAC")]
        private IWebElement TestingAccommodationsButton { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_MainPageContentPlaceHolder_MainPageContentPlaceHolder_uxContainerForDistrictWideAssessments_Ver_2_editDistrictWideAssessments_Ver_2")]
        private IWebElement DistrictwideAssessmentsButton { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_MainPageContentPlaceHolder_MainPageContentPlaceHolder_uxContainerForSpecialFacProgReporting_Ver_2_editSpecialFacProgReporting_Ver_2")]
        private IWebElement SpecialFactorsProgressReportingandExitCriteriaButton { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_MainPageContentPlaceHolder_MainPageContentPlaceHolder_uxContainerForStudentPrograms_editStudentPrograms")]
        private IWebElement SpecialEducationServicesButton { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_MainPageContentPlaceHolder_MainPageContentPlaceHolder_uxContainerForStudentRelatedServices_editStudentRelatedServices")]
        private IWebElement RelatedServicesButton { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_MainPageContentPlaceHolder_MainPageContentPlaceHolder_uxContainerForCTStateReportingInfo_Ver_2_editCTStateReportingInfo_Ver_2")]
        private IWebElement TimewithNonDisabledPeersButton { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_MainPageContentPlaceHolder_MainPageContentPlaceHolder_uxContainerForParticipationNonParticipation_ver_2_editParticipationNonParticipation_ver_2")]
        private IWebElement ExtentofParticipationNonParticipationButton { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ctl00_MainPageContentPlaceHolder_MainPageContentPlaceHolder_uxContainerForRequiredData_Ver_2_editRequiredData_Ver_2")]
        private IWebElement RequiredDataCollectionButton { get; set; }

        [FindsBy(How = How.Id, Using = "")]
        private IWebElement ABCButton { get; set; }
        
        #endregion

        #region Page Actions

        internal void ClickMeetingInformationButton()
        {
            MeetingInformationButton.Click();
        }

        internal void ClickEvaluationButton()
        { EvaluationButton.Click(); }

        internal void ClickTeamRecommendationsButton()
        {
            TeamRecommendationsButton.Click();
        }

        internal void ClickPriorWrittenNoticeButton()
        {
            PriorWrittenNoticeButton.Click();
        }

        internal void ClickPresentLevelsofAcademicandFunctionalPerformanceButton()
        {
            PresentLevelsofAcademicandFunctionalPerformanceButton.Click();
        }

        internal void ClickTransitionPlanningButton()
        {
            TransitionPlanningButton.Click();
        }

        internal void ClickGoalsAndObjectivesButton()
        {
            GoalsAndObjectivesButton.Click();
        }

        internal void ClickProgramAccommodationsAndModificationsButton()
        {
            ProgramAccommodationsAndModificationsButton.Click();
        }

        internal void ClickTestingAccommodationsButton()
        {
            TestingAccommodationsButton.Click();
        }

        internal void ClickDistrictwideAssessmentsButton()
        {
            DistrictwideAssessmentsButton.Click();
        }

        internal void ClickSpecialFactorsProgressReportingandExitCriteriaButton()
        {
            SpecialFactorsProgressReportingandExitCriteriaButton.Click();
        }

        internal void ClickSpecialEducationServicesButton()
        {
            SpecialEducationServicesButton.Click();
        }

        internal void ClickRelatedServicesButton()
        {
            RelatedServicesButton.Click();
        }

        internal void ClickTimewithNonDisabledPeersButton()
        {
            TimewithNonDisabledPeersButton.Click();
        }

        internal void ClickExtentofParticipationNonParticipationButton()
        {
            ExtentofParticipationNonParticipationButton.Click();
        }

        internal void ClickRequiredDataCollectionButton()
        {
            RequiredDataCollectionButton.Click();
        }

        public bool IsDisplayed()
        {
            BaseWaitForPageToLoad(Driver, 30);
            return DocDetails.Displayed;
        }


        #endregion
    }
}
