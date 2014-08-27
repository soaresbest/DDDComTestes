using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using DDDComTestes.Dominio.Repositorios.Pessoas;
using DDDComTestes.Infraestrutura.Repositorio.FileSystem.Pessoas;
using DDDComTestes.Infraestrutura.Web.Models;

namespace DDDComTestes.Infraestrutura.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPessoaRepositorio _pessoaRepositorio;

        public HomeController()
        {
            _pessoaRepositorio = new PessoaRepositorio();
        }

        public ActionResult Index()
        {
            IEnumerable<PessoaModel> pessoas = _pessoaRepositorio
                .CarregarTodos()
                .Select(pessoa => new PessoaModel(pessoa));

            return View(pessoas);
        }
    }
}
