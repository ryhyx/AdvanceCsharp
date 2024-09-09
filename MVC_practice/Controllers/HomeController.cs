using Microsoft.AspNetCore.Mvc;
using MVC_practice.Models;
using MVC_practice.Models.Repo_pattern;
using System.Diagnostics;

namespace MVC_practice.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IpersonRepository _personRepository;
        private readonly IBookRepository _bookRepository;
        public HomeController(ILogger<HomeController> logger , IpersonRepository personrepository, IBookRepository bookRepository)
        {
            _logger = logger;
            _personRepository = personrepository;
            _bookRepository = bookRepository;
        
        }

        public IActionResult Index()
        {
            _bookRepository.GetAll();
            return View();
            Person person1 = new Person()
            {
                Id = 1,
                Fname = "Reihaneh",
                Lname = "Shakiba"
            };
            //var personPersonRepository = new PersonRepository();
            //personPersonRepository.AddPerson(person1);
            _personRepository.AddPerson(person1);
        }
        public string Hello()
        {
            return DateTime.Now.ToString();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
