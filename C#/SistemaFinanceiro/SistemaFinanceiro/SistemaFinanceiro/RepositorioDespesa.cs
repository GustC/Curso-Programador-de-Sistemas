using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace SistemaFinanceiro
{
    public class RepositorioDespesa
    {
        private ConexaoBanco conexao;

        public RepositorioDespesa() {
            conexao = new ConexaoBanco();
        }

        public bool DespesaExiste(string data){
            bool resp = false;

            try {
                this.conexao.abrirConexao();

                OleDbCommand comando = new OleDbCommand
                ("Select dataPagamento From Despesa"+
                " Where dataPagamento = '"+data+"'",this.conexao.GetConexao());
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

        public bool cadastrarDespesa(Despesa despesa) {
            bool resp = false;
            try {
                this.conexao.abrirConexao();

                OleDbCommand comando = new OleDbCommand
                ("Insert into Despesa(dataPagamento,valor,descricaoPagamento) "
                +"Values('"+(despesa.getDataPagamento())+"','"+(despesa.getValor())+"'"+
                ",'"+(despesa.getDescricaoPagamento())+"')",this.conexao.GetConexao());

                comando.ExecuteNonQuery();

                resp = true;

                this.conexao.fecharConexao();
            }
            catch(OleDbException erro){
                Console.Out.WriteLine("Erro : " + erro.Message);
            }
            return resp;
        }

        public Despesa ConsultarDespesa(string data) {
            Despesa despesa = new Despesa();

            try {
                this.conexao.abrirConexao();

                OleDbCommand comando = new OleDbCommand
                ("Select dataPagamento,valor,descricaoPagamento From Despesa "+
                "Where dataPagamento = '"+data+"'",this.conexao.GetConexao());

                OleDbDataReader leitura = comando.ExecuteReader();
                if (leitura.Read()) {
                    despesa.setDataPagamento(leitura.GetString(0));
                    despesa.setValor(leitura.GetString(1));
                    despesa.setDescricaoPagamento(leitura.GetString(2));
                }

                this.conexao.fecharConexao();
            }
            catch(OleDbException erro){
                Console.Out.WriteLine("Erro : " + erro.Message);
            }

            return despesa;
        }

        public bool AlterarDespesa(Despesa despesa,string data) {
            bool resp = false;

            try
            {
                this.conexao.abrirConexao();
                OleDbCommand comando = new OleDbCommand
                ("Update Despesa Set dataPagamento = '"+(despesa.getDataPagamento())+"',"+
                "valor = '"+(despesa.getValor())+"',descricaoPagamento = '"+(despesa.getDescricaoPagamento())+"'"
                , this.conexao.GetConexao());
                comando.ExecuteNonQuery();
                resp = true;

                this.conexao.fecharConexao();
            }
            catch (OleDbException erro) {
                Console.Out.WriteLine("Erro : " + erro.Message);            
            }

            return resp;
        }

        public bool ExcluirDespesa(string data) {
            bool resp = false;

            try {
                this.conexao.abrirConexao();

                OleDbCommand comando = new OleDbCommand
                ("Delete From Despesa Where dataPagamento = '"+data+"'",this.conexao.GetConexao());
                resp = true;
                comando.ExecuteNonQuery();
                this.conexao.fecharConexao();
            }
            catch(OleDbException erro){
                Console.Out.WriteLine("Erro : " + erro.Message);
            }
            return resp;
        }
    }
}
