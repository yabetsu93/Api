using System.Threading.Tasks;
using Api.Models.Database;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.TestControllers
{
    public class testController : Controller
    {
        private readonly ApplicationDbContext _appDbContext;

        public testController(ApplicationDbContext appDbContext)
        {
            this._appDbContext = appDbContext;
        }

        [HttpGet("api/v0/testing/getInfo")]
        public async Task<JsonResult> getSampleInfo()
        {
           return Json("hello world hahahahah");
        }
    }
}