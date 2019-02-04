using System.Web;
using System.Web.Mvc;

namespace Travel_Content_Management_Editor
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
