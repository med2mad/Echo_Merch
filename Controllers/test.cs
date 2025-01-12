using Microsoft.AspNetCore.Mvc;

namespace Echo_Merch.Controllers
{
	[Controller]
	public class asdasd : Controller

	{
		public JsonResult Index()
		{
			return Json("[]");
		}

		[Route("/tst")]
		public string tst()
		{
			return "tst";
		}
	}
}
