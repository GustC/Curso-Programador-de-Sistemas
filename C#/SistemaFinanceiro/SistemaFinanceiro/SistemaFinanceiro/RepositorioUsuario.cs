using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace SistemaFinanceiro
{
    public class RepositorioUsuario
    {
        private ConexaoBanco conexao;

        public RepositorioUsuario()
        {
            conexao = new ConexaoBanco();
        }


        public bool UsuarioExiste(string nome) {
            bool resp = false;
            try{
                this.conexao.abrirConexao();

                OleDbCommand comando = new OleDbCommand
                ("Select nome From Usuario Where nome = '"+nome+"' ",this.conexao.GetConexao());

                OleDbDataReader leitura = comando.ExecuteReader();

                if (leitura.Read()) {
                    resp = true;
                }

                this.conexao.fecharConexao();
            }
            catch(OleDbException erro){
                Console.Out.WriteLine("Erro : "+erro.Message);
            }
            return resp;
        }

        public bool CadastrarUsuario(Usuario usuario) {
            bool resp = false;

            try {
                this.conexao.abrirConexao();

                OleDbCommand comando = new OleDbCommand
                ("Insert into Usuario(nome,telefone,email,sexo,dataNascimento,profissao,salario)"+
                " Values('"+(usuario.getNome())+"','"+(usuario.getTelefone())+"','"+(usuario.getEmail())+"','"+(usuario.getSexo())+"','"+(usuario.getDataNascimento())+"',"+
                "'" + (usuario.getProfissao()) + "','" + (usuario.getSalario()) + "')", this.conexao.GetConexao());
                comando.ExecuteNonQuery();
                resp = true;
                this.conexao.fecharConexao();
            }
            catch(OleDbException erro){
                Console.Out.WriteLine("Erro : " + erro.Message);
            }
            return resp;
        }

        public Usuario ConsultaUsuario(string nome)
        {
            Usuario resp = new Usuario();
            try
            {
                this.conexao.abrirConexao();

                OleDbCommand comando = new OleDbCommand
                ("Select nome,telefone,email,sexo,dataNascimento,profissao,salario"+
                " From Usuario Where nome = '" + nome + "' ", this.conexao.GetConexao());

                OleDbDataReader leitura = comando.ExecuteReader();

                if (leitura.Read())
                {
                    resp.setNome(leitura.GetString(0));
                    resp.setTelefone(leitura.GetString(1));
                    resp.setEmail(leitura.GetString(2));
                    resp.setSexo(leitura.GetString(3));
                    resp.setDatanascimento(leitura.GetString(4));
                    resp.setProfissao(leitura.GetString(5));
                    resp.setSalario(leitura.GetString(6));
                }
                this.conexao.fecharConexao();
            }
            catch (OleDbException erro)
            {
                Console.Out.WriteLine("Erro : " + erro.Message);
            }
            return resp;
        }

        public bool AlterarUsuario(Usuario usuario,string nome) {
            bool resp = false;
            try
            {
                this.conexao.abrirConexao();

                OleDbCommand comando = new OleDbCommand
                ("Update Usuario Set nome = '"+(usuario.getNome())+"',telefone = '"+(usuario.getTelefone())+"',"+
                "email = '"+(usuario.getEmail())+"',sexo = '"+(usuario.getSexo())+"',dataNascimento = '"+(usuario.getDataNascimento())+"',profissao = '"+(usuario.getProfissao())+"',"+
                "salario = '"+(usuario.getSalario())+"',", this.conexao.GetConexao());

                comando.ExecuteNonQuery();
                resp = true;
                this.conexao.fecharConexao();
            }
            catch (OleDbException erro) {
                Console.Out.WriteLine("Erro : " + erro.Message);
            }

            return resp;
        }

        public bool ExcluirUsuario(string nome) {
            bool resp = false;

            try
            {
                this.conexao.abrirConexao();

                OleDbCommand comando = new OleDbCommand
                ("Delete From Usuario Where nome = '" + nome + "'", this.conexao.GetConexao());
                resp = true;
                comando.ExecuteNonQuery();
                this.conexao.fecharConexao();


            }
            catch (OleDbException erro) {
                Console.Out.WriteLine("Erro : " + erro.Message);
            }

            return resp;

        }


    }

}
