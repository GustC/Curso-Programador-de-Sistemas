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
    /// Interaction logic for ModifVeiculo.xaml
    /// </summary>
    public partial class ModifVeiculo : Window
    {
        public ModifVeiculo()
        {            
            InitializeComponent();
            btAlterar.IsEnabled = false;
            btExcluir.IsEnabled = false;
        }

        private void btConsulta_Click(object sender, RoutedEventArgs e)
        {
            string placaConsulta = tbPlacaConsulta.Text;
            if (placaConsulta == "")
            {
                MessageBox.Show("Nome não preechido!");
                tbPlacaConsulta.Focus();
            }
            else
            {
                OleDbConnection conexao = new OleDbConnection
                (@"Provider = Microsoft.Jet.OLEDB.4.0;Data Source = C:\Users\Aluno\Documents\SistemaMulta.mdb");

                OleDbCommand codigoMotorista = new OleDbCommand("Select * From Veiculo " +
                    "Where placa = '" + placaConsulta + "'", conexao);
                try
                {
                    conexao.Open();
                    OleDbDataReader leitura = codigoMotorista.ExecuteReader();
                    if (leitura.Read())
                    {
                        //sca613
                        tbPlaca.Text = leitura.GetString(1);
                        tbCor.Text = leitura.GetString(2);
                        tbAno.Text = leitura.GetString(3);
                        tbMarca.Text = leitura.GetString(4);
                        tbModelo.Text = leitura.GetString(5);
                        tbCpf.Text = leitura.GetString(6);
                        btAlterar.IsEnabled = true;
                        btExcluir.IsEnabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Cpf não encontrado!");

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
            string placa, cor, cpf, ano, marca, modelo;
            if (tbPlaca.Text == "")
            {
                MessageBox.Show("Placa não preechida!");
                tbPlaca.Focus();
            }
            else if (tbCor.Text == "")
            {
                MessageBox.Show("Cor não preechida!");
                tbCor.Focus();
            }
            else if (tbCpf.Text == "")
            {
                MessageBox.Show("Cpf não preechido!");
                tbCpf.Focus();
            }
            else if (tbMarca.Text == "")
            {
                MessageBox.Show("Marca não preechida!");
            }
            else if (tbModelo.Text == "")
            {
                MessageBox.Show("Modelo não preenchido!");
                tbModelo.Focus();
            }
            else if (tbAno.Text == "")
            {
                MessageBox.Show("Ano não preenchida!");
                tbAno.Focus();
            }
            else
            {
                placa = tbPlaca.Text;
                cpf = tbCpf.Text;
                marca = tbMarca.Text;
                modelo = tbModelo.Text;
                cor = tbCor.Text;
                ano = tbAno.Text;


                OleDbConnection conexao = new OleDbConnection
                   (@"Provider = Microsoft.Jet.OLEDB.4.0;Data Source = C:\Users\Aluno\Documents\SistemaMulta.mdb");

                OleDbCommand codigoCadastro = new OleDbCommand
                ("Update Veiculo "+
                "Set placa = '" + placa + "', cor = '" + cor + "', ano = '" + ano + "', marca = '" + marca + "', "+
                "modelo =  '" + modelo + "', cpf = '" + cpf + "'", conexao);
                

                try
                {
                    conexao.Open();

                    codigoCadastro.ExecuteNonQuery();
                    MessageBox.Show("Ateração efetuada com sucesso!");

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
            ("Delete * From Veiculo " +
            "where placa = '" + tbPlaca.Text + "'", conexao);
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
