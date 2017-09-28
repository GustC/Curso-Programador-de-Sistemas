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
    /// Interaction logic for TelaCadastroReceita.xaml
    /// </summary>
    public partial class TelaCadastroReceita : Window
    {
        public TelaCadastroReceita()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, RoutedEventArgs e)
        {
            RepositorioReceita RpReceita = new RepositorioReceita();
            string dataReceita, valor, origemDinheiro;
            bool resposta;

            if (tbData.Text == "") {
                MessageBox.Show("Data da receita não preechida!");
                tbData.Focus();
            }
            else if(RpReceita.ReceitaExiste(tbData.Text)==true){
                MessageBox.Show("Data da receita existente!");
                tbData.Focus();
            }
            else if(tbOrigem.Text == ""){
                MessageBox.Show("Origem do dinheiro não preechida!");
                tbOrigem.Focus();
            }
            else if(tbValor.Text == ""){
                MessageBox.Show("Valor não preechido!");
                tbValor.Focus();
            }
            else{
                dataReceita = tbData.Text;
                valor = tbValor.Text;
                origemDinheiro = tbOrigem.Text;
                Receita receita = new Receita(dataReceita,valor,origemDinheiro);
                resposta = RpReceita.CadastrarReceita(receita);
                if (resposta == true)
                {
                    MessageBox.Show("Receita cadastrada com sucesso!");
                }
                else {
                    MessageBox.Show("Receita não Cadastrada!");
                }

            }           

        }
    }
}
