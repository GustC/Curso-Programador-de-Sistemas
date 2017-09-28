using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidadeLegal
{
    public class Problema
    {
        // --- Inicio Artributos ---
        private string descricao;
        private string solucao;
        private double valor;
        private string causa;
        private string dataInicio;
        // --- Fim Atributos ---

        // --- Inicio Construtores ---
        public Problema()
        {

        }
        public Problema(string descricaoP, string causaP, string solucaoP)
        {
            this.descricao = descricaoP;
            this.causa = causaP;
            this.solucao = solucaoP;
        }

        public Problema(string descricaoP, string causaP, string solucaoP, double valorP, string dataInicioP)
        {
            this.descricao = descricaoP;
            this.causa = causaP;
            this.solucao = solucaoP;
            this.valor = valorP;
            this.dataInicio = dataInicioP;
        }
        // --- Fim Construtores ---

        // --- Inicio Metodos ---
        public string getDescricao()
        {
            return this.descricao;
        }
        public void setDescricao(string descricaoNovo)
        {
            this.descricao = descricaoNovo;
        }

        public string getCausa()
        {
            return this.causa;
        }
        public void setCausa(string causaNovo)
        {
            this.causa = causaNovo;
        }

        public string getSolucao()
        {
            return this.solucao;
        }
        public void setSolucao(string solucaoNovo)
        {
            this.solucao = solucaoNovo;
        }

        public double getValor()
        {
            return this.valor;
        }
        public void setValor(double valorNovo)
        {
            this.valor = valorNovo;
        }

        public string getDataInicio()
        {
            return this.dataInicio;
        }
        public void setDataInicio(string dataIncioNovo)
        {
            this.dataInicio = dataIncioNovo;
        }
        // --- Fim Metodos ---
    }
}
