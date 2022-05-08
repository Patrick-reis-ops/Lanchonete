using LanchoneteAbstractFactory.DOMAIN;
using LanchoneteAbstractFactory.DOMAIN.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteAbstractFactory.FACTORY
{
    public class FabricaSanduiche : FabricaPao
    {
        public override Pao GetTipoPao(TipoPao tipoProduto) //Retornando instancia produto Final, Utilizando (Enums Tipo Sanduiche) como parametro
        {
            var sanduba = (TipoSanduiche)tipoProduto;

            switch (sanduba)
            {
                case TipoSanduiche.Salada:
                    return new SanduicheSalada();
                case TipoSanduiche.Vegetariano:
                    return new SanduicheVegetariano();
                default: throw new ArgumentException("Opção Inválida");
            }

        }
    }
}
