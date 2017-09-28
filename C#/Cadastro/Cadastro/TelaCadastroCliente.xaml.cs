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

namespace Cadastro
{
    /// <summary>
    /// Interaction logic for TelaCadastroCliente.xaml
    /// </summary>
    public partial class TelaCadastroCliente : Window
    {
        public TelaCadastroCliente()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, RoutedEventArgs e)
        {
            
            string nome, dataNascimento, sexo, endereco, email,telefone;
            if (tbNome.Text == "")
            {
                MessageBox.Show("Nome não preechido!");
                tbNome.Focus();
            }
            else if (tbData.Text == "")
            {
                MessageBox.Show("Data de Nascimento não preechido!");
                tbData.Focus();
            }
            else if (tbEmail.Text == "")
            {
                MessageBox.Show("Email não preechido!");
                tbEmail.Focus();
            }
            else if (tbEndereco.Text == "")
            {
                MessageBox.Show("Endereço não preechido!");
                tbEndereco.Focus();
            }
            else if ((rbFeminino.IsChecked == false) && (rbMasculino.IsChecked == false))
            {
                MessageBox.Show("Sexo não preechido!");
            }
            else if (tbTelefone.Text == "") {
                MessageBox.Show("Telefone não preenchido!");
                tbTelefone.Focus();
            }
            else
            {
                // -- Artribuição ao banco ---
                nome = tbNome.Text;
                endereco = tbEndereco.Text;
                email = tbEmail.Text;
                dataNascimento = tbData.Text;
                telefone = tbTelefone.Text;
                if (rbFeminino.IsChecked == true)
                    sexo = "Feminino";
                else
                    sexo = "Masculino";
                OleDbConnection conexao = new OleDbConnection
                (@"Provider = Microsoft.Jet.OLEDB.4.0;Data Source = C:\Users\Aluno\Documents\Cadastro.mdb");

                OleDbCommand codigoCadastro = new OleDbCommand
                ("INSERT INTO Cliente (nome,dataNascimento,sexo,endereco,telefone,email)" +
                "Values ('" + nome + "','" + dataNascimento + "','" + sexo + "','" + endereco + "','" + telefone + "','" + email + "')", conexao);

                try
                {
                    conexao.Open();

                    codigoCadastro.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com sucesso.");

                    conexao.Close();

                }
                catch(OleDbException erro){ // --- Comando de erros do banco de dados 
                    MessageBox.Show(erro.Message);// -- informa qual o erro referente ao banco de dados                                        
                }
            }
        }

        private void btCancelar_Click(object sender, RoutedEventArgs e)
        {
            tbNome.Text = "";
            tbData.Text = "";
            tbEmail.Text = "";
            tbEndereco.Text = "";
            rbMasculino.IsChecked = false;
            rbFeminino.IsChecked = false;



        }
    }
}
