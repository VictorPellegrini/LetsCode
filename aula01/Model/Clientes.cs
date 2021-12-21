using System;
using System.Collections.Generic;
using System.Linq;

namespace aula01.Model
{
    public class Clientes {
      
        private List<Pessoa> clientes { get; private set;}

        public void cadastrarClientePf(ClientePf clientePf)
        {
            clientes.Add(clientePf);
        }

        public void cadastrarClientePj(ClientePj clientePj)
        {
            clientes.Add(clientePj);
        }

        public Pessoa buscarClienteId(string id)
        { 
            return clientes.First(cliente => cliente.id == id);
        }

        public Pessoa buscarClientePorNome(string nome)
        { 
            return clientes.First(cliente => cliente.nome == nome);
        }

        public bool atualizarClientePf (ClientePf clientePf)
        {            
            var cliente = buscarClienteId(clientePf.id);               
            
            if(cliente != null){
                cliente = clientePf;
                return true;
            }

            return false;
        }

        public bool atualizarClientePj (ClientePj clientePj)
        {            
            var cliente = buscarClienteId(clientePj.id);               
            
            if(cliente != null){
                cliente = clientePj;
                return true;
            }

            return false;
        }
    }   
}