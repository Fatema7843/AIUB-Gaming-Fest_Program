using System.Web;
using System.Web.Mvc;

namespace AIUB_GamingFest_fatema
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
