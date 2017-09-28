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
    /// Interaction logic for TelaConsultaDespesa.xaml
    /// </summary>
    public partial class TelaConsultaDespesa : Window
    {
        public TelaConsultaDespesa()
        {
            InitializeComponent();
            btAlterar.IsEnabled = false;
            btExcluir.IsEnabled = false;
        }

        private void btConsultar_Click(object sender, RoutedEventArgs e)
        {
            RepositorioDespesa RpDespesa = new RepositorioDespesa();
            if (tbDataConsulta.Text == "")
            {
                MessageBox.Show("Data do pagamento não preechido!");
                tbDataConsulta.Focus();

            }
            else {
                Despesa despesa = RpDespesa.ConsultarDespesa(tbDataConsulta.Text);
                if (despesa.getDataPagamento() != null)
                {
                    tbData.Text = despesa.getDataPagamento();
                    tbDescricao.Text = despesa.getDescricaoPagamento();
                    tbValor.Text = despesa.getValor();
                    btAlterar.IsEnabled = true;
                    btExcluir.IsEnabled = true;
                }
                else {
                    MessageBox.Show("Data da despesa não encontrada!");
                    tbDataConsulta.Focus();
                }
            }

        }

        private void btAlterar_Click(object sender, RoutedEventArgs e)
        {
            RepositorioDespesa RpDespesa = new RepositorioDespesa();
            bool resposta;
            if (tbData.Text == "") {
                MessageBox.Show("Data de pagamento não preenchida!");
                tbData.Focus();
            }
            else if((tbData.Text != tbDataConsulta.Text)&&(RpDespesa.DespesaExiste(tbData.Text)==true)){
                MessageBox.Show("Data de pagemnto ja existente!");
                tbData.Focus();
            }
            else{
                Despesa despesa = new Despesa(tbData.Text, tbValor.Text, tbDescricao.Text);
                resposta = RpDespesa.AlterarDespesa(despesa, tbData.Text);
                if (resposta == true)
                {
                    MessageBox.Show("Despesa alterada com sucesso!");
                }
                else {
                    MessageBox.Show("Despesa não alterada!");
                }
            }
        }

        private void btExcluir_Click(object sender, RoutedEventArgs e)
        {
            RepositorioDespesa RpDespesa = new RepositorioDespesa();
            bool resposta;

            resposta = RpDespesa.ExcluirDespesa(tbData.Text);
            if (resposta == true)
            {
                MessageBox.Show("Despesa excluida com sucesso!");
            }
            else {
                MessageBox.Show("Despesa não excluida!");
            }
            

        }


    }
}
