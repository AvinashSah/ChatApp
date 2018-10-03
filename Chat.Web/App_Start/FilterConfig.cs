using System.Web.Mvc;
using System.Web;

namespace Chat.Web.App_Start
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            //Added to show custom error pages to end users
            filters.Add(new HandleErrorAttribute());
        }
    }
}