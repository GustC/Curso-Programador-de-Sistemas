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
    /// Interaction logic for CadastroMotorista.xaml
    /// </summary>
    public partial class CadastroMotorista : Window
    {
        public CadastroMotorista()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, RoutedEventArgs e)
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
                ("insert into Motorista(cpf,nome,dataNascimento,validade,tipo)" +
                "values('" + cpf + "','" + nome + "','" + dataNascimento + "','" + validadeCnh + "','" + tipoCarteira + "')", conexao);

                try
                {
                    conexao.Open();

                    codigoCadastro.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com sucesso!");

                    conexao.Close();


                }
                catch(OleDbException erro) {
                    MessageBox.Show(erro.Message);
                }
            }           
            
        }
    }
}
