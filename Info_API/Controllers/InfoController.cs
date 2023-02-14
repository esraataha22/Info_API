using Microsoft.AspNetCore.Mvc;

namespace Info_API.Controllers
{
    [Route("api/Info")]
    [ApiController]
    public class InfoController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Models.Info> GetInfoes()
        {
            return new List<Models.Info>
            {
                new Models.Info{ Id = 1, First_Name = "Esraa", Last_Name = "Taha"},
                new Models.Info{ Id = 2,First_Name = "Ahmed", Last_Name = "Taha"}
            };
        }
    }
}
