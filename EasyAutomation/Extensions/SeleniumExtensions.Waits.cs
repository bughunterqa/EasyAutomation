using EasyAutomation.Base;
using OpenQA.Selenium;

namespace EasyAutomation.Extensions
{
    public static partial class SeleniumExtensions
    {

        public static IWebElement WaitSeconds(this IWebElement element, int seconds = 2)
        {
            EasyWait.WaitSeconds(seconds);
            return element;
        }

        public static IWebElement WaitMilliseconds(this IWebElement element, int milliseconds = 500)
        {
            EasyWait.WaitMilliseconds(milliseconds);
            return element;
        }
        public static IWebElement WaitUntilClickable(this IWebElement element, int seconds = 10)
        {
            EasyWait.ToBeClickable(element, seconds);
            return element;
        }
        public static IWebElement WaitUntilVisible(this IWebElement element, int seconds = 10)
        {
            EasyWait.ToBeVisible(element, seconds);
            return element;
        }
        public static IWebElement WaitUntilHidden(this IWebElement element, int seconds = 10)
        {
            EasyWait.ToBeHidden(element, seconds);
            return element;
        }




    }
}
