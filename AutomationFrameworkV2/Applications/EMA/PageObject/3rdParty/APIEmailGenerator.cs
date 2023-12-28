using System;
using mailslurp.Api;
using mailslurp.Client;
using mailslurp_netstandard_2x.Api;
using NPOI.SS.Formula.Functions;
using NUnit.Framework;

namespace API
{
    public class APIEmailGenerator
    {
        public static string EMAIL = "";
        private static Guid INBOX_ID;
        public static string EMAIL_CONTENT = "";
        public static string USERNAME = "";
        public static string VERIFICATION_CODE = "";
        private static string APIKEY = "2d9fff80af52ff1579d948f28f1233f79804af6565ba5b2d64231d7bb241f315";
        private static Configuration config = new mailslurp.Client.Configuration();

        public static void ConfigureClient()
        {
            var config = new mailslurp.Client.Configuration();
            config.ApiKey.Add("x-api-key", APIKEY);
            var inboxController = new mailslurp.Api.InboxControllerApi(config);
            var inbox = inboxController.CreateInboxWithDefaults();
            Assert.IsTrue(inbox.EmailAddress.Contains("@mailslurp"));

            EMAIL = inbox.EmailAddress;
            INBOX_ID = inbox.Id;
        }

        public static string GetFullEmailContent()
        {
            try
            {
                config.ApiKey.Add("x-api-key", APIKEY);
            } catch(ArgumentException) { }
            var waitForControllerApi = new mailslurp.Api.WaitForControllerApi(config);
            var emailContext = waitForControllerApi.WaitForLatestEmail(
                inboxId: INBOX_ID,
                timeout: 60_000,
                unreadOnly: true
            );

            return emailContext.ToString();
        }

        public static void GetVerificationCode(string client)
        {
            string str;
            var emailContext = GetFullEmailContent();
            str = emailContext.ToString();
            while(str.Contains("Confirm a change"))
            {
                emailContext = GetFullEmailContent();
                str = emailContext.ToString();
            }
            
            if (client.Equals("Florida"))
            {
                int idx = str.IndexOf("is:");
                if(idx != -1) str = str.Remove(0, idx);
                var str2 = str.Substring(0, str.IndexOf("=") + 1);
                var str3 = str2.Substring(str2.IndexOf(">") + 1);
                VERIFICATION_CODE = str3.Substring(0, str3.IndexOf("<"));
            } else
            {
                int idx = str.IndexOf("is:");
                if(idx != -1) str = str.Remove(0, idx);
                var str2 = str.Substring(0, str.IndexOf("."));
                VERIFICATION_CODE = str2.Replace("is: ", "");
            }
        }

        public static void GetUsernameCode()
        {
            string str;
            var emailContext = GetFullEmailContent();
            str = emailContext.ToString();
            while(str.Contains("Confirm a change"))
            {
                emailContext = GetFullEmailContent();
                str = emailContext.ToString();
            }

            int idx = str.IndexOf(" username is ");
            if(idx != -1) str = str.Remove(0, idx);
            var str2 = str.Substring(0, str.IndexOf(". ") + 0);
            USERNAME = str2.Substring(str2.IndexOf("is ") + 3);
        }

        public static void ClearAllCodes()
        {
            EMAIL = null;
            USERNAME = null;
            EMAIL_CONTENT = null;
            VERIFICATION_CODE = null;
    }

    }
}
