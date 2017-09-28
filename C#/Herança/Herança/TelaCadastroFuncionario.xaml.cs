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

namespace Herança
{
    /// <summary>
    /// Interaction logic for TelaCadastroFuncionario.xaml
    /// </summary>
    public partial class TelaCadastroFuncionario : Window
    {
        public TelaCadastroFuncionario()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, RoutedEventArgs e)
        {
            RepositorioFuncionario RpFuncionario = new RepositorioFuncionario();
            ConexaoBanco conexao = new ConexaoBanco();
            bool resp;
            string sexo;
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
            else if(RpFuncionario.FuncionarioExiste(tbCpf.Text) == true){
                MessageBox.Show("Cpf existente!");
                tbCpf.Focus();
            }
            else if((rbFeminino.IsChecked == false)&&(rbMasculino.IsChecked == false)){
                MessageBox.Show("Sexo não preechido!");
            }
            else if (tbCargo.Text == "")
            {
                MessageBox.Show("Cargo não preechido!");
                tbCargo.Focus();
            }
            else if(tbSalario.Text == ""){
                MessageBox.Show("Salario não preechido!");
                tbSalario.Focus();
            }
            else if(tbTelefone.Text == ""){
                MessageBox.Show("Telefone não preechido!");
                tbTelefone.Focus();
            }
            else if (tbEndereco.Text == "") {
                MessageBox.Show("Endereco não preechido!");
                tbEndereco.Focus();
            }
            else if(tbEmail.Text == ""){
                MessageBox.Show("Email não preechido!");
                tbEmail.Focus();
            }
            else if(tbEstado.Text == ""){
                MessageBox.Show("Estado Civil não preechido!");
                tbEstado.Focus();
            }
            else
            {
                if(rbFeminino.IsChecked == true)
                    sexo = "Feminino";
                else
                    sexo = "Masculino";
                Funcionario funcionario = new Funcionario(tbNome.Text,tbCpf.Text,tbDataNascimento.Text
                    ,sexo,tbCargo.Text,tbTelefone.Text,tbEndereco.Text,tbEmail.Text,tbEstado.Text,Double.Parse(tbSalario.Text));

                resp = RpFuncionario.CadastrarFuncionario(funcionario);
                if (resp == true)
                    MessageBox.Show("Funcionario Cadastrado!");
                else
                    MessageBox.Show("Funcionario não Cadastrado!");

            }   
        }


    }
}
