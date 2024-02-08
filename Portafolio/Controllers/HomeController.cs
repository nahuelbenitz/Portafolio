using Microsoft.AspNetCore.Mvc;
using Portafolio.interfaces;
using Portafolio.Models;
using Portafolio.Servicios;
using System.Diagnostics;

namespace Portafolio.Controllers
{
	public class HomeController : Controller
	{
		private readonly IRepositorioProyectos _repositorioProyectos;
		private readonly IServicioEmail _servicioEmail;

		public HomeController(IRepositorioProyectos repositorioProyectos, IServicioEmail servicioEmail)
		{
			_repositorioProyectos = repositorioProyectos;
			_servicioEmail = servicioEmail;
		}

        [HttpGet]
        public IActionResult Index()
		{
			var proyectos = _repositorioProyectos.obtenerProyectos().Take(3).ToList();
			var modelo = new HomeIndexViewModel() { Proyectos = proyectos };
			return View(modelo);
		}

		[HttpGet]
		public IActionResult Contacto()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Contacto(ContactoViewModel contactoViewModel)
		{
			await _servicioEmail.Enviar(contactoViewModel);
			return RedirectToAction("Gracias");
		}

		public IActionResult Gracias()
		{
			return View();
		}

        [HttpGet]
        public IActionResult Proyectos()
		{
			var proyectos = _repositorioProyectos.obtenerProyectos();
			return View(proyectos);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
