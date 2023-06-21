using InjecaoDependencia.Models;
using Microsoft.AspNetCore.Mvc;

namespace InjecaoDependencia.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RenderController : ControllerBase
    {
        public readonly IRenderSingleton singleton1;
        public readonly IRenderSingleton singleton2;
        public readonly IRenderScoped scoped1;
        public readonly IRenderScoped scoped2;
        public readonly IRenderTransient transient1;
        public readonly IRenderTransient transient2;
        public RenderController(
            IRenderSingleton singleton1,
            IRenderSingleton singleton2,
            IRenderScoped scoped1,
            IRenderScoped scoped2,
            IRenderTransient transient1,
            IRenderTransient transient2            
        )
        {
            this.singleton1 = singleton1;
            this.singleton2 =singleton2;
            this.scoped1 = scoped1;
            this.scoped2 = scoped2;
            this.transient1 = transient1;
            this.transient2 = transient2;
        }

        [HttpGet]
        public ActionResult Get()
        {       
            var singletons = new string[2]
            {
                singleton1.GetGuidNow.ToString(),
                singleton2.GetGuidNow.ToString()
            };
            var scopeds = new string[2]
            {
                scoped1.GetGuidNow.ToString(),
                scoped2.GetGuidNow.ToString()
            };
            var transients = new string[2]
            {
                transient1.GetGuidNow.ToString(),
                transient2.GetGuidNow.ToString()
            };
            return Ok(new {            
                    s = singletons,
                    p = scopeds,
                    t = transients
                }
            );

        }
    }
}