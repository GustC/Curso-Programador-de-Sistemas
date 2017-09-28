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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SistemaFinanceiro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            TelaCadastroUsuario usuario = new TelaCadastroUsuario();
            usuario.ShowDialog();
        }

        private void MenuItem_Click2(object sender, RoutedEventArgs e)
        {
            TelaConsultaUsuario usuario = new TelaConsultaUsuario();
            usuario.ShowDialog();
        }

        private void MenuItem_Click3(object sender, RoutedEventArgs e)
        {
            TelaCadastroReceita receita = new TelaCadastroReceita();
            receita.ShowDialog();
        }
        
        private void MenuItem_Click4(object sender, RoutedEventArgs e)
        {
            TelaConsultaReceita receita = new TelaConsultaReceita();
            receita.ShowDialog();
        }

        private void MenuItem_Click5(object sender, RoutedEventArgs e)
        {
            TelaCadastroDespesa despesa = new TelaCadastroDespesa();
            despesa.ShowDialog();
        }
        private void MenuItem_Click6(object sender, RoutedEventArgs e)
        {
            TelaConsultaDespesa despesa = new TelaConsultaDespesa();
            despesa.ShowDialog();
        }
         

    }
}
