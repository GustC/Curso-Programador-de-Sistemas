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
    /// Interaction logic for TelaConsultaReceita.xaml
    /// </summary>
    public partial class TelaConsultaReceita : Window
    {
        public TelaConsultaReceita()
        {
            InitializeComponent();
            btAlterar.IsEnabled = false;
            btExcluir.IsEnabled = false;
        }

        private void btConsultar_Click(object sender, RoutedEventArgs e)
        {
            RepositorioReceita RpReceita = new RepositorioReceita();
            if (tbDataConsultar.Text == "")
            {
                MessageBox.Show("Data da Receita não preechida!");
                tbDataConsultar.Focus();
            }
            else {
                Receita receita = RpReceita.ConsultarReceitaData(tbDataConsultar.Text);
                
                if (receita.getDataReceita() == null){
                    MessageBox.Show("Data de Receita não encontrada!");
                    tbDataConsultar.Focus();                    
                }
                else {
                    tbData.Text = receita.getDataReceita();
                    tbOrigem.Text = receita.getOrigemDinheiro();
                    tbValor.Text = receita.getValor();
                    btAlterar.IsEnabled = true;
                    btExcluir.IsEnabled = true;
                }
            }

        }

        private void btAlterar_Click(object sender, RoutedEventArgs e)
        {
            bool resposta;
            RepositorioReceita RpReceita = new RepositorioReceita();
            if (tbData.Text == "") {
                MessageBox.Show("Data da Receita não preechida!");
                tbData.Focus();
            }
            else if((RpReceita.ReceitaExiste(tbData.Text)) && (tbDataConsultar.Text != tbData.Text)){
                MessageBox.Show("Data da Receita existente!");
                tbData.Focus();
            }
            else if(tbOrigem.Text == ""){
                MessageBox.Show("Origem do pagamento não preechida!");
                tbOrigem.Focus();
            }
            else if (tbValor.Text == "")
            {
                MessageBox.Show("Valor não preechido!");
            }
            else {
                Receita receita = new Receita(tbData.Text, tbValor.Text, tbOrigem.Text);
                resposta = RpReceita.AlterarReceita(receita, tbDataConsultar.Text);
                if (resposta == true)
                {
                    MessageBox.Show("Alteração efetuada com sucesso!");
                }
                else {
                    MessageBox.Show("Alteração não efetuada!");
                }
            }
        }

        private void btExcluir_Click(object sender, RoutedEventArgs e)
        {
            RepositorioReceita RpReceita = new RepositorioReceita();
            string data = tbData.Text;
            bool resposta;

            resposta = RpReceita.ExcluirReceita(data);

            if (resposta == true)
            {
                MessageBox.Show("Receita excluida com sucesso!");
            }
            else {
                MessageBox.Show("Receita não excluida!");
            }
        }
    }
}
