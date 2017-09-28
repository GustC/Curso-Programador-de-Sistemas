using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidadeLegal
{
    public class Cidade
    {
        // --- Inicio Atributos ---
        private string nome;
        private int populacao;
        private double area;
        private string clima;
        // --- Fim Artributos ---

        // --- Inicio Construtor ---
        public Cidade(string nomeC, int populacaoC, double areaC, string climaC)
        {
            this.nome = nomeC;
            this.populacao = populacaoC;
            this.area = areaC;
            this.clima = climaC;
        }

        public Cidade(string nomeC, int populacaoC, string climaC)
        {
            this.nome = nomeC;
            this.populacao = populacaoC;
            this.clima = climaC;
        }

        public Cidade(string nomeC)
        {
            this.nome = nomeC;
        }
        // --- Fim construtor ---

        // --- Começo Metodos ---
        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string nomeNovo)
        {
            this.nome = nomeNovo;
        }

        public int getPopulacao()
        {
            return this.populacao;
        }
        public void setPopulacao(int populacaoNova)
        {
            this.populacao = populacaoNova;
        }

        public string getClima()
        {
            return this.clima;
        }
        public void setClima(string climaNovo)
        {
            this.clima = climaNovo;
        }

        public double getArea()
        {
            return this.area;
        }
        public void setArea(double areaNova)
        {
            this.area = areaNova;
        }

        // --- Fim Metodos ---
    }
}
