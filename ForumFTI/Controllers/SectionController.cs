using ForumFTI.DAL.Interfaces;
using ForumFTI.Domain.Models;
using ForumFTI.Models;
using Microsoft.AspNetCore.Mvc;


namespace ForumFTI.Controllers
{
    public class SectionController : Controller
    {
        public readonly IBaseInteface<Section> baseInteface;

        public SectionController(IBaseInteface<Section> baseInteface)
        {
            this.baseInteface = baseInteface;
        }

        [HttpGet]
        public async Task<IActionResult> GetSection()
        {
            var respouns = await baseInteface.GetAll();

            return View(respouns);
        }
    }
}
