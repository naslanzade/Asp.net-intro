using Microsoft.AspNetCore.Mvc;

namespace AspNet_intro.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            int[] nums= {1,2,3,4,5,6,7,8};
             return View(nums);
        }
    }
}
