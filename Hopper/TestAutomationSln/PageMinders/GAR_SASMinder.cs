using System;
using AutomationFramework;
using KWDT.Core;
using GAR.SAS.Automation.Pages;
using OpenQA.Selenium.Support.UI;

namespace PageMinders
{
    public partial class GAR_SASMinder : PageMinder
    {
        public string Program { get { return StringConstants.GAR_SAS; } }

        public GAR_SASMinder(string testUrl, string browserType)
        : base(Utilities.GetUrl(StringConstants.GAR_SAS), Utilities.GetBrowser())
        {
            WorksheetURL = "CPWorksheet.cshtml";
        }

        public GAR_SASMinder()
        {
            WorksheetURL = "CPWorksheet.cshtml";
        }

        //public void OpenDashboard()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.DashboardMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenViewContactLogDetails()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.ViewContactLogDetailsMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenCustomerServiceTicket()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.CustomerServiceTicketMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenCallCenterWorksheet()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.CallCenterWorksheetMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenAddApplicationNote()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.AddApplicationNoteMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenViewContactLogs()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.ViewContactLogsMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenDocumentScanningWorksheet()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.DocumentScanningWorksheetMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenDocumentScanningSearchResult()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.DocumentScanningSearchResultMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenScannedDocuments()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.ScannedDocumentsMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenUnattachedDocuments()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.UnattachedDocumentsMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenDocumentProcessingWorksheet()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.DocumentProcessingWorksheetMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenHouseholdComposition()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.HouseholdCompositionMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenPrintApplication()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.PrintApplicationMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenDisplayDocuments()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.DisplayDocumentsMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenViewPDFs()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.ViewPDFsMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenApplicationFormPrinting()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.ApplicationFormPrintingMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenApplicationProcessingWorksheet2011()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.ApplicationProcessingWorksheet2011MenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenReimbursementProcessingWorksheet()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.ApplicationProcessingWorksheet2011MenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenApplicationSummary()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.ApplicationSummaryMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenApplicationDetail()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.ApplicationDetailMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenStudentSummary()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.StudentSummaryMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenStudentDetail()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.StudentDetailMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        ////public void OpenApplicationProcessingWorksheet()
        ////{
        ////    HomePage.ApplicationProcessingWorksheetMenuItem.Click();
        ////    UIElementManager.WaitForPageLoad(HomePage.Driver);
        ////}

        //public void OpenDocumentFormAdministration()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.DocumentFormAdministrationMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenSitePageSiteControlRichTextAdministration()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.SitePageSiteControlRichTextAdministrationMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenSearchResults()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.SearchResultsMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenAdvancedSearch()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.AdvancedSearchMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenApplicationQueueAssignment()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.ApplicationQueueAssignmentMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenConfigureFeatureSettings()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.ConfigureFeatureSettingsMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenMaintainVRandSurveyPeriods()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.MaintainVRandSurveyPeriodsMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenMaintainVROpenMessage()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.MaintainVROpenMessageMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenRemoveApplication()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.RemoveApplicationMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenUpdateWaitList()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.UpdateWaitListMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenSettings()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.SettingsMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenMessageAdministration()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.MessageAdministrationMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenApplicationFeeTransactions()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.ApplicationFeeTransactionsMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenStudentSearchResults()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.StudentSearchResultsMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenAdvancedStudentSearch()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.AdvancedStudentSearchMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenReportMenu()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.ReportMenuMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenExceptionLogging()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.ExceptionLoggingMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenVerificationReport()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.VerificationReportMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenStudentDetails()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.StudentDetailsMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenScholarshipStatus()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.ScholarshipStatusMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenSettingType()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.SettingTypeMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenSitePageEditing()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.SitePageEditingMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenSitePageSiteControlEditing()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.SitePageSiteControlEditingMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenProviderContactWorksheet()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.ProviderContactWorksheetMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenProviderClaimActivity()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.ProviderClaimActivityMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenProviderContactLogs()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.ProviderContactLogsMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void OpenProviderApprovalWorksheet()
        //{
        //    Driver.Navigate().GoToUrl(TestUrl + HomePage.ProviderApprovalWorksheetMenuItem);
        //    UIElementManager.WaitForPageLoad(HomePage.Driver);
        //}

        //public void WaitForAPWWorksheetPopUps(bool closePDFViewer = true)
        //{
        //    WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(45)) { PollingInterval = TimeSpan.FromMilliseconds(500) };
        //    wait.Until(drv => drv.WindowHandles.Count > 1);
        //    UIElementManager.HardWait(HomePage.Driver, 5);

        //    int pdfViewerIndex = LocatePDFViewerPopup();
        //    if (closePDFViewer && pdfViewerIndex != -1)
        //    {
        //        Driver.UseChild(pdfViewerIndex);
        //        Driver.Close();
        //    }

        //    UseMainWindow();
        //}

        //new protected void WaitForWorksheetPageToLoad()
        //{
        //    ReimbursementProcessingWorksheetPage.WaitForPopupToLoad();
        //}
    }
}
