using System;
using DDDComTestes.Dominio.Entidades.Pessoas;
using DDDComTestes.Dominio.Repositorios.Pessoas;

namespace DDDComTestes.Dominio.Servicos
{
    public class PessoaServico
    {
        private readonly IPessoaRepositorio _pessoaRepositorio;
        private const int MAIORIDADE = 18;

        public PessoaServico(IPessoaRepositorio pessoaRepositorio)
        {
            _pessoaRepositorio = pessoaRepositorio;
        }

        public int Maioridade
        {
            get { return MAIORIDADE; }
        }

        public void AdicionarCNH(string cpf, string numeroCNH)
        {
            Pessoa pessoa = _pessoaRepositorio.CarregarPorCPF(cpf);

            if (null == pessoa)
            {
                //TODO especializar a exception ou retornar um Result preparado.
                throw new Exception(
                    string.Format(
                        "Nenhuma pessoa encontrada com o CPF {0}"
                      , cpf));
            }

            if (pessoa.Idade < 18)
            {
                //TODO especializar a exception ou retornar um Result preparado.
                throw new Exception(
                    string.Format(
                        "Impossível adicionar um documento do tipo CNH, pessoa ID {0} é menor, maioridade: {1}."
                      , pessoa.ID
                      , MAIORIDADE));
            }

            var cnh = new Documento();

            cnh.Numero = numeroCNH;
            cnh.Tipo = TipoDocumento.CNH;

            pessoa.Documentos.Add(cnh);

            _pessoaRepositorio.Salvar(pessoa);
        }
    }
}
