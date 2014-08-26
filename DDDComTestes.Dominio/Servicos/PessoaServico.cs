﻿using System;
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

        public void AdicionarCNH(int pessoaID, string numeroCNH)
        {
            Pessoa pessoa = _pessoaRepositorio.CarregarPorID(pessoaID);

            if (null == pessoa)
            {
                //TODO especializar a exception ou retornar um Result preparado.
                throw new Exception(
                    string.Format(
                        "Pessoa ID {0} não existe."
                      , pessoaID));
            }

            if (pessoa.Idade < 18)
            {
                //TODO especializar a exception ou retornar um Result preparado.
                throw new Exception(
                    string.Format(
                        "Impossível adicionar um documento do tipo CNH, pessoa ID {0} é menor, maioridade: {1}."
                      , pessoaID
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
