using System;
using DDDComTestes.Dominio.Entidades.Pessoas;
using DDDComTestes.Dominio.Repositorios.Pessoas;
using DDDComTestes.Dominio.Servicos.Pessoas;
using Moq;
using NUnit.Framework;

namespace DDDComTestes.Dominio.Test.Pessoas
{
    [TestFixture]
    public class PessoaServicoTest
    {
        [Test(Description = "AdicionarCNH falha por tentar adicionar uma CNH para um menor.")]
        public void AdicionarCNHFalhaPorSerMenorTest()
        {
            var pessoaRepositorioMock = new Mock<IPessoaRepositorio>();

            var menor = new Pessoa();

            menor.Idade = 17;

            pessoaRepositorioMock
                .Setup(pessoaRepositorio => pessoaRepositorio.CarregarPorCPF(It.IsAny<string>()))
                .Returns(menor);

            var pessoaServico = new PessoaServico(pessoaRepositorioMock.Object);

            Assert.Throws<Exception>(() => pessoaServico.AdicionarCNH(It.IsAny<string>(), It.IsAny<string>()));

            pessoaRepositorioMock.Verify(pessoaRepositorio => pessoaRepositorio.Salvar(It.IsAny<Pessoa>()), Times.Never());
        }

        [Test(Description = "AdicionarCNH adiciona uma CNH para um maior.")]
        public void AdicionarCNHAdicionaParaUmMaiorTest()
        {
            var pessoaRepositorioMock = new Mock<IPessoaRepositorio>();

            var menor = new Pessoa();

            menor.Idade = 18;

            pessoaRepositorioMock
                .Setup(pessoaRepositorio => pessoaRepositorio.CarregarPorCPF(It.IsAny<string>()))
                .Returns(menor);

            var pessoaServico = new PessoaServico(pessoaRepositorioMock.Object);

            pessoaServico.AdicionarCNH(It.IsAny<string>(), It.IsAny<string>());

            pessoaRepositorioMock.Verify(pessoaRepositorio => pessoaRepositorio.Salvar(It.IsAny<Pessoa>()), Times.AtLeastOnce());
        }
    }
}
