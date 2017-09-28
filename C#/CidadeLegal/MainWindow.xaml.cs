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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CidadeLegal
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

        private void btCidade_Click(object sender, RoutedEventArgs e)
        {
            CidadeCadastro cidade = new CidadeCadastro();
            cidade.ShowDialog();
        }

        private void btMoradorCadastro_Click(object sender, RoutedEventArgs e)
        {
            MoradorCadastro morador = new MoradorCadastro();
            morador.ShowDialog();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            ProblemaCadastro problema = new ProblemaCadastro();
            problema.ShowDialog();
        }
    }
}
