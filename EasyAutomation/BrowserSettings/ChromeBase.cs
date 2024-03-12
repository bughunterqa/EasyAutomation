using OpenQA.Selenium.Chrome;

namespace EasyAutomation.BrowserSettings
{
     class ChromeBase
    {
        public ChromeOptions ChromeOptions()
        {
            ChromeOptions options = new ChromeOptions();

            options.AddArguments("--lang=en");
            options.AddArgument("--start-maximized"); 

            return options;
        }
    }
}
