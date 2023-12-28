using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using KWDT.Core;
using KWDT.Core.TestDefinitions;
using KWDT.Core.TestExecution;
using KWDT.Core.Interfaces;
using System.Windows.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.IO;

namespace KWDT.UI.UserControls
{
    /// <summary>
    /// Interaction logic for TestRunner.xaml
    /// </summary>
    public partial class TestRunner : BaseUserControl
    {
        private readonly ITestSuiteExecutor _testSuiteExecutor;

        private readonly IDataManager _dataManager;

        private readonly TestRunDefinition _testRun;

        private readonly Stopwatch _testTimer;

        public bool closeOnComplete { get; set; }

		TestCaseDefinition updatedTestCase;

		static IWebDriver driver;

        public string testPointID;

        public string testPlanID;

		private bool Running
        {
            get
            {
                return _testSuiteExecutor.IsRunning();
            }
        }

        public TestRunner(ITestSuiteExecutor testSuiteExecutor, IDataManager dataManager)
        {
            InitializeComponent();

            ucTitleBar.lblTitle.Content = "Test Runner";

            if (testSuiteExecutor == null)
                throw new ArgumentNullException(nameof(testSuiteExecutor));

            _testSuiteExecutor = testSuiteExecutor;

            if (dataManager == null)
                throw new ArgumentNullException(nameof(dataManager));

            _dataManager = dataManager;

            _testRun = new TestRunDefinition();

            _testTimer = new Stopwatch();
            ucTitleBar.btnBack.Click += goBack_Click;
            ucTitleBar.btnHome.Visibility = Visibility.Hidden;
        }

        private string TimeStamp()
        {
            return " " + DateTime.Now.ToString("MM-dd-yyyy hh:mm");
        }

        public void SetTestToRun(TestCaseDefinition testCase)
        {
            if (!String.IsNullOrEmpty(testCase.InjectionString))
                Utilities.SetStringInjectionText(testCase.InjectionString);
            else
                Utilities.SetStringInjectionText(string.Empty);

            TestSetDefinition stubTestSet = new TestSetDefinition();
            stubTestSet.Name = testCase.Name;
            stubTestSet.TestType = testCase.TestType;
            stubTestSet.Browser = testCase.Browser;
            stubTestSet.Environment = testCase.Environment;
            stubTestSet.ServerEnvironment = testCase.ServerEnvironment;
            stubTestSet.TestCases.Add(testCase);
            SetTestToRun(stubTestSet);
        }

        public void SetTestToRun(TestSetDefinition testSet)
        {
            TestSuiteDefinition stubTestSuite = new TestSuiteDefinition();
            stubTestSuite.Name = testSet.Name;
            stubTestSuite.TestType = testSet.TestType;
            stubTestSuite.Browser = testSet.Browser;
            stubTestSuite.Environment = testSet.Environment;
            stubTestSuite.ServerEnvironment = testSet.ServerEnvironment;
            stubTestSuite.TestSets.Add(testSet);
            SetTestToRun(stubTestSuite);
        }

        public void SetTestToRun(TestSuiteDefinition testSuite)
        {
            _testRun.TestSuite = testSuite;

            DataContext = _testRun;

            _testRun.Name = testSuite.Name;
            _testRun.Type = testSuite.TestType;
            _testRun.Browser = testSuite.Browser;
            _testRun.Environment = testSuite.Environment;
            _testRun.ServerEnvironment = testSuite.ServerEnvironment;

            nameLabel.Content = "Name: " + testSuite.Name;
            typeLabel.Content = "Type: " + testSuite.TestType;
            envLabel.Content = "Test Environment: " + testSuite.Environment;
            serverEnvLabel.Content = "Server Environment: " + testSuite.ServerEnvironment;
            browserLabel.Content = "Browser: " + testSuite.Browser;

            _testRun.TestSuite.TestSets.ForEach(tSet =>
            {
                _testRun.TestCases.AddRange(tSet.TestCases);
            });

            if (_testRun.TestSuite.TestSets.Count > 0)
            {
				testList.SelectedItem = _testRun.TestCases.First();
            }

            TestResultLogger.SetSuiteName(testSuite.Name);
            TestResultLogger.SetSuiteType(testSuite.TestType);
            TestResultLogger.CreateReport();


            Utilities.SetBrowser(testSuite.Browser);
            Utilities.SetEnvironment(testSuite.Environment);
            Utilities.SetServerEnvironment(testSuite.ServerEnvironment);

            if (_testRun.Name.Contains("- COMPARE"))
			{
				screenCompare.IsEnabled = true;
				openScreenCompareResults.IsEnabled = true;
			}

            testPointID = testSuite.TestSets[0].TestCases[0].TestPointID;
            testPlanID = testSuite.TestSets[0].TestCases[0].TestPlanID;
            TestResultLogger.SetTestCaseName(testSuite.TestSets[0].TestCases[0].Name);
        }

        private void UpdateTestSteps(TestCaseDefinition testCase)
		{
			updatedTestCase = new TestCaseDefinition(testCase);

			List<TestCaseDefinition> savedTestCases = _dataManager.LoadAllTestCases();

			for (int i = testCase.TestSteps.Count - 1; i >= 0; i--)
			{
				if (testCase.TestSteps[i].SharedStep)
				{
                    foreach (var savedTestCase in savedTestCases)
                    {
                        if (savedTestCase != null)
                        {
                            if (testCase.TestSteps[i].Entity.Equals(savedTestCase.Name))
                            {
                                updatedTestCase.TestSteps.Remove(updatedTestCase.TestSteps[i]);
                                updatedTestCase.TestSteps.InsertRange(i, savedTestCase.TestSteps);
                                break;
                            }
                        }
                    }
                }
			}

            for (int i = updatedTestCase.TestSteps.Count - 1; i >= 0; i--)
            {
                if (updatedTestCase.TestSteps[i].Action == null)
                {
                    updatedTestCase.TestSteps.Remove(updatedTestCase.TestSteps[i]);
                }
            }

			testSteps.ItemsSource = updatedTestCase.TestSteps;
		}

		private void Reset()
        {
            _testTimer.Stop();
            pause.Visibility = Visibility.Hidden;
            play.Visibility = Visibility.Visible;
            ucTitleBar.btnBack.IsEnabled = true;
            stop.IsEnabled = false;
            nextStep.IsEnabled = false;
            play.IsEnabled = true;
            testList.SelectedIndex = 0;
            testSteps.SelectedIndex = 0;
            testList.IsHitTestVisible = true;
            UnsubscribeToEvents();
        }

        private void SubscribeToEvents()
        {
            _testSuiteExecutor.ProgressNotificationEvent += UpdateTestProgress;
            _testSuiteExecutor.TestCaseCompleteEvent += MoveToNextTest;
            _testSuiteExecutor.TestSuiteCompleteEvent += MarkTestComplete;
            _testSuiteExecutor.TestSuiteStoppedEvent += MarkTestComplete;
        }

        private void UnsubscribeToEvents()
        {
            _testSuiteExecutor.ProgressNotificationEvent -= UpdateTestProgress;
            _testSuiteExecutor.TestCaseCompleteEvent -= MoveToNextTest;
            _testSuiteExecutor.TestSuiteCompleteEvent -= MarkTestComplete;
            _testSuiteExecutor.TestSuiteStoppedEvent -= MarkTestComplete;
        }

        private void goBack_Click(object sender, RoutedEventArgs e)
        {
            stop.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

            CloseChildPage();
        }

        private void play_Click(object sender, RoutedEventArgs e)
        {
            pause.IsEnabled = true;
            stop.IsEnabled = false;
            nextStep.IsEnabled = false;
            ucTitleBar.btnBack.IsEnabled = false;

            string x = pageWaitTime.Text;
            int value;
            if (int.TryParse(x, out value))
                Utilities.SetPageWaitTime(int.Parse(pageWaitTime.Text));
            else
                Utilities.SetPageWaitTime();

            if (!String.IsNullOrWhiteSpace(VSTSid.Text))
            {
                Utilities.SetVSTSItemID(Int32.Parse(VSTSid.Text));
            }

            if (_testSuiteExecutor.IsPaused())
                Resume();
            else
            {
                TestResultLogger.CreateReport();
                StartNew();
            }
        }

        public void StartNew()
        {
            SubscribeToEvents();
            testList.SelectedIndex = 0;
            testSteps.SelectedIndex = 0;
            testList.IsHitTestVisible = false;
            _testTimer.Start();
            _testSuiteExecutor.Start(_testRun.TestSuite);
            _testTimer.Stop();
            _testRun.ElapsedTime = _testTimer.Elapsed;
            play.Visibility = Visibility.Hidden;
            pause.Visibility = Visibility.Visible;

            if (testPointID != null && testPlanID != null)
            {
                Utilities.SetTestPointID(Int32.Parse(testPointID));
                Utilities.SetTestPlanID(Int32.Parse(testPlanID));
            }
            else
            {
                Utilities.SetTestPointID(null);
                Utilities.SetTestPlanID(null);
            }
        }

        private void Resume()
        {
            if (!_testTimer.IsRunning)
                _testTimer.Start();

            _testSuiteExecutor.Resume();
            play.Visibility = Visibility.Hidden;
            pause.Visibility = Visibility.Visible;
        }

        private void UpdateTestProgress(object sender, EventArgs e)
        {
            var testStatus = (TestCaseExecutionProgress)((ProgressChangedEventArgs)e).UserState;

            testSteps.SelectedIndex = testSteps.SelectedIndex + 1;
            testSteps.ScrollIntoView(testSteps.SelectedItem);

            if ((bool)((KWDT.Core.TestDefinitions.TestStepDefinition)testSteps.Items[testSteps.SelectedIndex]).Breakpoint)
                pause.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
        }

        private void MoveToNextTest(object sender, EventArgs e)
        {
            testList.SelectedIndex = testList.SelectedIndex + 1;
            testSteps.SelectedIndex = 0;
        }

        private void MarkTestComplete(object sender, EventArgs e)
        {
            Reset();

            if(!Utilities.GetExecutedByCommandLine())
                Utilities.cleanUpConsole();

            TestResultLogger.ResetStepCounter();

            double passPercentage = Math.Round(((double)(TestResultLogger.GetTestCaseCounter() - TestResultLogger.GetFailedTestCaseCounter()) / TestResultLogger.GetTestCaseCounter()), 2);
            Console.WriteLine(passPercentage * 100 + "% of test cases passed");

            if (closeOnComplete)
                Environment.Exit(0);
        }

        private void stop_Click(object sender, RoutedEventArgs e)
        {
            stop.IsEnabled = false;
            play.IsEnabled = false;
            pause.IsEnabled = false;
            nextStep.IsEnabled = false;
            _testSuiteExecutor.Stop();
        }

        private void nextStep_Click(object sender, RoutedEventArgs e)
        {
            if (!Running)
                return;

            _testTimer.Start();
            _testSuiteExecutor.SingleStep();
            _testTimer.Stop();
        }

        private void pause_Click(object sender, RoutedEventArgs e)
        {
            if (!Running)
                return;

            if (_testTimer.IsRunning)
                _testTimer.Stop();

            _testSuiteExecutor.Pause();
            play.Visibility = Visibility.Visible;
            pause.Visibility = Visibility.Hidden;
            stop.IsEnabled = true;
            nextStep.IsEnabled = true;
            ucTitleBar.btnBack.IsEnabled = true;
        }

        private void testList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            TestCaseDefinition selectedTestCase = (TestCaseDefinition)testList.SelectedItem;
            testSteps.ScrollIntoView(testSteps.SelectedItem);
            UpdateTestSteps(selectedTestCase);

            if(selectedTestCase.TestPointID != null && selectedTestCase.TestPlanID != null)
            {
                try
                {
                    Utilities.SetTestPointID(Int32.Parse(selectedTestCase.TestPointID));
                    Utilities.SetTestPlanID(Int32.Parse(selectedTestCase.TestPlanID));
                }
                catch
                {
                    Utilities.SetTestPointID(null);
                    Utilities.SetTestPlanID(null);
                }
            }
            else
            {
                Utilities.SetTestPointID(null);
                Utilities.SetTestPlanID(null);
            }

            TestResultLogger.SetTestCaseName(selectedTestCase.Name);
        }

        private void viewResults_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("C:\\KWDT Temp Repo\\Test Results\\" + TestResultLogger.GetSuiteType() + "s\\" + TestResultLogger.GetSuiteName() + ".html");
            }
            catch
            {
                MessageBoxResult noResult = MessageBox.Show("A report has not yet been generated for this test.", "Results Missing", MessageBoxButton.OK);
            }
        }

        private void viewLogs_Click(object sender, RoutedEventArgs e)
        {
            Process.Start(@"C:\KWDT Temp Repo\Test Results\Logs");
        }

        private void screenCompare_Click(object sender, RoutedEventArgs e)
		{
			string name = null;
			List<String> compareScreenshots = new List<String>();
            List<String> compareScreenshotsFilePaths = new List<String>();
            String fileCompare = @"C:\KWDT Temp Repo\Test Results\Screenshots\" + KWDT.Core.TestExecution.TestResultLogger.GetSuiteType() + @"s\";

            //puts all unique screenshot names from Screenshots folder into a list
			foreach (string dirName in Directory.EnumerateDirectories(fileCompare))
			{
				string formattedName = dirName.Replace(@"C:\KWDT Temp Repo\Test Results\Screenshots\" + KWDT.Core.TestExecution.TestResultLogger.GetSuiteType() + @"s\", "");
				if (formattedName.Equals(_testRun.Name + " " + DateTime.Now.ToString("MM-dd-yyyy")))
				{
					foreach (string fileName in Directory.EnumerateFiles(fileCompare + formattedName))
					{
						foreach (var elem in fileName.Split(' ').ToList())
						{
							if (elem.Contains(".png"))
								name = elem;
						}

                        if (name != null && !compareScreenshots.Contains(name))
                        {
                            compareScreenshots.Add(name);
                            compareScreenshotsFilePaths.Add(fileName);
                        }
					}
				}
			}

			name = null;
			List<String> baselineFolders = new List<String>();
			List<String> baselineScreenshots = new List<String>();
            List<String> baselineScreenshotsFilePaths = new List<String>();
            String file = @"C:\KWDT Temp Repo\Test Results\Baseline Screenshots\" + KWDT.Core.TestExecution.TestResultLogger.GetSuiteType() + @"s\";

            //puts all unique screenshot names from BaselineScreenshots folder into a list
            foreach (string dirName in Directory.EnumerateDirectories(file))
			{
				baselineFolders.Add(dirName);
				string formattedName = dirName.Replace(@"C:\KWDT Temp Repo\Test Results\Baseline Screenshots\" + KWDT.Core.TestExecution.TestResultLogger.GetSuiteType() + @"s\", "");

				if (formattedName.Equals(_testRun.Name.Replace("- COMPARE", "- BASELINE")))
				{
					foreach (string fileName in Directory.EnumerateFiles(file + formattedName))
					{
						foreach (var elem in fileName.Split(' ').ToList())
						{
							if (elem.Contains(".png"))
								name = elem;
						}

                        if (name != null && !baselineScreenshots.Contains(name))
                        {
                            baselineScreenshots.Add(name);
                            baselineScreenshotsFilePaths.Add(fileName);
                        }
					}
				}
			}

            //compares all screenshots from the compareScreenshots list and baselineScreenshots 
            //only identical matches will be used in comparison tool
			if (compareScreenshots.Count > 0 && baselineScreenshots.Count > 0)
			{
                if (Directory.Exists("C:\\KWDT Temp Repo\\Test Results\\Screenshot Comparison Results\\" + KWDT.Core.TestExecution.TestResultLogger.GetSuiteType() + "s\\" + _testRun.Name))
                    Directory.Delete("C:\\KWDT Temp Repo\\Test Results\\Screenshot Comparison Results\\" + KWDT.Core.TestExecution.TestResultLogger.GetSuiteType() + "s\\" + _testRun.Name, true);

                //puts all unique screenshot names from Screenshots folder into a list
                foreach (String screenshot in compareScreenshots)
                {
                    if (baselineScreenshots.Contains(screenshot))
                    {
                        if (!TestResultLogger.IdenticalImages(baselineScreenshotsFilePaths[baselineScreenshots.IndexOf(screenshot)], compareScreenshotsFilePaths[compareScreenshots.IndexOf(screenshot)]))
                        {
                            ChromeOptions option = new ChromeOptions();
                            option.AddArgument("--headless");
                            driver = new ChromeDriver(@"C:\DevTools\Foundation-QA\Hopper\Selenium Drivers", option);

                            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                            driver.Url = "https://huddleeng.github.io/Resemble.js/";

                            IWebElement image1 = driver.FindElement(By.Id("dropzone1"));
                            image1.Click();
                            KWDT.Core.TestExecution.TestResultLogger.DropFile(driver, baselineScreenshotsFilePaths[baselineScreenshots.IndexOf(screenshot)], image1, 0, 0);

                            //foreach (string fileName in Directory.EnumerateFiles(@"C:\KWDT Temp Repo\Test Results\Baseline Screenshots\" + KWDT.Core.TestExecution.TestResultLogger.GetSuiteType() + @"s\" + _testRun.Name.Replace("- COMPARE", "- BASELINE")))
                            //{
                            //    foreach (var elem in fileName.Split(' ').ToList())
                            //    {
                            //        if (elem.Contains(".png"))
                            //            name = elem;
                            //    }

                            //    foreach (var compareFile in compareScreenshots)
                            //    {
                            //        if (fileName.Contains(name))
                            //        {
                            //            KWDT.Core.TestExecution.TestResultLogger.DropFile(driver, fileName, image1, 0, 0);
                            //        }
                            //    }
                            //}
                            // drop the file
                            //KWDT.Core.TestExecution.TestResultLogger.DropFile(driver, @"C:\KWDT Temp Repo\Test Results\Screenshots\Test Cases\OLA - Workflow - INCOME SCREENS 09-18-2018\ Step 1 - SignInPage.png", image1, 0, 0);


                            IWebElement image2 = driver.FindElement(By.Id("dropzone2"));
                            image2.Click();
                            KWDT.Core.TestExecution.TestResultLogger.DropFile(driver, compareScreenshotsFilePaths[compareScreenshots.IndexOf(screenshot)], image2, 0, 0);

                            //foreach (string fileName in Directory.EnumerateFiles(@"C:\KWDT Temp Repo\Test Results\Screenshots\" + KWDT.Core.TestExecution.TestResultLogger.GetSuiteType() + @"s\" + _testRun.Name + " " + DateTime.Now.ToString("MM-dd-yyyy")))
                            //{
                            //    foreach (var elem in fileName.Split(' ').ToList())
                            //    {
                            //        if (elem.Contains(".png"))
                            //            name = elem;
                            //    }

                            //    foreach (var compareFile in compareScreenshots)
                            //    {
                            //        if (fileName.Contains(name))
                            //        {
                            //            KWDT.Core.TestExecution.TestResultLogger.DropFile(driver, fileName, image2, 0, 0);
                            //        }
                            //    }
                            //}
                            // drop the file
                            //KWDT.Core.TestExecution.TestResultLogger.DropFile(driver, @"C:\KWDT Temp Repo\Test Results\Screenshots\Test Cases\OLA - Workflow - INCOME SCREENS 09-18-2018\ Step 2 - SignInPage.png", image2, 0, 0);

                            IWebElement antialising = driver.FindElement(By.Id("antialising"));
                            antialising.Click();
                            IWebElement resultImage = driver.FindElement(By.CssSelector("#image-diff > img"));
                            resultImage.Click();
                            driver.SwitchTo().Window(driver.WindowHandles[1]);

                            KWDT.Core.TestExecution.TestResultLogger.ScreenshotCompare(driver, screenshot);
                            driver.Quit();
                        }
                    }
                }
			}
		}

		private void openScreenCompareResults_Click(object sender, RoutedEventArgs e)
		{
			Process.Start("C:\\KWDT Temp Repo\\Test Results\\Screenshot Comparison Results\\");
		}

        void datagrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = e.Row.GetIndex();
        }

        private void AttachToVSTS_Click(object sender, RoutedEventArgs e)
        {
            VSTSidLabel.IsEnabled = (bool)AttachToVSTS.IsChecked;
            VSTSid.IsEnabled = (bool)AttachToVSTS.IsChecked;

            if (!(bool)AttachToVSTS.IsChecked)
            {
                KWDT.Core.Utilities.SetVSTSItemID(null);
                VSTSid.Clear();
            }
        }

        //private void CreateTestRun_Click(object sender, RoutedEventArgs e)
        //{
        //    TestPointidLabel.IsEnabled = (bool)CreateTestRun.IsChecked;
        //    TestPointid.IsEnabled = (bool)CreateTestRun.IsChecked;
        //    TestPlanidLabel.IsEnabled = (bool)CreateTestRun.IsChecked;
        //    TestPlanid.IsEnabled = (bool)CreateTestRun.IsChecked;

        //    if (!(bool)CreateTestRun.IsChecked)
        //    {
        //        KWDT.Core.Utilities.SetTestPlanID(null);
        //        TestPlanid.Clear();
        //        KWDT.Core.Utilities.SetTestPointID(null);
        //        TestPointid.Clear();
        //    }
        //}
    }
}