using System.Web;
using System.Web.Mvc;

namespace yemekhane_otomasyon
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
