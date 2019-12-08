using System.Web;
using System.Web.Mvc;

namespace dotNetFrameworkMVC_MoshProject
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
