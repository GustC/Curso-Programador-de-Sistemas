using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace Herança
{
    public class RepositorioFuncionario
    {
        public bool FuncionarioExiste(string cpf) {
            bool resposta=false;
            ConexaoBanco conexao = new ConexaoBanco();
            try
            {
                conexao.abrirConexao();
                OleDbCommand comando = new OleDbCommand
                ("Select cpf From Funcionario Where cpf ='"+cpf+"'",conexao.GetConexao());
                OleDbDataReader leitura = comando.ExecuteReader();
                if (leitura.Read()) {
                    resposta = true;
                }
                conexao.fecharConexao();

            }
            catch (OleDbException erro) {
                Console.Out.WriteLine("Erro : " + erro.Message);
            }

            return resposta;
        }

        public bool CadastrarFuncionario(Funcionario funcionario) {                       
            bool resposta = false;
            ConexaoBanco conexao = new ConexaoBanco();
            try {
                conexao.abrirConexao();
                OleDbCommand comando = new OleDbCommand
                ("Insert into Funcionario(cpf,cargo,salario,estadoCivil,"+
                "nome,dataNascimento,sexo,telefone,endereco,email)"+
                "Values('"+(funcionario.getCpf())+"','"+(funcionario.getCargo())+"','"+(funcionario.getSalario())+"',"+
                "'"+(funcionario.getEstadoCivil())+"','"+(funcionario.getNome())+"','"+(funcionario.getDataNascimento())+"','"+(funcionario.getSexo())+"',"+
                "'"+(funcionario.getTelefone())+"','"+(funcionario.getEndereco())+"','"+(funcionario.getEmail())+"')",conexao.GetConexao());
                comando.ExecuteNonQuery();
                resposta = true;
              
                conexao.fecharConexao();
            }
            catch (OleDbException erro)
            {
                Console.Out.WriteLine("Erro : " + erro.Message);
            }
            return resposta;
        }

        public Funcionario ConsultarFuncionario(string cpf) {
            Funcionario funcionario = new Funcionario();
            ConexaoBanco conexao = new ConexaoBanco();
            try {
                conexao.abrirConexao();
                OleDbCommand comando = new OleDbCommand
                ("Select cpf,cargo,salario,estadoCivil,nome,dataNascimento,sexo,telefone,endereco,email"+
                " Where cpf = '"+cpf+"'", conexao.GetConexao());
                OleDbDataReader leitura = comando.ExecuteReader();
                if (leitura.Read()) {
                    funcionario.setCpf(leitura.GetString(0));
                    funcionario.setCargo(leitura.GetString(1));
                    funcionario.setSalario(Double.Parse(leitura.GetString(2)));
                    funcionario.setEstadoCivil(leitura.GetString(3));
                    funcionario.setNome(leitura.GetString(4));
                    funcionario.setDataNascimento(leitura.GetString(5));
                    funcionario.setSexo(leitura.GetString(6));
                    funcionario.setTelefone(leitura.GetString(7));
                    funcionario.setEndereco(leitura.GetString(8));
                    funcionario.setEmail(leitura.GetString(9));
                }
                conexao.fecharConexao();
            }
            catch(OleDbException erro){
                Console.Out.WriteLine("Erro : " + erro.Message);
            }
            return funcionario;
        }

        public bool AlterarFuncionario(Funcionario funcionario,string cpf) {
            bool resposta = false;
            ConexaoBanco conexao = new ConexaoBanco();

            try {
                conexao.abrirConexao();

                OleDbCommand comando = new OleDbCommand
                ("Update Funcionario Set "+
                "cpf = '"+(funcionario.getCpf())+"',nome= '"+(funcionario.getNome())+"',cargo= '"+(funcionario.getCargo())+"',"+
                "salario = '"+(funcionario.getSalario())+"',estadoCivil= '"+(funcionario.getEstadoCivil())+"',sexo = = '"+(funcionario.getSexo())+"',"+
                "dataNascimento = '"+(funcionario.getDataNascimento())+"',telefone= '"+(funcionario.getTelefone())+"',email= '"+(funcionario.getEmail())+"',"+
                "endereco = '"+(funcionario.getEndereco())+"',"+
                " Where cpf = '"+cpf+"' ",conexao.GetConexao());
                comando.ExecuteNonQuery();
                resposta = true;
                conexao.fecharConexao();
            }
            catch (OleDbException erro)
            {
                Console.Out.WriteLine("Erro : " + erro.Message);
            }

            return resposta;
        }

        public bool ExcluirFuncionario(string  cpf) {
            bool resposta = false;
            ConexaoBanco conexao = new ConexaoBanco();
            try {
                conexao.abrirConexao();

                OleDbCommand comando = new OleDbCommand
                ("Delete From Funcionario Where cpf = '"+cpf+" ",conexao.GetConexao());
                comando.ExecuteNonQuery();
                resposta = true;
                conexao.fecharConexao();
            }
            catch (OleDbException erro)
            {
                Console.Out.WriteLine("Erro : " + erro.Message);
            }

            return resposta;
        }
    }
}
