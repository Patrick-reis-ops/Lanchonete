using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteAbstractFactory.DOMAIN
{
    sealed class SanduicheVegetariano : Sanduiche //Implementado body Sanduiche
    {
        public SanduicheVegetariano() : base("Sanduíche Vegetariano", Enums.TipoPao.Sanduiche)
        {
            Ingredientes.Add("Sanduíche com vegetais e molho vegetal");
        }
    }
}
