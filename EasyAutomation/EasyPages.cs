using EasyAutomation.Base;
using SeleniumExtras.PageObjects;

namespace EasyAutomation
{
    public class EasyPages
    {
        protected static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Easy.SearchDriver, page);
            return page;
        }
    }
}
