using Microsoft.AspNetCore.Mvc;
using MovieManagerMVC.Data.Services;
using MovieManagerMVC.Models;

namespace MovieManagerMVC.Controllers
{
    public class ActorsController : Controller
    {
        private readonly IActorsService _actorService;

        public ActorsController(IActorsService actorService)
        {
            _actorService = actorService;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _actorService.GetAllAsync();
            return View(data);
        }
        //Get: Actors/Create
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePicture,Bio")]Actor actor)
        {
            if(!ModelState.IsValid)
            {
                return View(actor);
            }
            await _actorService.AddAsync(actor);
            return RedirectToAction(nameof(Index));
        }
        //Get: Actors/Details/1
        public async Task<IActionResult> Details(int id)
        {
            var actorDetails = await _actorService.GetByIdAsync(id);
            if(actorDetails == null)
                return View("Empty");
            return View(actorDetails);
        }
    }
}
