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
    /// Interaction logic for ModifMulta.xaml
    /// </summary>
    public partial class ModifMulta : Window
    {
        public ModifMulta()
        {
            InitializeComponent();
            btExcluir.IsEnabled = false;
            btAlterar.IsEnabled = false;
        }

        private void btVerificar_Click(object sender, RoutedEventArgs e)
        {
            string codigoConsulta = tbCodigoConsulta.Text;
            double valor;
            if (codigoConsulta == "")
            {
                MessageBox.Show("Nome não preechido!");
                tbCodigoConsulta.Focus();
            }
            else
            {
                OleDbConnection conexao = new OleDbConnection
                (@"Provider = Microsoft.Jet.OLEDB.4.0;Data Source = C:\Users\Aluno\Documents\SistemaMulta.mdb");

                OleDbCommand codigoMotorista = new OleDbCommand("Select * From Multa " +
                    "Where codigoMulta = '" + codigoConsulta + "'", conexao);
                try
                {
                    conexao.Open();
                    OleDbDataReader leitura = codigoMotorista.ExecuteReader();
                    if (leitura.Read())
                    {
                        //sca613
                        tbCpf.Text = leitura.GetString(5);
                        tbCodigo.Text = leitura.GetString(1);
                        tbDescricao.Text = leitura.GetString(3);
                        tbPontos.Text = leitura.GetString(6);
                        tbPlaca.Text = leitura.GetString(2);
                        valor = leitura.GetInt32(4);
                        tbValor.Text = valor.ToString();
                        btAlterar.IsEnabled = true;
                        btExcluir.IsEnabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Codigo de multa não encontrado!");

                    }
                }
                catch (OleDbException erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void btAlterar_Click(object sender, RoutedEventArgs e)
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
                ("Update Multa " +
                "Set placa = '" + placa + "',codigoMulta = '" + codigo + "',descricao = '" + descricao + "',cpf = '" + cpf + "'" +
                ",valor = '" + valor + "',pontos = '" + pontos + "'", conexao);
                
                
                try
                {
                    conexao.Open();

                    codigoCadastro.ExecuteNonQuery();
                    MessageBox.Show("Alteração efetuada com sucesso!");

                    conexao.Close();


                }
                catch (OleDbException erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void btExcluir_Click(object sender, RoutedEventArgs e)
        {
            OleDbConnection conexao = new OleDbConnection
            (@"Provider = Microsoft.Jet.OLEDB.4.0;Data Source = C:\Users\Aluno\Documents\SistemaMulta.mdb");

            OleDbCommand comando = new OleDbCommand
            ("Delete * From Multa " +
            "where codigoMulta = '" + tbCodigo.Text + "'", conexao);
            try
            {
                conexao.Open();

                comando.ExecuteNonQuery();
                MessageBox.Show("Exclusão efetuada com sucesso!");

                conexao.Close();


            }
            catch (OleDbException erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
    }
}
