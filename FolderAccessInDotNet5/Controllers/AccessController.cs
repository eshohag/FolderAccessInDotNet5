using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace FolderAccessInDotNet5.Controllers
{
    public class AccessController : Controller
    {
        private readonly IWebHostEnvironment _environment;

        public AccessController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public IActionResult Index()
        {
            //string modelsFolderAccess =Path.Combine(Directory.GetCurrentDirectory(), "Models");    //Old Way
            string contentRootPath = Path.Combine(_environment.ContentRootPath, "Models");
            string webRootPath = Path.Combine(_environment.WebRootPath, "js");

            string[] filePaths = Directory.GetFiles(contentRootPath);

            return View();
        }
    }
}
