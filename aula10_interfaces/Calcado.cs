using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula10_interfaces
{
    public class Calcado : IItemEstoque
    {
        public int numero { get; set; }
        public void Vender()
        {
            //comandos
        }
        public void Devolver()
        {
            //commandos
        }
    }
}