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

namespace SistemaFinanceiro
{
    /// <summary>
    /// Interaction logic for TelaConsultaUsuario.xaml
    /// </summary>
    public partial class TelaConsultaUsuario : Window
    {
        public TelaConsultaUsuario()
        {
            InitializeComponent();
            btAlterar.IsEnabled = false;
            btExcluir.IsEnabled = false;
        }

        private void btConsulta_Click(object sender, RoutedEventArgs e)
        {
            if (tbNomeConsulta.Text == "")
            {
                MessageBox.Show("Nome não preechido!");
            }
            else
            {
                RepositorioUsuario RpUsuario = new RepositorioUsuario();
                Usuario usuario;
                usuario = RpUsuario.ConsultaUsuario(tbNomeConsulta.Text);
                if (usuario.getNome() != null)
                {
                    tbNome.Text = usuario.getNome();
                    tbEmail.Text = usuario.getEmail();
                    tbProfissao.Text = usuario.getProfissao();
                    tbSalario.Text = usuario.getSalario();
                    tbTelefone.Text = usuario.getTelefone();
                    tbDataNascimento.Text = usuario.getDataNascimento();
                    if (usuario.getSexo() == "Feminino")
                    {
                        rbFeminino.IsChecked = true;
                    }
                    else
                        rbMasculino.IsChecked = true;
                }
                else {
                    MessageBox.Show("Nome não existente!");
                }

            }
        }
    }
}
