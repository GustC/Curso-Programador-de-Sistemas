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
    /// Interaction logic for CadastroProgramacao.xaml
    /// </summary>
    public partial class CadastroProgramacao : Window
    {
        public CadastroProgramacao()
        {
            InitializeComponent();
        }

        private void btCadastro_Click(object sender, RoutedEventArgs e)
        {
            string nome = tbNome.Text ;
            string descricao = tbDescricao.Text;
            string horaInicio = tbInicio.Text;
            string horaTermino = tbTermino.Text;
            string data = tbData.Text;
            int faixa = 0;

            if ((nome == "") || (descricao == "") || (horaInicio == "") || (horaTermino == "") || (data == "") || (tbFaixa.Text == ""))
            {
                MessageBox.Show("Campo obrigatorio não preenchido !");
            }
            else {
                faixa = Int32.Parse(tbFaixa.Text);
                Programacao programacao = new Programacao(nome, horaInicio, horaTermino, data, faixa, descricao);
                MessageBox.Show("Programação cadastrada com sucesso !");

                MessageBox.Show("Cadastro Finalizado!");

            }
        }
    }
}
