using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVC.CsiSmb.Models;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace MVC.CsiSmb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var sharedFolder = new SharedFolderModel();

            sharedFolder.IsAccessible = Directory.Exists(sharedFolder.MountPath);

            if (sharedFolder.IsAccessible)
            {
                sharedFolder.FileEntries = Directory.GetFiles(sharedFolder.MountPath);

                sharedFolder.HasFiles = (sharedFolder.FileEntries?.Length > 0);
            }

            return View(sharedFolder);
        }

        [HttpPost]
        public IActionResult Index([Bind("TestFileName")] SharedFolderModel sharedFolderModel)
        {
            var sharedFolder = new SharedFolderModel();

            sharedFolder.IsAccessible = Directory.Exists(sharedFolder.MountPath);

            if (sharedFolder.IsAccessible)
            {
                var filePath = $"{sharedFolder.MountPath}/{sharedFolderModel.TestFileName}";

                if (!string.IsNullOrEmpty(filePath))
                {
                    using var fs = System.IO.File.Create(filePath);
                    // Add some information to the file.
                    byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                    fs.Write(info, 0, info.Length);
                }

                sharedFolder.FileEntries = Directory.GetFiles(sharedFolder.MountPath);

                sharedFolder.HasFiles = (sharedFolder.FileEntries?.Length > 0);
            }

            return View(sharedFolder);
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
