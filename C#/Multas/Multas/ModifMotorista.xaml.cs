using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data.OleDb;

namespace Multas
{
    /// <summary>
    /// Interaction logic for ModifMotorista.xaml
    /// </summary>
    public partial class ModifMotorista : Window
    {
        public ModifMotorista()
        {
            InitializeComponent();

            btAlterar.IsEnabled = false;
            btExcluir.IsEnabled = false;
        }

        private void btConsulta_Click(object sender, RoutedEventArgs e)
        {            
            string cpfConsulta = tbCpfConsulta.Text;
            if (cpfConsulta == "")
            {
                MessageBox.Show("Nome não preechido!");
                tbCpfConsulta.Focus();
            }
            else {
                OleDbConnection conexao = new OleDbConnection
                (@"Provider = Microsoft.Jet.OLEDB.4.0;Data Source = C:\Users\Aluno\Documents\SistemaMulta.mdb");
                                
                OleDbCommand codigoMotorista = new OleDbCommand("Select * From Motorista "+
                    "Where cpf = '"+cpfConsulta+"'", conexao);                
                try
                {
                    //cpf - 23123
                    conexao.Open();
                    OleDbDataReader leitura = codigoMotorista.ExecuteReader();
                    if (leitura.Read())
                    {

                        tbCpf.Text = leitura.GetString(1);
                        tbNome.Text = leitura.GetString(2);
                        tbDataNascimento.Text = leitura.GetString(3);
                        tbValidade.Text = leitura.GetString(4);
                        tbCarteira.Text = leitura.GetString(5);
                        btAlterar.IsEnabled = true;
                        btExcluir.IsEnabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Cpf não encontrado!");

                    }
                }
                catch(OleDbException erro){
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void btAlterar_Click(object sender, RoutedEventArgs e)
        {
            string nome, dataNascimento, cpf, tipoCarteira,validadeCnh;
            if (tbNome.Text == "")
            {
                MessageBox.Show("Nome não preechido!");
                tbNome.Focus();
            }
            else if (tbDataNascimento.Text == "")
            {
                MessageBox.Show("Data de Nascimento não preechido!");
                tbDataNascimento.Focus();
            }
            else if (tbCpf.Text == "")
            {
                MessageBox.Show("Cpf não preechido!");
                tbCpf.Focus();
            }
            else if (tbCarteira.Text == "")
            {
                MessageBox.Show("Tipo da carteira não preechido!");
            }
            else if (tbValidade.Text == "")
            {
                MessageBox.Show("Validade do CNH não preenchida!");
                tbValidade.Focus();
            }
            else {
                nome = tbNome.Text;
                cpf = tbCpf.Text;
                tipoCarteira = tbCarteira.Text;
                validadeCnh = tbValidade.Text;
                dataNascimento = tbDataNascimento.Text;

                OleDbConnection conexao = new OleDbConnection
                (@"Provider = Microsoft.Jet.OLEDB.4.0;Data Source = C:\Users\Aluno\Documents\SistemaMulta.mdb");

                OleDbCommand codigoCadastro = new OleDbCommand
                ("Update Motorista "+
                "Set nome = '"+nome+"' ,cpf = '"+cpf+"' ,  tipo = '"+tipoCarteira+"'  ,  validade = '"+validadeCnh+"',"+
                "dataNascimento = '"+dataNascimento+"' "+
                "Where cpf = '"+cpf+"'", conexao);                
                try
                {
                    conexao.Open();

                    codigoCadastro.ExecuteNonQuery();
                    MessageBox.Show("Alteração efetuada com sucesso!");

                    conexao.Close();


                }
                catch (OleDbException erro)
                {
                    MessageBox.Show(erro.Message);
                }
            
            }

        }

        private void btExcluir_Click(object sender, RoutedEventArgs e)
        {
            OleDbConnection conexao = new OleDbConnection
            (@"Provider = Microsoft.Jet.OLEDB.4.0;Data Source = C:\Users\Aluno\Documents\SistemaMulta.mdb");

            OleDbCommand comando = new OleDbCommand
            ("Delete * From Motorista "+
            "where cpf = '"+tbCpf.Text+"'",conexao);
            try
            {
                conexao.Open();

                comando.ExecuteNonQuery();
                MessageBox.Show("Exclusão efetuada com sucesso!");

                conexao.Close();


            }
            catch (OleDbException erro)
            {
                MessageBox.Show(erro.Message);
            }

        }
    }
}
