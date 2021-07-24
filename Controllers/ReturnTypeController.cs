using Microsoft.AspNetCore.Mvc;

namespace InAndOut.Controllers
{
    public class ReturnTypeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        #region :: Status Code Result ::
        public IActionResult OkResult()
        {
            return Ok();
        }
        #endregion


    }
}
