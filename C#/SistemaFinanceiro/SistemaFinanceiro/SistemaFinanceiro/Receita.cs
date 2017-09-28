using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaFinanceiro
{
    public class Receita
    {
        private string dataReceita;
        private string valor;
        private string origemDinheiro;

        public Receita(){
        
        }

        public Receita(string dataReceita, string valor, string origemDinheiro) {
            this.dataReceita = dataReceita;
            this.valor = valor;
            this.origemDinheiro = origemDinheiro;
        }

        public string getDataReceita() {
            return this.dataReceita;
        }
        public void setDataReceita(string novo) {
            this.dataReceita = novo;
        }

        public string getValor() {
            return this.valor;
        }
        public void setValor(string novo) {
            this.valor = novo;
        }

        public string getOrigemDinheiro() {
            return this.origemDinheiro;
        }
        public void setOrigemDinheiro(string novo) {
            this.origemDinheiro = novo;
        }
    }
}
