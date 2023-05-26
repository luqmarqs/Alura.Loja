using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alura.Loja.Testes.ConsoleApp
{
    public class ProdutoDAOEntity : IProdutoDAO, IDisposable
    {
        private LojaContext context;
        public ProdutoDAOEntity()
        {
            context= new LojaContext();
        }
        public void Adicionar(Produto p)
        {
            context.Produtos.Add(p);
            context.SaveChanges();
        }

        public void Atualizar(Produto p)
        {
            context.Produtos.Update(p);
            context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public IList<Produto> Produtos()
        {
            IList<Produto> produtos = context.Produtos.ToList();
            return produtos;
        }

        public void Remover(Produto p)
        {
            context.Produtos.Remove(p);
        }
    }
}
