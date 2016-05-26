using System.Web.Mvc;
using BusinessLogic;
using DBRepo;

namespace PetesWebThing2.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			var cardHandler = new CardHandler(new CardRepository());

			ViewBag.BlackCard = cardHandler.GetBlackCard();
			ViewBag.WhiteCard = cardHandler.GetWhiteCard();

			return View();
		}
	}
}
