using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using System.Threading;
using OpenQA.Selenium.Support.UI;

namespace AutomationFramework
{
    [KeywordTesting]
    public class FTCSASScholarshipChildrenStatusTable : WebElement
    {
        public FTCSASScholarshipChildrenStatusTable(IWebDriver driver, By locateBy, int index = 0)
            : base(driver, locateBy, index)
        { }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyAwardPercentageForAllStudentsEquals(string award)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (!lineAmounts[4].Text.Equals(award))
                        return false;
                }
            }

            return true;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyAwardPercentageForKindergartenStudentEquals(string award)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[1].Text.Equals("Kindergarten"))
                        return (lineAmounts[4].Text.Equals(award));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyAwardPercentageForFirstGradeStudentEquals(string award)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[1].Text.Equals("First"))
                        return (lineAmounts[4].Text.Equals(award));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyAwardPercentageForSecondGradeStudentEquals(string award)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[1].Text.Equals("Second"))
                        return (lineAmounts[4].Text.Equals(award));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyAwardPercentageForThirdGradeStudentEquals(string award)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[1].Text.Equals("Third"))
                        return (lineAmounts[4].Text.Equals(award));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyAwardPercentageForFourthGradeStudentEquals(string award)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[1].Text.Equals("Fourth"))
                        return (lineAmounts[4].Text.Equals(award));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyAwardPercentageForFifthGradeStudentEquals(string award)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[1].Text.Equals("Fifth"))
                        return (lineAmounts[4].Text.Equals(award));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyAwardPercentageForSixthGradeStudentEquals(string award)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[1].Text.Equals("Sixth"))
                        return (lineAmounts[4].Text.Equals(award));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyAwardPercentageForSeventhGradeStudentEquals(string award)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[1].Text.Equals("Seventh"))
                        return (lineAmounts[4].Text.Equals(award));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyAwardPercentageForEighthGradeStudentEquals(string award)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[1].Text.Equals("Eighth"))
                        return (lineAmounts[4].Text.Equals(award));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyAwardPercentageForNinthGradeStudentEquals(string award)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[1].Text.Equals("Ninth"))
                        return (lineAmounts[4].Text.Equals(award));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyAwardPercentageForTenthGradeStudentEquals(string award)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[1].Text.Equals("Tenth"))
                        return (lineAmounts[4].Text.Equals(award));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyAwardPercentageForEleventhGradeStudentEquals(string award)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[1].Text.Equals("Eleventh"))
                        return (lineAmounts[4].Text.Equals(award));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyAwardPercentageForTwelfthGradeStudentEquals(string award)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[1].Text.Equals("Twelfth"))
                        return (lineAmounts[4].Text.Equals(award));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyAwardAmountForKindergartenStudentEquals(string award)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[1].Text.Equals("Kindergarten"))
                        return (lineAmounts[5].Text.Equals(award));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyAwardAmountForFirstGradeStudentEquals(string award)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[1].Text.Equals("First"))
                        return (lineAmounts[5].Text.Equals(award));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyAwardAmountForSecondGradeStudentEquals(string award)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[1].Text.Equals("Second"))
                        return (lineAmounts[5].Text.Equals(award));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyAwardAmountForThirdGradeStudentEquals(string award)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[1].Text.Equals("Third"))
                        return (lineAmounts[5].Text.Equals(award));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyAwardAmountForFourthGradeStudentEquals(string award)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[1].Text.Equals("Fourth"))
                        return (lineAmounts[5].Text.Equals(award));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyAwardAmountForFifthGradeStudentEquals(string award)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[1].Text.Equals("Fifth"))
                        return (lineAmounts[5].Text.Equals(award));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyAwardAmountForSixthGradeStudentEquals(string award)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[1].Text.Equals("Sixth"))
                        return (lineAmounts[5].Text.Equals(award));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyAwardAmountForSeventhGradeStudentEquals(string award)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[1].Text.Equals("Seventh"))
                        return (lineAmounts[5].Text.Equals(award));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyAwardAmountForEighthGradeStudentEquals(string award)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[1].Text.Equals("Eighth"))
                        return (lineAmounts[5].Text.Equals(award));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyAwardAmountForNinthGradeStudentEquals(string award)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[1].Text.Equals("Ninth"))
                        return (lineAmounts[5].Text.Equals(award));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyAwardAmountForTenthGradeStudentEquals(string award)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[1].Text.Equals("Tenth"))
                        return (lineAmounts[5].Text.Equals(award));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyAwardAmountForEleventhGradeStudentEquals(string award)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[1].Text.Equals("Eleventh"))
                        return (lineAmounts[5].Text.Equals(award));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyAwardAmountForTwelfthGradeStudentEquals(string award)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[1].Text.Equals("Twelfth"))
                        return (lineAmounts[5].Text.Equals(award));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyScholarshipStatusByGradeLevel(string grade, string status)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[1].Text.Equals(grade))
                        return (lineAmounts[3].Text.Equals(status));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyScholarshipStatusByStudentName(string name, string status)
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (lineAmounts[0].Text.Equals(name))
                        return (lineAmounts[3].Text.Equals(status));
                }
            }

            return false;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyScholarshipStatusIsAwardedForAllStudents()
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (!lineAmounts[3].Text.Equals("Awarded"))
                        return false;
                }
            }

            return true;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyScholarshipStatusIsWaitlistForAllStudents()
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (!lineAmounts[3].Text.Equals("Wait List"))
                        return false;
                }
            }

            return true;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyScholarshipStatusIsDeniedForAllStudents()
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (!lineAmounts[3].Text.Equals("Denied"))
                        return false;
                }
            }

            return true;
        }

        [KeywordTestingFTCSASScholarshipChildrenStatusTable]
        public bool VerifyScholarshipStatusIsPendingForAllStudents()
        {
            IList<IWebElement> lineItems = this.FindElements(By.TagName("tr"));

            foreach (var lineItem in lineItems)
            {
                if (lineItems.IndexOf(lineItem) > 0)
                {
                    IList<IWebElement> lineAmounts = lineItem.FindElements(By.TagName("td"));

                    if (!lineAmounts[3].Text.Equals("Pending"))
                        return false;
                }
            }

            return true;
        }
    }
}
