using _01_ServiceLifetimes.Services;
using Microsoft.AspNetCore.Mvc;

namespace _01_ServiceLifetimes.Controllers
{

    // https://localhost:7136/Services
    public class ServicesController : Controller
    {
        private readonly ISingletonService _singletonService;
        private readonly IScopedService _scopedService;
        private readonly ITransientService _transientService;
        private readonly IFileManager _fileManager;

        public ServicesController(ISingletonService singletonService, IScopedService scopedService, ITransientService transientService, IFileManager fileManager)
        {
            _singletonService = singletonService;
            _scopedService = scopedService;
            _transientService = transientService;
            _fileManager = fileManager;
        }


        // https://localhost:7136/Services/Singleton
        public IActionResult Files()
        {
            return View(_fileManager);
        }



        // https://localhost:7136/Services/Singleton
        public IActionResult Singleton()
        {
            return View(_singletonService);
        }

        // https://localhost:7136/Services/Scoped
        public IActionResult Scoped()
        {
            return View(_scopedService);
        }

        // https://localhost:7136/Services/Transient
        public IActionResult Transient()
        {
            return View(_transientService);
        }
    }
}



/*  
 
public void DoSomething(ISingletonService model) 
{
    model.GetGuid();

}
 

DoSomething(_singletonService);
 
 
*/