using NUnit.Framework;
using OnlineStore.PageObjects;
using OnlineStore.WrapperFactory;
using System.Configuration;


namespace OnlineStore.TestCases
{
    class LoginTest
    {
        [Test]
        public void Test()
        {
            BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);

            Page.Home.ClickOnMyAccount();
            Page.Login.LoginToApplication("LoginTest");

            BrowserFactory.CloseAllDrivers();
        }
    }
}
