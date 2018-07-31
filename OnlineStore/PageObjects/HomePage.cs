using OnlineStore.Extensions;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace OnlineStore.PageObjects
{
    public class HomePage
    {
        [FindsBy(How = How.Id, Using = "account")][CacheLookup]
        private IWebElement MyAccount { get; set; }

        public void ClickOnMyAccount()
        {
            MyAccount.ClickOnIt("MyAccount");
        }
    }
}
