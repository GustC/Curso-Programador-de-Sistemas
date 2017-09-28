using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SistemaTv
{
    public class canal
    {
        // --- Inicio Artributos ---
        private string nome;
        private int numero;
        private string descricao;
        private string categoria;
        private string subCategoria;
        // --- Fim Artributos ---

        // --- Inicio Construtores ---
        public canal() { 
                    
        }
        public canal(string nomeC,int numeroC) {
            this.nome = nomeC;
            this.numero = numeroC;
        }
        public canal(string nomeC, int numeroC,string categoriaC,string subCategoriaC,string descricaoC)
        {
            this.nome = nomeC;
            this.numero = numeroC;
            this.categoria = categoriaC;
            this.subCategoria = subCategoriaC;
            this.descricao = descricaoC;
        }

        // --- Fim Construtores ---

        // --- Inicio Metodos ---
        public string getNome(){
            return this.nome;
        }
        public void setNome(string nomeNovo) {
            this.nome = nomeNovo;
        }

        public string getCategoria()
        {
            return this.categoria;
        }
        public void setCategoria(string categoriaNovo)
        {
            this.categoria = categoriaNovo;
        }

        public string getSubCategoria()
        {
            return this.subCategoria;
        }
        public void setSubCategoria(string subNovo)
        {
            this.nome = subNovo;
        }

        public int getNumero()
        {
            return this.numero;
        }
        public void setNumero(int numeroNovo)
        {
            this.numero = numeroNovo;
        }

        public string getDescricao()
        {
            return this.descricao;
        }
        public void setDescricao(string descricaoNova)
        {
            this.descricao = descricaoNova;
        }
        // --- Fim Metodos --- 
    }
}
