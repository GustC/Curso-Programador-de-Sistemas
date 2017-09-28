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
    /// Interaction logic for ProblemaCadastro.xaml
    /// </summary>
    public partial class ProblemaCadastro : Window
    {
        public ProblemaCadastro()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, RoutedEventArgs e)
        {
            string data = tbData.Text;
            string causa = tbCausa.Text;
            string valor = tbValor.Text;
            string Descricao = tbDescricao.Text;
            string Solucao = tbSolucao.Text;
            double custo = 0;
            if ((data == "") || (causa == ""))
            {
                MessageBox.Show("Campos Obrigatorios não preechidos!");
            }
            else {                
                if (valor != "") {
                    custo = double.Parse(valor);
                   
                }
                Problema problema = new Problema(Descricao, causa, Solucao, custo, data);
            }
        }
    }
}
