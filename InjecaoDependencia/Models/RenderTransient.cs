using System;

namespace InjecaoDependencia.Models
{
    public class RenderTransient : IRenderTransient
    {
        public Guid GetGuidNow {get;} = Guid.NewGuid();

    }
}