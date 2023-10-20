using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Forms.Pessoas.Pessoas.Models
{
    public class PessoaModel
    {
        public string Acesso {  get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }
        public DateTime DataCadastro { get; set; }

        public PessoaModel(string acesso, string nome, string cpf, string senha, DateTime dataCadastro)
        {
            Acesso = acesso;
            Nome = nome;
            Cpf = cpf;
            Senha = senha;
            DataCadastro = dataCadastro;
        }
        public PessoaModel()
        {
            
        }
        public List<PessoaModel> ObterDados()
        {
            List<PessoaModel> lista = new List<PessoaModel>() {
                new PessoaModel("HERLI","Herlison Silva Assunção","03934235220","TesteSenha",DateTime.Now),
                new PessoaModel("BRISA","Igor Alexandre de Oliveira", "00000000000","MinhaSenha", DateTime.Now),
                new PessoaModel("HELI","Hélica Lucivane Silva Assunção", "02002814295","123HAHAHA", DateTime.Now),
                new PessoaModel("NUZA","Ivanuza Machado da Silva", "02819286340","Seila", DateTime.Now)
            };
            return lista;
        }
    }
}
