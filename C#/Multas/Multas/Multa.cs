using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Multas
{
    public class Multa
    {
        // --- Inicio Artributos ---
        private string codigoMulta;
        private string PlacaCarro;
        private string cpf;
        private string descricao;
        private string endereco;
        private double valor;
        private string pontos;

        // --- Fim Artributos ---

        // --- Inicio Construtores ---
        public Multa() { 
        
        }

        public Multa(string cpfC, string codigoMultaC, double valorC,string descricaoC,string pontosC
            ,string PlacaCarroC)
        {
            this.cpf = cpfC;
            this.codigoMulta = codigoMultaC;
            this.valor = valorC;
            this.descricao = descricaoC;
            this.pontos = pontosC;
            this.PlacaCarro = PlacaCarroC;
        }
        // --- Fim Construtores ---
        
        // --- Inicio Metodos --- 
        public string getcodigoMulta(){
            return this.codigoMulta;
        }
        public void setcodigoMulta(string codigoMultaNovo) {
            this.codigoMulta = codigoMultaNovo;
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

        public string getdescricao()
        {
            return this.descricao;
        }
        public void setdescricao(string descricaoNovo)
        {
            this.descricao = descricaoNovo;
        }

        public double getvalor()
        {
            return this.valor;
        }
        public void setvalor(double valorNovo)
        {
            this.valor = valorNovo;
        }

        public string getpontos()
        {
            return this.pontos;
        }
        public void setpontos(string pontosNovo)
        {
            this.pontos = pontosNovo;
        }

        public string getPlacaCarro()
        {
            return this.PlacaCarro;
        }
        public void setPlacaCarro(string dataNovo)
        {
            this.PlacaCarro = dataNovo;
        }
        // --- Fim Metodos --- 
    }
}
