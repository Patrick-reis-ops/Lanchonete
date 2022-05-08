using LanchoneteAbstractFactory.DOMAIN.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LanchoneteAbstractFactory.DOMAIN
{
    public abstract class Pao // Classe Base para os Produtos (Hamburguer, Sanduiche)
    {
        public string Nome { get; set; }
        public TipoPao GetPao { get; set; }
        
        public ArrayList Ingredientes = new ArrayList();

        public Pao(string nome, TipoPao getPao)
        {
            Nome = nome;
            GetPao = getPao;
        }
    }
}
