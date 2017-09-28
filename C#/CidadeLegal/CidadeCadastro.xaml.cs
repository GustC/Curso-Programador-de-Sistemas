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
    /// Interaction logic for CidadeCadastro.xaml
    /// </summary>
    public partial class CidadeCadastro : Window
    {
        public CidadeCadastro()
        {
            InitializeComponent();
        }

        private void btCadastroCidade_Click(object sender, RoutedEventArgs e)
        {
            string nome = tbNome.Text;
            string clima = tbClima.Text;
            string populacao = tbPopulacao.Text;
            int qtdPupulacao = 0;
            double area = 0;

            if ((nome == "") || (clima == "") || (populacao == ""))
            {
                MessageBox.Show("Campos obrigatorios não preechidos!");
            }
            else
            {              

                qtdPupulacao = Int32.Parse(populacao);

                if (tbArea.Text != "")
                {
                    area = double.Parse(tbArea.Text);
                }

                Cidade cidade = new Cidade(nome, qtdPupulacao, area, clima);

            }
        }
    }
}
