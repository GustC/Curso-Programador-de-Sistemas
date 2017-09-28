using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace SistemaFinanceiro
{
    public class RepositorioReceita
    {
        private ConexaoBanco conexao;

        public RepositorioReceita() {
            conexao = new ConexaoBanco();
        }

        public bool ReceitaExiste(string data) {
            bool resp = false;

            try {
                this.conexao.abrirConexao();
                OleDbCommand comando = new OleDbCommand
                ("Select dataReceita From Receita"+
                " Where dataReceita = '"+data+"'",this.conexao.GetConexao());
                OleDbDataReader leitura = comando.ExecuteReader();
                if (leitura.Read()) {
                    resp = true;
                }
                this.conexao.fecharConexao();
            }catch(OleDbException erro){
                Console.Out.WriteLine("Erro : " + erro.Message);
            }
            return resp;
        }

        public bool CadastrarReceita(Receita receita) {
            bool resp = false;

            try
            {
                this.conexao.abrirConexao();

                OleDbCommand comando = new OleDbCommand
                ("Insert into Receita(dataReceita,valor,origemDinheiro) "+
                "Values('"+(receita.getDataReceita())+"','"+(receita.getValor())+"','"+(receita.getOrigemDinheiro())+"')",
                this.conexao.GetConexao());

                comando.ExecuteNonQuery();

                resp = true;
                this.conexao.fecharConexao();
            }
            catch (OleDbException erro) {
                Console.Out.WriteLine("Erro : " + erro.Message);
            }
            return resp;
        }

        public Receita ConsultarReceitaData(string data) {
            Receita receita = new Receita();
            try {
                this.conexao.abrirConexao();

                OleDbCommand comando = new OleDbCommand
                ("Select dataReceita,valor,origemDinheiro From Receita "+
                "Where dataReceita = '"+data+"'",this.conexao.GetConexao());
                OleDbDataReader leitura = comando.ExecuteReader();
                if (leitura.Read()) {
                    receita.setDataReceita(leitura.GetString(0));
                    receita.setValor(leitura.GetString(1));
                    receita.setOrigemDinheiro(leitura.GetString(2));
                }
                this.conexao.fecharConexao();
            }catch(OleDbException erro){
                Console.Out.WriteLine("Erro : " + erro);
            }
            return receita;
        }

        public bool AlterarReceita(Receita receita,string data) {
            bool resp = false;
            try {
                this.conexao.abrirConexao();

                OleDbCommand comando = new OleDbCommand
                ("Update Receita Set dataReceita = '"+(receita.getDataReceita())+"',"+
                " valor = '"+(receita.getValor())+"', origemDinheiro = '"+(receita.getOrigemDinheiro())+"'",this.conexao.GetConexao());

                comando.ExecuteNonQuery();

                resp = true;

                this.conexao.fecharConexao();
            }
            catch(OleDbException erro){
                Console.Out.WriteLine("Erro : "+erro.Message);
            }

            return resp;
        }

        public bool ExcluirReceita(string data) {
            bool resp = false;

            try {
                this.conexao.abrirConexao();

                OleDbCommand comando = new OleDbCommand
                ("Delete * From Receita Where dataReceita = '"+data+"'", this.conexao.GetConexao());
                comando.ExecuteNonQuery();
                resp = true;
                this.conexao.fecharConexao();
            }
            catch(OleDbException erro){
                Console.Out.WriteLine("Erro : " + erro.Message);
            }
            return resp;
        }

    }
}
