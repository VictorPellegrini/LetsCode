using System;
using System.Collections.Generic;

namespace aula01.Model 
{
    public class Estoque {
        public Dictonary<Produto, int> estoqueProdutos { get; private set;}

        public void cadastrarEstoque(Produto produto, int quantidade){
            if(!estoqueProdutos.ContainsKey(produto))
                estoqueProdutos.Add(produto, quantidade);
            else
                estoqueProdutos.Add(produto, estoqueProdutos[produto] + quantidade);
        }

        public bool diminuirEstoque(Produto produto, int quantidade){
             if(!estoqueProdutos.ContainsKey(produto)){
                  int produtos = estoqueProdutos[produto];

                  if(produtos > quantidade || produtos == quantidade){
                       estoqueProdutos.Add(produto, produtos - quantidade);
                       return true;
                  }
             }
             return false;           
        }

        public void atualizarEstoque(Dictonary<Produto, int> _estoqueProdutos){
            estoqueProdutos = _estoqueProdutos;
        }
    }
}