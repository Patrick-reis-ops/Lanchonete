using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteAbstractFactory.DOMAIN
{
    sealed class HamburguerFileFrango : Hamburguer //Implementado body hamburguer
    {
        public HamburguerFileFrango() : base("Hamburguer de Filé de Frango", Enums.TipoPao.Hamburguer)
        {
            Ingredientes.Add("Pão de hamburguer com filé de frango e ovos");
        }
    }
}
