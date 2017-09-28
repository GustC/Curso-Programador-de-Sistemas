using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CidadeLegal
{
    /// <summary>
    /// Interaction logic for MoradorCadastro.xaml
    /// </summary>
    public partial class MoradorCadastro : Window
    {
        public MoradorCadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string cpf = tbCpf.Text;
            string nome = tbNome.Text;
            string telefone = tbTelefone.Text;
            string endereco = tbEndereco.Text;
            string dataNascimento = tbData.Text;
            string sexo = "";
            if (cpf == "")
            {
                MessageBox.Show("Campo Obrigatorio não preenchido!");
            }
            else
            {
                if (rbFeminino.IsChecked == true)
                {
                    sexo = "Feminino";
                }
                else if (rbMasculino.IsChecked == true)
                {
                    sexo = "Masculino";
                }
                Morador morador = new Morador(nome, cpf, endereco, telefone, dataNascimento, sexo);
            }
        }
    }
}
