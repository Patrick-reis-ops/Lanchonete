using LanchoneteAbstractFactory.DOMAIN.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteAbstractFactory.DOMAIN
{
    public class Hamburguer : Pao // Body
    {
        public Hamburguer(string nome, TipoPao getPao) : base(nome, getPao)
        {
        }
    }
}
