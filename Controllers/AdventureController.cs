using System.Web.Mvc;
using FuzzyNinjectWarrior.Services;
using FuzzyNinjectWarrior.Models;

namespace FuzzyNinjectWarrior.Controllers
{
    public class AdventureController : Controller
    {
        private readonly IAdventureService _adventureService;

        public AdventureController(IAdventureService adventureService)
        {
            _adventureService = adventureService;
        }

        // GET: /Adventure/
        public ActionResult Index()
        {
            var player = _adventureService.GetCurrentPlayer();
            return View(player);
        }

        // POST: /Adventure/Attack
        [HttpPost]
        public ActionResult Attack(string enemyName, int weaponType)
        {
            var result = _adventureService.AttackEnemy(enemyName, (WeaponType)weaponType);
            return View("AttackResult", result);
        }
    }
}
