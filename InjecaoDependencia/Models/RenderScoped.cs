using System;

namespace InjecaoDependencia.Models
{
    public class RenderScoped : IRenderScoped
    {
        public Guid GetGuidNow {get;} = Guid.NewGuid();
    }
}