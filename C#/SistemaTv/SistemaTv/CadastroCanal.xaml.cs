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
    /// Interaction logic for CadastroCanal.xaml
    /// </summary>
    public partial class CadastroCanal : Window
    {
        public CadastroCanal()
        {
            InitializeComponent();
        }

        private void btCadastro_Click(object sender, RoutedEventArgs e)
        {
            string nome = tbNome.Text;
            string categoria = tbCategoria.Text;
            string subCategoria = tbSubCategoria.Text;
            string descricao = tbDescricao.Text;
            int numero = 0;
            if ((nome == "") || (tbNumero.Text == ""))
            {
                MessageBox.Show("Campos obrigatorios não preenchidos!");
            }
            else {
                numero = Int32.Parse(tbNumero.Text);
                canal canal = new canal(nome, numero, categoria, subCategoria,descricao);
                MessageBox.Show("Canal cadastrado com sucesso!");

                CadastroProgramacao programacao = new CadastroProgramacao();
                programacao.ShowDialog();
            }
        }
    }
}
