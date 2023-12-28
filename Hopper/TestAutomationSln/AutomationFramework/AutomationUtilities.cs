using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AutomationFramework
{
    public static class AutomationUtilities
    {
        private static Random rando;
        private static int pageWaitTime;
        private static string stringInjectionText = string.Empty;

        static AutomationUtilities()
        {
            rando = new Random();
        }

        public static void SetPageWaitTime(int waitTime = 10)
        {
            pageWaitTime = waitTime;
        }

        public static void SetStringInjectionText(string text)
        {
            stringInjectionText = text;
        }

        public static int GetPageWaitTime()
        {
            return pageWaitTime;
        }

        public static string GetStringInjectionText()
        {
            return stringInjectionText;
        }

        public static string DigitString(int length)
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                int num = rando.Next(0, 10);
                output.Append(num);
            }

            return output.ToString();
        }

        public static string CharacterString(int length, bool capitalize = true)
        {
            List<char> _characters = new List<char>();

            // Fill character list with A-Z.
            //for (int i = 65; i <= 90; i++)
            //{
            //    _characters.Add((char)i);
            //}

            // Fill character list with a-z.
            for (int i = 97; i <= 122; i++)
            {
                _characters.Add((char)i);
            }

            StringBuilder output = new StringBuilder();
            for (int i = 0; i < length; i++)
            {
                int charIndex = (char)rando.Next(0, _characters.Count);
                char chr = _characters[charIndex];
                output.Append(chr);
            }
            //return output.ToString();
            return capitalize ? char.ToUpper(output[0]) + output.ToString().Substring(1) : output.ToString();
        }

        public static void GatherObjects(IWebDriver driver)
        {
            List<string> declarations = new List<string>();
            List<string> initializations = new List<string>();

            List<IWebElement> legends = new List<IWebElement>(driver.FindElements(By.TagName("legend")));
            legends.ForEach(legend => legend.Click());

            List<IWebElement> links = new List<IWebElement>(driver.FindElements(By.TagName("a")));
            List<IWebElement> inputs = new List<IWebElement>(driver.FindElements(By.TagName("input")));

            var menuCalls = new List<string>();

            Action<IWebElement> getObjBits = delegate(IWebElement obj)
            {
                var objName = "";
                var findBy = "Id";
                var findUsing = "";

                var prop = obj.GetAttribute("id");
                if (prop == String.Empty)
                {
                    prop = obj.GetAttribute("name");
                    findBy = "Name";
                }
                if (prop == String.Empty)
                {
                    prop = obj.GetAttribute("class");
                    findBy = "ClassName";
                }
                if (prop == String.Empty)
                {
                    prop = "NeedsWork";
                    findBy = "SomethingElse";
                }

                objName = prop;
                findUsing = prop;

                if (obj.TagName == "a" && findBy == "ClassName")
                {
                    if (driver.FindElements(By.ClassName(findUsing)).Count > 1)
                    {
                        findBy = "LinkText";
                        findUsing = obj.Text;
                        objName = findUsing.Replace(" ", String.Empty);

                        menuCalls.Add(String.Format("\t\tpublic void Open{0}()\r\n\t\t{{\r\n\t\t\t{0}.Click();\r\n\t\t\tWaitForPageLoad();\r\n\t\t}}\r\n", objName));
                    }
                }

                declarations.Add(String.Format("\t\tpublic WebElement {0} {{ get; private set; }}\r\n", objName));
                initializations.Add(String.Format("\t\t\t{0} = new WebElement(driver, By.{1}(\"{2}\"));", objName, findBy, findUsing));
            };

            links.ForEach(link => getObjBits(link));
            inputs.ForEach(input => getObjBits(input));

            var codeDump = new List<string>();
            codeDump.AddRange(declarations);
            codeDump.Add("\r\n");
            codeDump.Add("\r\n");
            codeDump.AddRange(initializations);
            codeDump.Add("\r\n");
            codeDump.Add("\r\n");
            codeDump.AddRange(menuCalls);

            File.WriteAllLines("C:/ObjDumps/Dump.txt", codeDump);
        }
        
        public static string NumberToOrdinal(string num)
        {
            switch (num)
            {
                case "1":
                    return num + "st";
                case "2":
                    return num + "nd";
                case "3":
                    return num + "rd";
                default:
                    return num + "th";
            }
        }
    }
}
