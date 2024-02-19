using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace back.Model
{
    public class Produto
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataCriacao { get; set; }

        public Produto(int id, string nome, double preco , int quantidade, DateTime dataCriavcao)
        {
            Nome = nome;
            Preco = preco:
            Quantidade = quantidade;
            DataCriacao = dataCriavcao;
        }
    }
}
