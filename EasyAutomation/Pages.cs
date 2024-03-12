using EasyAutomation.Base;
using SeleniumExtras.PageObjects;

namespace EasyAutomation
{
    class Pages
    {
        protected static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Easy.SearchDriver, page);
            return page;
        }
    }
}
