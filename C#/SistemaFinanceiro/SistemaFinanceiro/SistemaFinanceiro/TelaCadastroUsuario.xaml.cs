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

namespace SistemaFinanceiro
{
    /// <summary>
    /// Interaction logic for TelaCadastroUsuario.xaml
    /// </summary>
    public partial class TelaCadastroUsuario : Window
    {
        public TelaCadastroUsuario()
        {
            InitializeComponent();
        }

        //private ConexaoBanco conexao = new ConexaoBanco();

        //private RepositorioUsuario RpUsuario;


        private void btCadastrar_Click(object sender, RoutedEventArgs e)
        {
            RepositorioUsuario RpUsuario = new RepositorioUsuario();
            bool resposta;          
            string nome, dataNascimento, telefone, email, salario, profissao,sexo;
            if (tbNome.Text == "") {
                MessageBox.Show("Nome não preechido!");
                tbNome.Focus();
            }
            else if (RpUsuario.UsuarioExiste(tbNome.Text) == true)
            {
                MessageBox.Show("Nome Existente!");
                tbNome.Focus();
            }
            else if(tbEmail.Text == ""){
                MessageBox.Show("Email não preechido!");
                tbEmail.Focus();
            }
            else if (tbDataNascimento.Text == "")
            {
                MessageBox.Show("Data de Nascimento não preechida!");
                tbDataNascimento.Focus();
            }
            else if (tbTelefone.Text == "")
            {
                MessageBox.Show("Telefone não preechido!");
                tbTelefone.Focus();
            }
            else if (tbSalario.Text == "")
            {
                MessageBox.Show("Salario não preechido!");
                tbSalario.Focus();
            }
            else if (tbProfissao.Text == "")
            {
                MessageBox.Show("Profissao não preechido!");
                tbProfissao.Focus();
            }
            else if ((rbMasculino.IsChecked == false) &&(rbFeminino.IsChecked == false))
            {
                MessageBox.Show("Sexo não preechido!");                
            }            
            else {
                nome = tbNome.Text;
                telefone = tbTelefone.Text;
                email = tbEmail.Text;
                profissao = tbProfissao.Text;
                salario = tbSalario.Text;
                dataNascimento = tbDataNascimento.Text;
                if (rbMasculino.IsChecked == true)
                    sexo = "Masculino";
                else 
                    sexo = "Feminino";
                Usuario usuario = new Usuario(nome, telefone, email, sexo, dataNascimento, profissao, salario);
               
                resposta = RpUsuario.CadastrarUsuario(usuario);
                
                /*
                this.RpUsuario = new RepositorioUsuario();
                resposta = this.RpUsuario.CadastrarUsuario(usuario);
                 */
                if (resposta == true)
                    MessageBox.Show("Usuario Cadastrado com sucesso!");
                else
                    MessageBox.Show("Usuario não Cadastrado!");
                // resposta = RpUsuario.CadastrarUsuario(usuario);
                
            }
        }
    }
}
