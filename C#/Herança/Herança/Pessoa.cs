using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herança
{
    public class Pessoa
    {
        //--- Inicio Artributos ---
        private string nome;
        private string dataNascimento;
        private string sexo;
        private string telefone;
        private string endereco;
        private string email;
        //--- Fim Artributos ---

        //--- Inicio Construtores ---
        public Pessoa() { 
        
        }

        public Pessoa(string nome, string dataNascimento, string sexo, string telefone,
        string endereco, string email) {
            this.nome = nome;
            this.dataNascimento = dataNascimento;
            this.sexo = sexo;
            this.telefone = telefone;
            this.endereco = endereco;
            this.email = email;

        }
        //--- Fim Construtores ---

        //--- Inicio Metodos ---
        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string novo)
        {
            this.nome = novo;
        }      

        public string getEmail()
        {
            return this.email;
        }
        public void setEmail(string novo)
        {
            this.email = novo;
        }

        public string getEndereco()
        {
            return this.endereco;
        }
        public void setEndereco(string novo)
        {
            this.endereco = novo;
        }  

        public string getTelefone()
        {
            return this.telefone;
        }
        public void setTelefone(string novo)
        {
            this.telefone = novo;
        }

        public string getDataNascimento()
        {
            return this.dataNascimento;
        }
        public void setDataNascimento(string novo)
        {
            this.dataNascimento = novo;
        }        

        public string getSexo()
        {
            return this.sexo;
        }
        public void setSexo(string novo)
        {
            this.sexo = novo;
        }
        //--- Fim Metodos ---
    }
}
