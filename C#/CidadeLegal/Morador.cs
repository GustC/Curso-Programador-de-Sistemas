using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CidadeLegal
{
    public class Morador
    {
        // --- Inicio Artributos ---
        private string nome;
        private string sexo;
        private string endereco;
        private string dataNascimento;
        private string cpf;
        private string telefone;
        // --- Fim Artributos ---

        // --- Inicio Construtores ---
        public Morador()
        {

        }

        public Morador(string nomeM, string cpfM, string enderecoM, string telefoneM)
        {
            this.cpf = cpfM;
            this.nome = nomeM;
            this.endereco = enderecoM;
            this.telefone = telefoneM;
        }

        public Morador(string nomeM, string cpfM, string enderecoM, string telefoneM, string dataNascimentoM
            , string sexoM)
        {
            this.cpf = cpfM;
            this.nome = nomeM;
            this.endereco = enderecoM;
            this.telefone = telefoneM;
            this.sexo = sexoM;
            this.dataNascimento = dataNascimentoM;
        }
        // --- Fim Construtores ---

        // --- Inicio Metodos ---
        public string getNome()
        {
            return this.nome;
        }
        public void setNome(string nomeNovo)
        {
            this.nome = nomeNovo;
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

        public string getTelefone()
        {
            return this.telefone;
        }
        public void setTelefone(string telefoneNovo)
        {
            this.telefone = telefoneNovo;
        }

        public string getDataNascimento()
        {
            return this.dataNascimento;
        }
        public void setDataNascimento(string dataNascimentoNovo)
        {
            this.dataNascimento = dataNascimentoNovo;
        }

        public string getSexo()
        {
            return this.sexo;
        }
        public void setSexo(string sexoNovo)
        {
            this.sexo = sexoNovo;
        }
        // --- Fim Metodos ---
    }
}
