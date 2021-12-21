using System;
using System.Collections.Generic;
using aula01.Model;

namespace aula01.Model
{
	public class Produtos
	{
        private List<Produto> produtos { get; set; }

        public void CadastrarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        public void DeletarProduto(Produto produto)
        {
            produtos.Remove(produto);
        }

        public bool AtualizarProduto(Produto produto)
        {
            var produtoEncontrado = produtos.First(p => p.id == produto.id);

            if (produtoEncontrado != null)
            {
                produtoEncontrado = produto;
                return true;
            }
            
            return false;
        }
    }
}
