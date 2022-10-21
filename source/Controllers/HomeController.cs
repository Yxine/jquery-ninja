using jQueryNinja.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace jQueryNinja.Controllers
{

	/// <summary></summary>
	public class HomeController : Controller
	{

		/// <summary></summary>
		private readonly ILogger<HomeController> _logger;

		/// <summary>Конструктор</summary>
		/// <param name="logger">Объект логирования</param>
		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		/// <summary>Главная</summary>
		/// <returns>Вьюшка</returns>
		[Route("/")]
		public IActionResult Index()
		{
			return View();
		}

		/// <summary></summary>
		/// <returns>Вьюшка</returns>
		[Route("/jquery")]
		public IActionResult Jquery()
		{
			return View();
		}

		/// <summary></summary>
		/// <returns>Вьюшка</returns>
		[Route("/security")]
		public IActionResult Security()
		{
			return View();
		}

		/// <summary></summary>
		/// <returns>Вьюшка</returns>
		[Route("/sandbox")]
		public IActionResult Sandbox()
		{
			return View();
		}

		/// <summary>Обработчик ошибок</summary>
		/// <returns>Вьюшка</returns>
		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

	}

}
