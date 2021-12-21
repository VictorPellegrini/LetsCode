using System;
using System.Collections.Generic;
using System.Linq;

namespace aula01.Model
{
    public class Vendas 
    {
        private List<Venda> vendas { get; private set;}

        public void registrarVenda(Venda venda)
        {
            vendas.Add(venda);
        }

        public Venda buscarVendaPorId(string id)
        { 
            return vendas.First(venda => venda.id == id);
        }

        public Venda buscarVendaPorCliente(ClientePf clientePf, ClientePj clientePj)
        { 
            if(clientePf is null)
                return vendas.First(venda => venda.clientePj.id == clientePj.id);
            else
                return vendas.First(venda => venda.clientePf.id == clientePf.id);
        }

        public bool permitirVenda(Venda venda)
        {
            if (venda.clientePf is null && venda.clientePj is null)
                return true
        }
    }   
}