using ForumFTI.Service.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace ForumFTI.Controllers
{
    public class SectionController : Controller
    {     

        private readonly ISectionService _sectionService;

        public SectionController(ISectionService sectionService)
        {
            _sectionService = sectionService;
        }

        [HttpGet]
        public async Task<IActionResult> GetSection()
        {

            var response = await _sectionService.GetSections();

            return View(response.Data);
        }
    }
}
