using System;

namespace Aula
{
    public class Cartao
    {
        public int CodLista { get; set; }
        public string Titular { get; set; }
        public int Numero { get; set; }
        public string Bandeira { get; set; }
        public int Vencimento { get; set; }
        public int Cvv { get; set; }
          public Cartao(){

        }
        
        public Cartao(int _codLista, string _titular, int _numero, string _bandeira, int _vencimento, int _cvv ){
            this.CodLista = _codLista;
            this.Titular = _titular;
            this.Numero = _numero;
            this.Bandeira = _bandeira;
            this.Vencimento = _vencimento;
            this.Cvv = _cvv;
        }

    }

}