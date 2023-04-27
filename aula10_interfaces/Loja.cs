using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aula10_interfaces
{
    // Usando a classe Roupa com a interface IItemEstoque
    public class Loja
    {
        private List<IItemEstoque> _itensEmEstoque;
        private IItemEstoque item;
        
        public Loja()
        {
            item = new Roupa();

            
        }

        public void AdicionarItem(IItemEstoque item)
        {
            _itensEmEstoque.Add(item);
        }

        public void VenderItem(int index)
        {
            _itensEmEstoque[index].Vender();
            _itensEmEstoque.RemoveAt(index);
        }
    }
}