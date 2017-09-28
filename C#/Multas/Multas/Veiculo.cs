using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multas
{
    public class Veiculo
    {
        // --- Inicio Artributos ---
        private string placa;
        private string ano;
        private string cpf;
        private string marca;
        private string modelo;

        // --- Fim Artributos ---

        // --- Inicio Construtores ---
        public Veiculo() { 
        
        }

        public Veiculo(string cpfC, string placaC, string modeloC,string marcaC, string anoC)
        {
            this.cpf = cpfC;
            this.placa = placaC;
            this.modelo = modeloC;
            this.marca = marcaC;
            this.ano = anoC;
        }
        // --- Fim Construtores ---
        
        // --- Inicio Metodos --- 
        public string getPlaca(){
            return this.placa;
        }
        public void setPlaca(string placaNovo) {
            this.placa = placaNovo;
        }

        public string getCpf()
        {
            return this.cpf;
        }
        public void setCpf(string cpfNovo)
        {
            this.cpf = cpfNovo;
        }

        public string getModelo()
        {
            return this.modelo;
        }
        public void setModelo(string modeloNovo)
        {
            this.modelo = modeloNovo;
        }

        public string getMarca()
        {
            return this.marca;
        }
        public void setMarca(string marcaNovo)
        {
            this.marca = marcaNovo;
        }       

        public string getAno()
        {
            return this.ano;
        }
        public void setAno(string dataNovo)
        {
            this.ano = dataNovo;
        }
        // --- Fim Metodos --- 
    }
}
