using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaTv
{
    public class Cliente
    {
        // --- Inicio Artributos ---
        private string nome;
        private string dataNascimento;
        private string cpf;
        private string sexo;
        private string endereco;
        private string telefone;
        private string email;

        // --- Fim Artributos ---

        // --- Inicio Construtores ---
        public Cliente() { 
        
        }

        public Cliente(string cpfC, string nomeC,string enderecoC, string telefoneC) {
            this.cpf = cpfC;
            this.nome = nomeC;
            this.endereco = enderecoC;
            this.telefone = telefoneC;
        }

        public Cliente(string cpfC, string nomeC, string enderecoC, string telefoneC,string sexoC,string emailC
            ,string dataNascimentoC)
        {
            this.cpf = cpfC;
            this.nome = nomeC;
            this.endereco = enderecoC;
            this.telefone = telefoneC;
            this.sexo = sexoC;
            this.email = emailC;
            this.dataNascimento = dataNascimentoC;
        }
        // --- Fim Construtores ---
        
        // --- Inicio Metodos --- 
        public string getNome(){
            return this.nome;
        }
        public void setNome(string nomeNovo) {
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

        public string getEndereco()
        {
            return this.endereco;
        }
        public void setEndereco(string enderecoNovo)
        {
            this.endereco = enderecoNovo;
        }

        public string getSexo()
        {
            return this.sexo;
        }
        public void setSexo(string sexoNovo)
        {
            this.sexo = sexoNovo;
        }

        public string getTelefone()
        {
            return this.telefone;
        }
        public void setTelefone(string telefoneNovo)
        {
            this.telefone = telefoneNovo;
        }

        public string getEmail()
        {
            return this.email;
        }
        public void setEmail(string emailNovo)
        {
            this.email = emailNovo;
        }

        public string getDataNascimento()
        {
            return this.dataNascimento;
        }
        public void setDatanascimento(string dataNovo)
        {
            this.dataNascimento = dataNovo;
        }
        // --- Fim Metodos --- 
    }
}
