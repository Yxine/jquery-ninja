using jQueryNinja.Models;
using Microsoft.AspNetCore.Mvc;

namespace jQueryNinja.Controllers
{

	/// <summary></summary>
	public class NewsController : Controller
	{

		/// <summary></summary>
		private readonly ILogger<HomeController> _logger;

		/// <summary>Конструктор</summary>
		/// <param name="logger">Объект логирования</param>
		public NewsController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		/// <summary>Главная</summary>
		/// <returns>Вьюшка</returns>
		[Route("/news")]
		public IActionResult Index()
		{
			var model = NewsModel.News.Take(3).ToList();
			return View(model);
		}

		/// <summary></summary>
		/// <returns>Вьюшка</returns>
		[Route("/news/lazy")]
		public IActionResult Lazy()
		{
			return View();
		}

		/// <summary></summary>
		/// <returns>Вьюшка</returns>
		[Route("/news/more/{page}")]
		public IActionResult More(int page)
		{
			var model = NewsModel.News.Skip(page * 3).Take(3).ToList();
			return View(model);
		}

	}

}
