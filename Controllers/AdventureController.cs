using FuzzyNinjectWarrior.Models;
using FuzzyNinjectWarrior.Repositories;
using FuzzyNinjectWarrior.Services;
using System.Linq;
using System.Web.Mvc;

namespace FuzzyNinjectWarrior.Controllers
{
    public class AdventureController : Controller
    {
        private readonly IAdventureService _adventureService;
        private readonly IPlayerRepository _playerRepo;

        public AdventureController(IAdventureService adventureService, IPlayerRepository playerRepo)
        {
            _adventureService = adventureService;
            _playerRepo = playerRepo;
        }

        // GET: /Adventure/
        public ActionResult Index()
        {
            var player = _playerRepo.GetPlayerById(1); // Demo: single player
            var enemies = _playerRepo.GetAllEnemies().ToList();
            ViewBag.Player = player;
            ViewBag.Enemies = enemies;
            return View();
        }

        [HttpPost]
        public ActionResult Attack(int enemyId, WeaponType weapon)
        {
            var result = _adventureService.Attack(1, enemyId, weapon); // Demo: single player
            ViewBag.Result = result;
            return View("AttackResult");
        }
    }
}
