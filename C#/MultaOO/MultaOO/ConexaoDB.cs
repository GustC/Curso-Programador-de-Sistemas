using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace MultaOO
{
    public class ConexaoDB
    {
        private OleDbConnection conexao;
        // --- Inicio construtores ---
        public ConexaoDB() {
            conexao = new OleDbConnection(@"Provide=Microsoft.Jet.OLE.4.0;Data Source=C:\Users\Aluno\Documents\SistemaMulta.mdb");
        
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
