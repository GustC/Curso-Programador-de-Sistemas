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
    /// Interaction logic for TelaCadastroDespesa.xaml
    /// </summary>
    public partial class TelaCadastroDespesa : Window
    {
        public TelaCadastroDespesa()
        {
            InitializeComponent();
        }

        private void btCadastrar_Click(object sender, RoutedEventArgs e)
        {
            RepositorioDespesa RpDespesa = new RepositorioDespesa();
            bool resposta;
            string dataPagamento, valor, descricaoPagamento;
            if(tbData.Text == ""){
                MessageBox.Show("Data de pagamento não preechida!");
            }
            else if (RpDespesa.DespesaExiste(tbData.Text) == true) {
                MessageBox.Show("Data de pagamento existente!");
            }
            else if(tbValor.Text == ""){
                MessageBox.Show("Valor não preechido!");
            }
            else if (tbDescricao.Text == "")
            {
                MessageBox.Show("Descrição do pagamento não preechido !");
            }
            else {
                dataPagamento = tbData.Text;
                valor = tbValor.Text;
                descricaoPagamento = tbDescricao.Text;
                Despesa despesa = new Despesa(dataPagamento, valor, descricaoPagamento);
                resposta = RpDespesa.cadastrarDespesa(despesa);
                if (resposta == true)
                {
                    MessageBox.Show("Despesa cadastrada com sucesso!");
                }
                else {
                    MessageBox.Show("Despesa não cadastrada!");
                }
            }
        }
    }
}
