using LanchoneteAbstractFactory.DOMAIN;
using LanchoneteAbstractFactory.DOMAIN.Enums;
using LanchoneteAbstractFactory.FACTORY;
using LanchoneteAbstractFactory.Methods;
using System;

namespace LanchoneteAbstractFactory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha os tipos de pão:");
            Console.Write("(1) Sanduíche (2) Hamburguer: ");
            int esc = int.Parse(Console.ReadLine());
            FabricaPao fabrica = FabricaPao.GetFabrica(GetEscolhas.GetPao(esc)); // método retornando subClasses Factory escolhido pelo cliente

            Console.WriteLine("Escolha o produto desejado: ");
            Pao PedidoFinal = fabrica.GetTipoPao(GetEscolhas.GetProduto(esc)); //Mostra no console as escolhas e retorna o produto final, referente a factory no parametro

            ExibeDetalhes(PedidoFinal);
            

            static void ExibeDetalhes(Pao pao) // Exibe os detalhes do pedido
            {
                Console.WriteLine("Detalhes do seu pedido:");
                Console.WriteLine($"Data_Horário: {DateTime.Now}");
                Console.WriteLine(pao.Nome);
                Console.WriteLine(pao.Ingredientes[0].ToString());
            }
            

        }
    }
}
