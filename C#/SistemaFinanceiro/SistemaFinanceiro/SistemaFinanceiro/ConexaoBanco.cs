using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace SistemaFinanceiro
{
    public class ConexaoBanco
    {
        private OleDbConnection conexao;
        // --- Inicio construtores ---
        public ConexaoBanco() {
            conexao = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=D:\SistemaFinanceiro\SistemaFinanceiro.mdb");        
        }
        // --- Fim construtores ---
        // --- Inicio Metodos ---
        public OleDbConnection GetConexao() {
            return this.conexao;
        }
        
        public void SetConexao(OleDbConnection conexao) {
            this.conexao = conexao;
        }

        public void abrirConexao() {
            conexao.Open();
        }

        public void fecharConexao() {
            conexao.Close();
        }
    }
}
