using System;
using System.Collections.Generic;
using System.Linq;
using aula01.Model;

public class Filiais
    {
        public List<Filial> filiais { get; private set;}
        
        public void cadastrarFilial(Filial filial){ 
            filiais.Add(filial);
        }

        public Filial buscarFilialId(string id){ 
            return filiais.First(filial => filial.id == id);
        }

        public Filial buscarFilialPorNome(string nome){ 
            return filiais.First(filial => filial.nome == nome);
        }

        public bool atualizarFilial (Filial filial){            

            var filialEncontrada = buscarFilialId(filial.id);               
            
            if(filialEncontrada != null){
                filialEncontrada = filial;
                return true;
            }

            return false;
        }
    }
