using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herança
{
    public class Professor
    {
        //--- Inicio Artributos ---
        private string nome;
        private string cpf;
        private string dataNascimento;
        private string disciplina;
        private string sexo;
        private double salario;
        private string telefone;
        private string endereco;
        private string email;
        private string estadoCivil;
        //--- Fim Artributos ---

        //--- Inicio Construtores ---
        public Professor()
        {

        }

        public Professor(string nome, string cpf, string dataNascimento, string sexo,
            string disciplina, string telefone, string endereco, string email, string estadoCivil, double salario) {
                this.nome = nome;
                this.cpf = cpf;
                this.dataNascimento = dataNascimento;
                this.sexo = sexo;
                this.disciplina = disciplina;
                this.telefone = telefone;
                this.endereco = endereco;
                this.email = email;
                this.estadoCivil = estadoCivil;
                this.salario = salario;
        }
        //--- Fim Construtores ---

        //--- Inicio Metodos ---
        public string getNome() {
            return this.nome;
        }
        public void setNome(string novo) {
            this.nome = novo;
        }

        public string getCpf()
        {
            return this.cpf;
        }
        public void setCpf(string novo)
        {
            this.cpf = novo;
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

        public string getDisciplina()
        {
            return this.disciplina;
        }
        public void setDisciplina(string novo)
        {
            this.disciplina = novo;
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

        public string getEstadoCivil()
        {
            return this.estadoCivil;
        }
        public void setEstadoCivil(string novo)
        {
            this.estadoCivil = novo;
        }

        public string getSexo()
        {
            return this.sexo;
        }
        public void setSexo(string novo)
        {
            this.sexo = novo;
        }

        public double getSalario() {
            return this.salario;
        }
        public void setSalario(double novo) {
            this.salario = novo;
        }    

        //--- Fim Metodos ---
    }
}
