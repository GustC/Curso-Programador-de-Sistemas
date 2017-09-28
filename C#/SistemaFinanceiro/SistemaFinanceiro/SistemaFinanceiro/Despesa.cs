using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaFinanceiro
{
    public class Despesa
    {
        private string dataPagamento, valor, descricaoPagamento;

        public Despesa() { 
        
        }

        public Despesa(string dataPagamento, string valor, string descricaoPagamanto) {
            this.dataPagamento = dataPagamento;
            this.valor = valor;
            this.descricaoPagamento = descricaoPagamanto;
        }

        public string getDataPagamento() {
            return this.dataPagamento;
        }
        public void setDataPagamento(string novo) {
            this.dataPagamento = novo;
        }

        public string getValor()
        {
            return this.valor;
        }
        public void setValor(string novo)
        {
            this.valor = novo;
        }

        public string getDescricaoPagamento()
        {
            return this.descricaoPagamento;
        }
        public void setDescricaoPagamento(string novo)
        {
            this.descricaoPagamento = novo;
        }


    }
}
