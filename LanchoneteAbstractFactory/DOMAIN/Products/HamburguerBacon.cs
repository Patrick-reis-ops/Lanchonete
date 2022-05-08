using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteAbstractFactory.DOMAIN
{
    public sealed class HamburguerBacon : Hamburguer //Implementado body hamburguer
    {
        public HamburguerBacon() : base("Hamburguer de Bacon", Enums.TipoPao.Hamburguer)
        {
            Ingredientes.Add("Pão de hamburguer com bacon e ovos");
        }
    }
}
