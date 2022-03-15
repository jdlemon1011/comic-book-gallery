using Microsoft.AspNetCore.Mvc;

namespace ComicBooksGallery.Controllers
{
	public class ComicBooksController : Controller
	{
		public IActionResult Detail()
		{
			return View();
			
		}
	}
}
