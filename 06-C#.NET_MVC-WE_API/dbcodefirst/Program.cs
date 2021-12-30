using System;
using System.Linq;

namespace dbcodefirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var contexto = new AppDbContext())
            {
                var listaProdutos = new System.Collections.Generic.List<Produtos>
                {
                    new Produtos {Nome = "Caderno", Preco = 5.50M, Estoque = 10},
                    new Produtos {Nome = "Lápis", Preco = 3.40M, Estoque = 20}
                };
                contexto.Produtos.AddRange(listaProdutos);
                contexto.SaveChanges();
                ExibirProdutos(contexto);
            }
            Console.ReadLine();
        }
        private static void ExibirProdutos(AppDbContext db)
        {
            //exibir produtos
            var produtos = db.Produtos.ToList();
            foreach(var p in produtos)
            {
                Console.WriteLine(p.Nome + "\t" + p.Preco.ToString("c"));
            }
        }
    }
}
