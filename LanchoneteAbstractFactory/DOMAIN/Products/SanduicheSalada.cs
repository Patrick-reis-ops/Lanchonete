using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteAbstractFactory.DOMAIN
{
    sealed class SanduicheSalada : Sanduiche //Implementado body Sanduiche
    {
        public SanduicheSalada() : base("Sanduíche de Salada", Enums.TipoPao.Sanduiche)
        {
            Ingredientes.Add("Pão integral com salada e molho");
        }
    }
}
