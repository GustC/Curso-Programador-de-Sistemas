using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herança
{
    public class Aluno
    {
        //--- Inicio Artributos ---
        private string nome;
        private string dataNascimento;
        private string sexo;
        private string telefone;
        private string endereco;
        private string email;
        private string serie;
        private string rg;
        private string responsavel;
        private string cpfResponsavel;
        //--- Fim Artributos ---

        //--- Inicio Construtores ---
        public Aluno()
        {

        }

        public Aluno(string nome, string cpfResponsavel, string dataNascimento, string sexo,
            string serie, string telefone, string endereco, string email, string rg, string responsavel)
        {
            this.nome = nome;
            this.cpfResponsavel = cpfResponsavel;
            this.dataNascimento = dataNascimento;
            this.sexo = sexo;
            this.serie = serie;
            this.telefone = telefone;
            this.endereco = endereco;
            this.email = email;
            this.rg = rg;
            this.responsavel = responsavel;
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

        public string getcpfResponsavel()
        {
            return this.cpfResponsavel;
        }
        public void setcpfResponsavel(string novo)
        {
            this.cpfResponsavel = novo;
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

        public string getSerie()
        {
            return this.serie;
        }
        public void setSerie(string novo)
        {
            this.serie = novo;
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

        public string getRg()
        {
            return this.rg;
        }
        public void setRg(string novo)
        {
            this.rg = novo;
        }

        public string getSexo()
        {
            return this.sexo;
        }
        public void setSexo(string novo)
        {
            this.sexo = novo;
        }

        public string getResponsavel()
        {
            return this.responsavel;
        }
        public void setResponsavel(string novo)
        {
            this.responsavel = novo;
        }

        //--- Fim Metodos ---
    }
}



