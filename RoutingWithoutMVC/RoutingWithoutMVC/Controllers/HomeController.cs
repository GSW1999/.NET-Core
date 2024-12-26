using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoutMVC.Controllers
{
    //[Route("Home")]
    //[Route("[controller]")]
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        [Route("")]
        //[Route("Home")]
        //[Route("Home/Index")]
        //[Route("Index")]
        [Route("~/")]     // this for blank url.
        [Route("~/Home")]
        //[Route("[action]")]
        public IActionResult Index()
        {
            return View();
        }

        //[Route("")]
        //[Route("Home")]
        //[Route("Home/Index")]
        //public IActionResult Data()
        //{
        //    return View("~/Views/Home/Index.cshtml");
        //}

        //[Route("Home/About")]
        //[Route("About")]
        //[Route("[action]")]
        public IActionResult About()
        {
            return View();
        }

        //[Route("Home/Detail/{id?}")]
        //[Route("Detail/{id?}")]
        //[Route("[action]/{id?}")]
        [Route("{id?}")]
        public int Detail(int? id)
        {
            return id??1;
        }
    }
}
