using LanchoneteAbstractFactory.DOMAIN;
using LanchoneteAbstractFactory.DOMAIN.Enums;
using LanchoneteAbstractFactory.FACTORY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteAbstractFactory.Methods
{
    public class GetEscolhas
    {
        
        public static TipoPao GetPao(int number) // Retornando Enums (sanduiche ou hamburguer) atraves da escolha do cliente (number)
        {
            switch (number)
            {
                case 1:
                    return TipoPao.Sanduiche;
                    case 2:
                        return TipoPao.Hamburguer;
                default: throw new ArgumentException("Tipo escolhido não existe");
            }
        }

        public static TipoPao GetProduto(int fabrica) //Mostrando no console as escolhas e retornando Tipo Enum, referente ao tipo no parametro(GetPao)
        {
            TipoPao resul = TipoPao.Hamburguer; // Apenas inicializando a variável
            if (fabrica == 1)
            {
                Console.WriteLine("(1) Sanduiche de Salada (2) Sanduiche Vegetariano:");
                 int escolha = int.Parse(Console.ReadLine());
                if (escolha == 1)
                {
                    resul = (TipoPao)TipoSanduiche.Salada;
                }
                else if (escolha == 2)
                {
                    resul = (TipoPao)TipoSanduiche.Vegetariano;
                }
            }
            else if (fabrica == 2)
            {
                Console.WriteLine("(1) Hamburguer de Bacon (2) Hamburguer Filé de Frango:");
                int escolha = int.Parse(Console.ReadLine());
                if (escolha == 1)
                {
                    resul = (TipoPao)TipoHamburguer.Bacon;
                }
                else if (escolha == 2)
                {
                    resul = (TipoPao)TipoHamburguer.FileDeFrango;
                }
            }
            return resul;
        }
    }
}
