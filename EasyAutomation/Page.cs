using EasyAutomation.Base;
using SeleniumExtras.PageObjects;

namespace EasyAutomation
{
    public class Page
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Easy.SearchDriver, page);
            return page;
        }
    }
}
