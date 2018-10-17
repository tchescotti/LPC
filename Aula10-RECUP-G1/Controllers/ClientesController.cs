using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Aula10_Avaliacao_G1.Models;

namespace Aula10_Avaliacao_G1.Controllers
{
    public class ClientesController : Controller
    {
        private readonly IClienteRepository _repositoryCliente;
        private readonly IPlanoRepository _repositoryPlano;

        public ClientesController(IClienteRepository repositoryCliente, IPlanoRepository repositoryPlano)
        {
            _repositoryCliente = repositoryCliente;
            _repositoryPlano = repositoryPlano;
        }

        public IActionResult Index()
        {
            var clientes = _repositoryCliente.GetAll();          

            return View(clientes);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.clientes = _repositoryCliente.GetAll();
            ViewBag.planos = _repositoryPlano.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            _repositoryCliente.Create(cliente);

            return RedirectToAction("index");
        }


        public IActionResult Delete(int id)
        {
            _repositoryCliente.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var clientes = _repositoryCliente.GetById(id);
            ViewBag.planos = _repositoryPlano.GetAll();
            return View(clientes); 
        }

        [HttpPost]
        public IActionResult Edit(Cliente cliente)
        {
            _repositoryCliente.Update(cliente);
            return RedirectToAction("Index");
        }
    
    }
}