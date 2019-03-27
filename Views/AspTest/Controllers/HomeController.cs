using System.Web.Mvc;

namespace AspTest.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
		{
			return this.Content("<h1>RERER<h2>");
		}
    }
}