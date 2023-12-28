using System;
using System.Reflection;
using System.Threading;
using EthnicityGen;
using Interfaces;
using NLPLogix.Core.Abstract;
using OpenQA.Selenium;
using RandomNameGen;
using RandomRaceGen;
using RandomRelationshipToYouGen;
using RandomYesNoAns;
using ServiceStack;
using SuffixGen;
using TestSuite;

namespace SidePanelDashboard
{
    public class FindMyStudent : Widget
    {
        public FindMyStudent(IWebDriver driver) : base(driver)
        {
        }

        public FindMyStudent ClickFindStudents()
        {
            FindButton(By.XPath("(//div[@class='modal-content']//button)[2]")).Click();
            return this;
        }

        public FindMyStudent ClickProgram(string program)
        {
            if (program.Equals("UA"))
            {
                FindButton(By.XPath("(//div[@class='modal-content']//img)[1]")).Click();
            } else if(program.Equals("FTC"))
            {
                FindButton(By.XPath("(//div[@class='modal-content']//img)[2]")).Click();
            } else
            {
                FindButton(By.XPath("(//div[@class='modal-content']//img)[2]")).Click();
            }

            return this;
        }

        public FindMyStudent ClearEmail()
        {
            FindTextField(By.Id("username")).Clear();
            return this;
        }

        public FindMyStudent TypeEmail(string email)
        {
            FindTextField(By.Id("username")).Type(email);
            return this;
        }

        public FindMyStudent ClearPassword()
        {
            FindTextField(By.Id("password")).Clear();
            return this;
        }

        public FindMyStudent TypePassword(string password)
        {
            FindTextField(By.Id("password")).Type(password);
            return this;
        }

        public FindMyStudent ClickVerify()
        {
            FindButton(By.XPath("(//div[@class='modal-content']//button)[3]")).Click();
            return this;
        }

        public string GetAlert()
        {
            try
            {
                return FindText(By.XPath("//p[contains(@class,'danger')]")).GetText();
            } catch (WebDriverTimeoutException)
            {
                return "Error Not Visable";
            }
        }

    }
}
