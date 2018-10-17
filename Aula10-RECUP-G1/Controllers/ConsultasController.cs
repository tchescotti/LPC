using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Aula10_Avaliacao_G1.Models;

namespace Aula10_Avaliacao_G1.Controllers
{
    public class ConsultasController : Controller
    {
        private readonly IConsultaRepository _repositoryConsulta;
        private readonly IClienteRepository _repositoryCliente;

        public ConsultasController(IConsultaRepository repositoryConsulta, IClienteRepository repositoryCliente)
        {
            _repositoryConsulta = repositoryConsulta;
            _repositoryCliente = repositoryCliente;
        }

        public IActionResult Index()
        {
            var consultas = _repositoryConsulta.GetAll();          

            return View(consultas);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.consultas = _repositoryConsulta.GetAll();
            ViewBag.clientes = _repositoryCliente.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Create(Consulta consulta)
        {
            _repositoryConsulta.Create(consulta);

            return RedirectToAction("index");
        }


        public IActionResult Delete(int id)
        {
            _repositoryConsulta.Delete(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var consultas = _repositoryConsulta.GetById(id);
            ViewBag.clientes = _repositoryCliente.GetAll();
            return View(consultas); 
        }

        [HttpPost]
        public IActionResult Edit(Consulta consulta)
        {
            _repositoryConsulta.Update(consulta);
            return RedirectToAction("Index");
        }
    
    }
}