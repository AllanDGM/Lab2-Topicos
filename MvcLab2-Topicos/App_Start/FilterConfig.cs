using System.Web;
using System.Web.Mvc;

namespace MvcLab2_Topicos
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}