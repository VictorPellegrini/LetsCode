using System;

namespace aula01.Model
{
    public class ClientePf : Pessoa {
        public override void VerificaDocumento(string _documento) {
            if(_documento.Length == 11) {
                documento = _documento;
            }
        }
    }   
}