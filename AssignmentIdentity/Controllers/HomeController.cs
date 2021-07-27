using AssignmentIdentity.Models;
using AssignmentIdentity.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AssignmentIdentity.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICarRepository carRepository;
        private readonly IHostingEnvironment hostingEnviroment;


        public HomeController(ILogger<HomeController> logger, ICarRepository carRepository, IHostingEnvironment hostingEnviroment)
        {
            _logger = logger;
            this.carRepository = carRepository;
            this.hostingEnviroment = hostingEnviroment;
        }

        public IActionResult Index()
        {
            CarListViewModel carListViewModel = new CarListViewModel()
            {
                Cars = carRepository.AllCars
            };
            return View(carListViewModel);
        }

        public IActionResult AddCar (NewCarViewModel newCar)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (newCar.Photo != null)
                {
                    string uploadsFolder = Path.Combine(hostingEnviroment.WebRootPath, "img");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + newCar.Photo.FileName;
                    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                    newCar.Photo.CopyTo(new FileStream(filePath, FileMode.Create));
                    Car car = new Car
                        {
                            Marka = newCar.Marka,
                            Model = newCar.Model,
                            Godiste = newCar.Godiste,
                            ZapreminaMotora = newCar.ZapreminaMotora,
                            Opis = newCar.Opis,
                            Gorivo = newCar.Gorivo,
                            Karoserija = newCar.Karoserija,
                            Snaga = newCar.Snaga,
                            Kontakt = newCar.Kontakt,
                            Cijena = newCar.Cijena,
                            Fotografija = uniqueFileName
                        }; carRepository.AddCar(car);
                }

            }
            return View();
        }
        [Authorize]
        public IActionResult Delete (int id)
        {
            carRepository.DeleteCar(id);
            return RedirectToAction("Index");
        }
        public IActionResult ONama()
        {
            return View();
        }
        public IActionResult Kontakt()
        {
            return View();
        }
        public IActionResult Details(int id)
        {
            var car = carRepository.GetCarById(id);
            if (car == null)
            {
                return NotFound();
            }
   
            return View(car);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
