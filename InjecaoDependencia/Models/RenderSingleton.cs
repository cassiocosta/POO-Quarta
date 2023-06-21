using System;

namespace InjecaoDependencia.Models
{
    public class RenderSingleton : IRenderSingleton
    {
        public Guid GetGuidNow {get;} = Guid.NewGuid();

    }
}