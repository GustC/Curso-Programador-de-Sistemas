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
    /// Interaction logic for CadastroVeiculo.xaml
    /// </summary>
    public partial class CadastroVeiculo : Window
    {
        public CadastroVeiculo()
        {
            InitializeComponent();
            btCadastrar.IsEnabled = false;
        }

        private void btCadastrar_Click(object sender, RoutedEventArgs e)
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
                ("insert into Veiculo(placa,cor,ano,marca,modelo,cpf)" +
                "values('" + placa + "','" + cor + "','" + ano + "','" + marca + "','" + modelo + "','" + cpf + "')", conexao);

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

        private void btVerificar_Click(object sender, RoutedEventArgs e)
        {
            string cpfConsulta = tbCpf.Text;
            if (cpfConsulta == "")
            {
                MessageBox.Show("Nome não preechido!");
                tbCpf.Focus();
            }
            else
            {
                OleDbConnection conexao = new OleDbConnection
                (@"Provider = Microsoft.Jet.OLEDB.4.0;Data Source = C:\Users\Aluno\Documents\SistemaMulta.mdb");
                // -- Verificar se o cpf digitado no cadastro de veiculo existe na tabela de motoristas --
                OleDbCommand codigoMotorista = new OleDbCommand("Select * From Motorista " +
                    "Where cpf = '" + cpfConsulta + "'", conexao);
                try
                {
                    conexao.Open();
                    OleDbDataReader leitura = codigoMotorista.ExecuteReader();
                    if (leitura.Read())
                    {
                        btCadastrar.IsEnabled = true;                        
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
    }
}
