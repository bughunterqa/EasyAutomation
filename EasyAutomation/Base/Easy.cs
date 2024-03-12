using EasyAutomation.BrowserSettings;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace EasyAutomation.Base
{
    public class Easy 
    {
        private static IWebDriver _webDriver;

        public static void Initialize()
        {
            _webDriver = new ChromeDriver(new ChromeBase().ChromeOptions());
        }

        public static ISearchContext SearchDriver { get { return _webDriver; } }
        public static IWebDriver Driver { get { return _webDriver; } }
    }
}
