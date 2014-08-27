using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DDDComTestes.Dominio.Repositorios.Pessoas;
using DDDComTestes.Dominio.Servicos.Pessoas;
using DDDComTestes.Infraestrutura.Repositorio.FileSystem.Pessoas;
using DDDComTestes.Infraestrutura.Web.Models;

namespace DDDComTestes.Infraestrutura.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPessoaRepositorio _pessoaRepositorio;
        private readonly PessoaServico _pessoaServico;

        public HomeController()
        {
            _pessoaRepositorio = new PessoaRepositorio();
            _pessoaServico = new PessoaServico(_pessoaRepositorio);
        }

        public ActionResult Index()
        {
            IEnumerable<PessoaModel> pessoas = _pessoaRepositorio
                .CarregarTodos()
                .Select(pessoa => new PessoaModel(pessoa));

            return View(pessoas);
        }

        /*
         * Somente para demonstração de uso...
         */
        [HttpPost]
        public void AdicionarCNH(string cpf, string numeroCNH)
        {
            _pessoaServico.AdicionarCNH(cpf, numeroCNH);
        }
    }
}
