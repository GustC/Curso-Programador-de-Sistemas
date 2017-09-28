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

namespace SistemaTv
{
    /// <summary>
    /// Interaction logic for CadastroCliente.xaml
    /// </summary>
    public partial class CadastroCliente : Window
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string nome = tbNome.Text;
            string cpf = tbCpf.Text;
            string endereco = tbEndereco.Text;
            string telefone = tbTelefone.Text;
            string email = tbEmail.Text;
            string dataNascimento = tbDataNascimento.Text;
            string sexo;

            if (rbFeminino.IsChecked == true)
                sexo = "Feminino";
            else if (rbMasculino.IsChecked == true)
                sexo = "Masculino";
            else
                sexo = "";

            if ((nome == "") || (cpf == "") || (endereco == "") || (telefone == ""))
            {
                MessageBox.Show("Campos obrigatorios não preechidos!");
            }
            else {
                Cliente cliente = new Cliente(cpf, nome, endereco, telefone, sexo, email, dataNascimento);
                MessageBox.Show("Cliente Cadastrado com sucesso !");
                CadastroCombo combo = new CadastroCombo();
                combo.ShowDialog();

            }
        }
    }
}
