using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MultaOO
{
    public class Motorista
    {
        // --- Inicio Artributos ---
        private string nome;
        private string dataNascimento;
        private string cpf;
        private string tipoCarteira;
        private string validadeCnh;
        // --- Fim Atributos ---
        
        // --- Inicio Construtores ---
        public Motorista()
        {

        }

        public Motorista(string cpfC, string nomeC, string dataNascimentoC, string tipoC, string validadeC)
        {
            this.cpf = cpfC;
            this.nome = nomeC;
            this.dataNascimento = dataNascimentoC;
            this.tipoCarteira = tipoC;
            this.validadeCnh = validadeC;
        }
        // --- Fim Construtores ---
        
        // --- Inicio Metodos ---
        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string nomeNovo)
        {
            this.nome = nomeNovo;
        }

        public string getCpf()
        {
            return this.cpf;
        }
        public void setCpf(string cpfNovo)
        {
            this.cpf = cpfNovo;
        }

        public string getTipoCarteira()
        {
            return this.tipoCarteira;
        }
        public void setTipoCarteira(string tipoNovo)
        {
            this.tipoCarteira = tipoNovo;
        }

        public string getDataNascimento()
        {
            return this.dataNascimento;
        }
        public void setDatanascimento(string dataNovo)
        {
            this.dataNascimento = dataNovo;
        }

        public string getValidadeCnh()
        {
            return this.validadeCnh;
        }
        public void setValidadeCnh(string validadeNovo)
        {
            this.validadeCnh = validadeNovo;
        }

    }


}
