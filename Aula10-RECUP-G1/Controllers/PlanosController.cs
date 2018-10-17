using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Aula10_Avaliacao_G1.Models;

namespace Aula10_Avaliacao_G1.Controllers
{
    public class PlanosController : Controller
    {
        private readonly IPlanoRepository _repository;

        public PlanosController(IPlanoRepository repository)
        {
            _repository = repository;
        }

        public IActionResult Index()
        {
            var planos = _repository.GetAll();          

            return View(planos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Plano plano)
        {
            _repository.Create(plano);

            return RedirectToAction("index");
        }


        public IActionResult Delete(int id)
        {
            _repository.Delete(id);
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            return View(_repository.GetById(id));
        }

        [HttpPost]
        public IActionResult Edit(Plano plano)
        {
            _repository.Update(plano);
            return RedirectToAction("Index");
        }
    
    }
}