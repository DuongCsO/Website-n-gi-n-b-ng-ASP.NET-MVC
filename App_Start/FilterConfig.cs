using System.Web;
using System.Web.Mvc;

namespace MVC_Exam_ECardDB
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
