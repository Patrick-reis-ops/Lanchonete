using LanchoneteAbstractFactory.DOMAIN;
using LanchoneteAbstractFactory.DOMAIN.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteAbstractFactory.FACTORY
{
    public class FabricaHamburguer : FabricaPao
    {
        public override Pao GetTipoPao(TipoPao tipoProduto) //Retornando instancia produto Final, Utilizando (Enums Tipo hamburguer) como parametro
        {
            var hamburguer = (TipoHamburguer) tipoProduto;

            switch (hamburguer)
            {
                case TipoHamburguer.Bacon:
                    return new HamburguerBacon();
                case TipoHamburguer.FileDeFrango:
                    return new HamburguerFileFrango();
                default: throw new Exception("Opção Inválida");
            }
        }
    }
}
