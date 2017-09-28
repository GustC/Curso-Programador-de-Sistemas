using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaTv
{
    public class Combo
    {
        // --- Inicio Artributos ---
        private string nome;
        private double valor;
        private int nunPontos;
        private int qtdDigitais;
        private int qtdHd;
        private int qtdAbertos;
        private int qtdAudios;
        // --- Fim Artributos ---

        // --- Inicio Construtores ---
        public Combo() { 
        
        }

        public Combo(string nomeC,double valorC,int qtdDigitaisC,int qtdHdC
            ,int qtdAbertosC, int qtdAudiosC) {
                this.nome = nomeC;
                this.valor = valorC;
                this.qtdAbertos = qtdAbertosC;
                this.qtdAudios = qtdAudiosC;
                this.qtdDigitais = qtdDigitaisC;
                this.qtdHd = qtdHdC;
        }

        public Combo(string nomeC, double valorC, int qtdDigitaisC, int qtdHdC
            , int qtdAbertosC, int qtdAudiosC, int nunPontosC)
        {
            this.nome = nomeC;
            this.valor = valorC;
            this.qtdAbertos = qtdAbertosC;
            this.qtdAudios = qtdAudiosC;
            this.qtdDigitais = qtdDigitaisC;
            this.qtdHd = qtdHdC;
            this.nunPontos = nunPontosC;
        }
        // --- Fim Construtores ---

        // --- Inicio Metodos --- 
        public string getNome() {
            return this.nome;
        }
        public void setNome(string nomeNovo) {
            this.nome = nomeNovo;
        }

        public double getValor() {
            return this.valor;
        }
        public void setValor(double valorNovo){
            this.valor = valorNovo;
        }

        public int getQtdDigitais() {
            return this.qtdDigitais;
        }
        public void setQtdDigitais(int qtdNova) {
            this.qtdDigitais = qtdNova;
        }

        public int getQtdHd()
        {
            return this.qtdHd;
        }
        public void setQtdHd(int qtdNova)
        {
            this.qtdHd = qtdNova;
        }

        public int getQtdAbertos()
        {
            return this.qtdAbertos;
        }
        public void setQtdAbertos(int qtdNova)
        {
            this.qtdAbertos = qtdNova;
        }

        public int getQtdAudios()
        {
            return this.qtdAudios;
        }
        public void setQtdAudios(int qtdNova)
        {
            this.qtdAudios = qtdNova;
        }

        public int getNunPontos()
        {
            return this.nunPontos;
        }
        public void setNunPontos(int qtdNova)
        {
            this.nunPontos = qtdNova;
        }
        // --- Fim Metodos ---
    }
}
