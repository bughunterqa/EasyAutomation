using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyAutomation.Base;
using BugHunterWait;

namespace EasyAutomation
{
    public static class EasyWait
    {
        public static void WaitSeconds(int seconds = 2) => Task.Delay(TimeSpan.FromSeconds(seconds)).Wait();
        public static void WaitMilliseconds(int milliseconds = 500) => Task.Delay(TimeSpan.FromMilliseconds(milliseconds)).Wait();


        public static void ToBeVisible(IWebElement element, int seconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(Easy.Driver, TimeSpan.FromSeconds(seconds));
            wait.Until(Expected.ElementIsVisible(element));
        }

        public static void ToBeClickable(IWebElement element, int seconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(Easy.Driver, TimeSpan.FromSeconds(seconds));
            wait.Until(ExpectedConditions.ElementToBeClickable(element));
        }

        public static void ToBeVisibleByLocator(By locator, int seconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(Easy.Driver, TimeSpan.FromSeconds(seconds));
            wait.Until(ExpectedConditions.ElementIsVisible(locator));
        }

        public static void ToBeHidden(IWebElement element, int seconds = 10)
        {
            WebDriverWait wait = new WebDriverWait(Easy.Driver, TimeSpan.FromSeconds(seconds));
            wait.Until(Expected.ElementIsInvisible(element));
        }

        public static void ContainsText(IWebElement element, string value, int seconds = 10)
        {
            WebDriverWait wait = new(Easy.Driver, TimeSpan.FromSeconds(seconds));
            wait.Until(Expected.ElementTextIsEqualTo(element, value));
        }

        public static void ContainsValue(IWebElement element, string value, int seconds = 10)
        {
            WebDriverWait wait = new(Easy.Driver, TimeSpan.FromSeconds(seconds));
            wait.Until(Expected.ElementValueIsEqualTo(element, value));
        }


        public static WebDriverWait WaitDriver(int seconds = 10)
        {
            return new WebDriverWait(Easy.Driver, TimeSpan.FromSeconds(seconds));
        }

        public static void RowsNumberIs(int count, int seconds = 10)
        {
            new WebDriverWait(Easy.Driver, TimeSpan.FromSeconds(seconds)).
                Until(x => x.FindElements(By.XPath("//table/tbody/tr")).Count == count);
        }
    }
}
