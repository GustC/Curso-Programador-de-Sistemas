using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace MultaOO
{
    class RepositorioMotorista
    {
        private ConexaoDB conexao;

        public RepositorioMotorista() {
            conexao = new ConexaoDB();
        }

        public bool MotoristaExite(string cpf) {
            bool resp = false ; // -- Nao se sabe se ele realmente existe , começamos com falso --

            try { 
                this.conexao.abrirConexao();

                OleDbCommand comando = new OleDbCommand
                ("Select cpf From Motorista Where cpf = '"+cpf+"'",conexao.GetConexao());

                OleDbDataReader leitura = comando.ExecuteReader();
                if(leitura.Read()){
                    resp = true;
                }
                this.conexao.fecharConexao();
            
            }
            catch(OleDbException erro){
                Console.Out.WriteLine("Erro : "+erro.Message);
            }

            return resp;
        }

        public bool CadastrarMotorista(Motorista motorista) {
            bool resposta = false;

            try { 
                this.conexao.abrirConexao();

                OleDbCommand cadastro = new OleDbCommand
                ("Insert into Motorista(cpf,nome,dataNascimento,validade,tipo)"+
                " Values('"+(motorista.getCpf())+"','"+(motorista.getNome())+"','"+(motorista.getDataNascimento())+"'"+
                ",'"+(motorista.getValidadeCnh())+"','"+(motorista.getTipoCarteira())+"')",this.conexao.GetConexao());

                cadastro.ExecuteNonQuery();
                resposta = true;
                this.conexao.fecharConexao();
           
            }catch(OleDbException erro){
                Console.Out.WriteLine("Erro: " + erro.Message);
            }
            return resposta;
        }

        public Motorista ConsultaMotoristaCPF(string cpf) {
            Motorista motorista = new Motorista();

            try {
                this.conexao.abrirConexao();
                OleDbCommand comando = new OleDbCommand
                ("Select cpf,nome,dataNascimento,validade,tipo"+
                " Where cpf = '"+cpf+"'",this.conexao.GetConexao());

                OleDbDataReader resultado = comando.ExecuteReader();

                if(resultado.Read()){
                    motorista.setCpf(resultado.GetString(0));
                    motorista.setNome(resultado.GetString(1));
                    motorista.setDatanascimento(resultado.GetString(2));
                    motorista.setValidadeCnh(resultado.GetString(3));
                    motorista.setTipoCarteira(resultado.GetString(4));
                }
                this.conexao.fecharConexao();
            }
            catch(OleDbException erro){
                Console.Out.WriteLine("Erro : " + erro.Message);
            }
            return motorista;
        }

        public bool AlterarMotorista(Motorista motorista, string cpf) {
            bool resp = false;

            try { 
                this.conexao.abrirConexao();
                OleDbCommand comando = new OleDbCommand
                ("Update Motorista Set nome = '"+(motorista.getNome())+"',cpf = '"+(motorista.getCpf())+"'"+
                ",dataNascimento = '"+(motorista.getDataNascimento())+"',validade = '"+(motorista.getValidadeCnh())+"'"+
                ",tipo = '"+(motorista.getTipoCarteira())+"' Where cpf = '"+cpf+"'",this.conexao.GetConexao());
                comando.ExecuteNonQuery();
                resp = true;
                this.conexao.fecharConexao();
                
            }catch(OleDbException erro){
                Console.Out.WriteLine("Erro : " + erro.Message);
            }
            return resp;
        }

        public bool ExcluirMotorista(string cpf) {
            bool resp = false;
            try {
                this.conexao.abrirConexao();

                OleDbCommand comando = new OleDbCommand
                ("Delete From Motorista Where cpf = '"+cpf+"'",this.conexao.GetConexao());
                resp = true;
                this.conexao.fecharConexao();
            }
            catch(OleDbException erro){
                Console.Out.WriteLine("Erro :" + erro.Message);
            }

            return resp;
        }
    }
}
