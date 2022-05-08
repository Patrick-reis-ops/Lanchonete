using LanchoneteAbstractFactory.DOMAIN;
using LanchoneteAbstractFactory.DOMAIN.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteAbstractFactory.FACTORY
{
    public abstract class FabricaPao
    {
        public abstract Pao GetTipoPao(TipoPao tipoProduto); // Método herdado pelas subClasses que retornará instancia produto final DOMAIN

        public static FabricaPao GetFabrica(TipoPao tipoPao) // Metodo utiliza Enum no parametro,que retornara instancias das subClasses Factory (Fabrica Hamburguer, Sanduiche)
        {
            switch (tipoPao)
            {
                case TipoPao.Hamburguer:
                    return new FabricaHamburguer();
                    
                case TipoPao.Sanduiche:
                    return new FabricaSanduiche();
                    

                default: throw new ArgumentException("Naõ existe essa fábrica");
                    
            }
        }
    }
}
