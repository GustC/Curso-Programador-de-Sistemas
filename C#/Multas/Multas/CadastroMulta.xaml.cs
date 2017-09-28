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
using System.Data.OleDb;

namespace Multas
{
    /// <summary>
    /// Interaction logic for CadastroMulta.xaml
    /// </summary>
    public partial class CadastroMulta : Window
    {
        public CadastroMulta()
        {
            InitializeComponent();
            btCadastrar.IsEnabled = false;
        }

        private void btVerificar_Click(object sender, RoutedEventArgs e)
        {
            if (tbPlacaConsulta.Text == "")
            {
                MessageBox.Show("Placa não preechida!");
                tbPlaca.Focus();
            }

            else
            {

                OleDbConnection conexao = new OleDbConnection
                   (@"Provider = Microsoft.Jet.OLEDB.4.0;Data Source = C:\Users\Aluno\Documents\SistemaMulta.mdb");

                OleDbCommand codigoMotorista = new OleDbCommand("Select * From Veiculo " +
                     "Where placa = '" + tbPlacaConsulta.Text + "'", conexao);
                try
                {
                    conexao.Open();
                    OleDbDataReader leitura = codigoMotorista.ExecuteReader();
                    if (leitura.Read())
                    {
                        tbPlaca.Text = leitura.GetString(1);
                        tbCpf.Text = leitura.GetString(6);
                        // -- Preeche os campos da Placa e do CPf com os dados da tabela do "Veiculos" --
                        btCadastrar.IsEnabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Placa não encontrada!");

                    }
                }
                catch (OleDbException erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void btCadastrar_Click(object sender, RoutedEventArgs e)
        {
            string placa, codigo, cpf, descricao, pontos;
            double valor;
            if (tbPlaca.Text == "")
            {
                MessageBox.Show("Placa não preechida!");
                tbPlaca.Focus();
            }
            else if (tbCodigo.Text == "")
            {
                MessageBox.Show("Codigo não preechida!");
                tbCodigo.Focus();
            }
            else if (tbCpf.Text == "")
            {
                MessageBox.Show("Cpf não preechido!");
                tbCpf.Focus();
            }
            else if (tbDescricao.Text == "")
            {
                MessageBox.Show("Descrição da multa não preechida!");
                tbPontos.Focus();
            }
            else if (tbPontos.Text == "")
            {
                MessageBox.Show("Pontos na carteira não preenchido!");
                tbPontos.Focus();
            }
            else if (tbValor.Text == "")
            {
                MessageBox.Show("Valor não preenchido!");
                tbValor.Focus();
            }
            else
            {
                placa = tbPlaca.Text;
                cpf = tbCpf.Text;
                descricao = tbDescricao.Text;
                pontos = tbPontos.Text;
                codigo = tbCodigo.Text;
                valor = Double.Parse(tbValor.Text);
                OleDbConnection conexao = new OleDbConnection
                (@"Provider = Microsoft.Jet.OLEDB.4.0;Data Source = C:\Users\Aluno\Documents\SistemaMulta.mdb");

                OleDbCommand codigoCadastro = new OleDbCommand
                ("insert into Multa(codigoMulta,placa,descricao,valor,cpf,pontos)" +
                "values('" + codigo + "','" + placa + "','" + descricao + "','" + valor + "','" + cpf + "','" + pontos + "')", conexao);

                try
                {
                    conexao.Open();

                    codigoCadastro.ExecuteNonQuery();
                    MessageBox.Show("Cadastro efetuado com sucesso!");

                    conexao.Close();


                }
                catch (OleDbException erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }
    }
}
