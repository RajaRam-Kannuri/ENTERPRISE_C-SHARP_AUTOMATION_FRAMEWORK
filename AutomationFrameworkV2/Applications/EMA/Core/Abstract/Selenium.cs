using System;
using System.Security.Cryptography;
using FileIO;
using Microsoft.TeamFoundation.Build.WebApi;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace NLPLogix.Core.Abstract
{
    public abstract class Selenium : Environmental.NLPLogix
    {

        private Environmental.NLPLogix NLPLogix;
        public static string SETCLIENT;

        protected Environmental.NLPLogix GetNLPLogix(string client)
        {
            SETCLIENT = client;
            if(NLPLogix == null)
            {
                NLPLogix = new Environmental.NLPLogix();
            }
            else
            {
                NLPLogix.Destroy();
                NLPLogix = new Environmental.NLPLogix();
            }
            return NLPLogix;
        }


        [TearDown]
        public void TestCaseCleanup()
        {
            SoftAssertion.SoftAssert SoftAssert = new SoftAssertion.SoftAssert();
            SoftAssert.ClearFailedAsserts();
            try
            {
                if(NLPLogix != null)
                {
                    NLPLogix.Destroy();
                }
            }
            catch(UnauthorizedAccessException) { }
        }

    }
}
