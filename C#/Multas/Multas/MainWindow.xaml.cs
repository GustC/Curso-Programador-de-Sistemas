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

namespace Multas
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
            CadastroMotorista cadastro = new CadastroMotorista();
            cadastro.ShowDialog();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            ModifMotorista outras = new ModifMotorista();
            outras.ShowDialog();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            CadastroVeiculo veiculo = new CadastroVeiculo();
            veiculo.ShowDialog();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            ModifVeiculo veiculo = new ModifVeiculo();
            veiculo.ShowDialog();
        }
        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            CadastroMulta multa = new CadastroMulta();
            multa.ShowDialog();
        }
        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            ModifMulta multa = new ModifMulta();
            multa.ShowDialog();
        }
    }
}
