using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herança
{
    public class Funcionario : Pessoa 
    {
        //--- Inicio Artributos ---                
        private string cpf;        
        private string cargo;        
        private double salario;       
        private string estadoCivil;
        //--- Fim Artributos ---

        //--- Inicio Construtores ---
        public Funcionario()
        {

        }

        public Funcionario(string nome, string cpf, string dataNascimento, string sexo,
            string cargo, string telefone, string endereco, string email,
            string estadoCivil, double salario) : base(nome,dataNascimento,sexo,telefone,endereco,email) {               

                this.cpf = cpf;                
                this.cargo = cargo;                
                this.estadoCivil = estadoCivil;
                this.salario = salario;
        }
        //--- Fim Construtores ---

        //--- Inicio Metodos ---
       
        public string getCpf()
        {
            return this.cpf;
        }
        public void setCpf(string novo)
        {
            this.cpf = novo;
        }
        
        public string getCargo()
        {
            return this.cargo;
        }
        public void setCargo(string novo)
        {
            this.cargo = novo;
        }      

        public string getEstadoCivil()
        {
            return this.estadoCivil;
        }
        public void setEstadoCivil(string novo)
        {
            this.estadoCivil = novo;
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
