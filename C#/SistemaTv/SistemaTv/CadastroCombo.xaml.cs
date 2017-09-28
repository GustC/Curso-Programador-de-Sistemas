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
    /// Interaction logic for CadastroCombo.xaml
    /// </summary>
    public partial class CadastroCombo : Window
    {
        public CadastroCombo()
        {
            InitializeComponent();
        }

        private void btCadastro_Click(object sender, RoutedEventArgs e)
        {
            string nome = tbNome.Text;
            double valor = 0;
            int nunPontos = 0;
            int qtdDigitais = 0;
            int qtdHd = 0;
            int qtdAbertos = 0;
            int qtdAudios = 0;
            if ((nome == "") || (tbAbertos.Text == "") || (tbAudio.Text == "") || (tbDigitais.Text == "") || (tbHd.Text == ""))
            {
                MessageBox.Show("Campo obrigatorio não preenchidos!");
            }
            else {
                valor = double.Parse(tbValor.Text);
                if(tbPontos.Text != "")
                    nunPontos = Int32.Parse(tbPontos.Text);
                qtdDigitais = Int32.Parse(tbDigitais.Text);
                qtdHd = Int32.Parse(tbHd.Text);
                qtdAudios = Int32.Parse(tbAudio.Text);
                qtdAbertos = Int32.Parse(tbAbertos.Text);

                Combo combo = new Combo(nome, valor, qtdDigitais, qtdHd, qtdAbertos, qtdAudios, nunPontos);
                MessageBox.Show("Combo cadastrado com sucesso!");

                CadastroCanal canal = new CadastroCanal();
                canal.ShowDialog();

            }
        }
    }
}
