using System.Collections.Generic;

namespace aula01.Model 
{
    public class Venda 
    {
        public int id { get; set; }
        public ClientePf clientePf { get; set; }
        public ClientePj clientePj { get; set; }
        public decimal valorTotal { get; set; }
        public List<Produto> produtos { get; set; }
    }
}