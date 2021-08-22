using Microsoft.AspNetCore.Mvc;

namespace restapi.Controllers
{
    [ApiController]
    [Route("")]
    public class Controller : ControllerBase
    {
        private Worker _worker;

        public Controller(Worker worker)
        {
            _worker = worker;
        }
        [HttpGet]
        public int GetCount()
        {
            return _worker.Counter;
        }
    }
}
