using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaFinanceiro
{
    public class Usuario
    {
        private string nome;
        private string telefone;
        private string email;
        private string sexo;
        private string dataNascimento;
        private string profissao;
        private string salario;

        public Usuario() { 
        
        }

        public Usuario(string nome, string telefone, string email, string sexo, string dataNascimento, string profissao, string salario) {
            this.nome = nome;
            this.telefone = telefone;
            this.email = email;
            this.sexo = sexo;
            this.dataNascimento = dataNascimento;
            this.profissao = profissao;
            this.salario = salario;        
        }

        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string nomeNovo)
        {
            this.nome = nomeNovo;
        }

        public string getTelefone() {
            return this.telefone;
        }
        public void setTelefone(string novo) {
            this.telefone = novo;
        }

        public string getEmail()
        {
            return this.email;
        }
        public void setEmail(string novo)
        {
            this.email = novo;
        }

        public string getSexo()
        {
            return this.sexo;
        }
        public void setSexo(string novo)
        {
            this.sexo = novo;
        }

        public string getProfissao()
        {
            return this.profissao;
        }
        public void setProfissao(string novo)
        {
             this.profissao = novo;
        }

        public string getSalario()
        {
            return this.salario;
        }
        public void setSalario(string novo)
        {
            this.salario = novo;
        }

        public string getDataNascimento()
        {
            return this.dataNascimento;
        }
        public void setDatanascimento(string dataNovo)
        {
            this.dataNascimento = dataNovo;
        }
        
    }
}
