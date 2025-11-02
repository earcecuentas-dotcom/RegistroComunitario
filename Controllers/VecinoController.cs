using RegistroComunitario.Models;
using Microsoft.AspNetCore.Mvc;

namespace RegistroComunitario.Controllers
{
	public class VecinoController : Controller
	{
		public IActionResult Index()
		{
			var lista = RepositorioVecinos.ObtenerTodos();
			return View(lista);
		}

		public IActionResult Crear()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Crear(Vecino vecino)
		{
			if (ModelState.IsValid)
			{
				RepositorioVecinos.Agregar(vecino);
				return RedirectToAction("Index");
			}

			return View(vecino);
		}
	}
}