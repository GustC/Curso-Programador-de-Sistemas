using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaTv
{
    public class Programacao
    {   
        // --- Inicio Artributos ---
        private string nome;
        private string descricao;
        private string horaInicio;
        private string horaTermino;
        private string data;
        private int faixa;
        // --- Fim Artributos ---

        // --- Inicio Construtores ---
        public Programacao() { 
        
        } 

        public Programacao(string nomeP,string horaInicioP,string horaTerminoP
            ,string dataP,int faixaP,string descricaoP) {
                this.nome = nomeP;
                this.horaInicio = horaInicioP;
                this.horaTermino = horaTerminoP;
                this.data = dataP;
                this.faixa = faixaP;
                this.descricao = descricaoP;
        
        }
        // --- Fim Construtores ---

        // --- Inicio Metodos ---
        public string getNome() {
            return this.nome;
        }
        public void setNome(string nomeNovo) {
            this.nome = nomeNovo;
        }
    
        public string getHoraInicio() {
            return this.horaInicio;
        }
        public void setHoraInicio(string horaNovo) {
            this.horaInicio = horaNovo;
        }

        public string getHoraTermino()
        {
            return this.horaTermino;
        }
        public void setHoraTermino(string horaNovo)
        {
            this.horaTermino = horaNovo;
        }

        public string getData()
        {
            return this.data;
        }
        public void setData(string dataNovo)
        {
            this.data = dataNovo;
        }

        public int getFaixa() {
            return this.faixa;        
        }
        public void setFaixa(int faixaNova) {
            this.faixa = faixaNova;
        }

        public string getDescricao() {
            return this.descricao;
        }
        public void setDescricao(string descricaoNova) {
            this.descricao = descricaoNova;
        }


        // --- Fim Metodos ---
    }
}
