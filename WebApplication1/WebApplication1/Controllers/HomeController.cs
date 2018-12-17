using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using Microsoft.Extensions.FileProviders;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFileProvider fileProvider;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IConfiguration Configuration;

        public HomeController(IFileProvider fileProvider, IHostingEnvironment hostingEnvironment, IConfiguration Configuration)
        {
            this.fileProvider = fileProvider;
            _hostingEnvironment = hostingEnvironment;
            this.Configuration = Configuration;
        }

        public IActionResult Index()
        {
            // return View();
            var model = new FilesViewModel();

            foreach (var item in this.fileProvider.GetDirectoryContents("").OrderByDescending(f => f.LastModified))
            {
                model.Files.Add(
                    new FileDetails {
                        Name = item.Name,
                        Path = item.PhysicalPath,
                        LastModified = item.LastModified.LocalDateTime
                    });

                Console.WriteLine(item.LastModified.LocalDateTime);
            }

            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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

        public IActionResult UploadFile()
        {
            ViewData["Message"] = "UploadFile";

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return Content("file not selected");

            // Console.WriteLine(_hostingEnvironment.WebRootPath);
            var path = Path.Combine(
                        Directory.GetCurrentDirectory(), _hostingEnvironment.WebRootPath, "UploadFiles", file.FileName);

            using (var stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            return RedirectToAction("Files");
        }

        [HttpPost]
        public async Task<IActionResult> UploadAlbum(AlbumModel album)
        {
            if (album.Files == null || album.Files.Count == 0)
                return Content("file not selected");

            string sUploadFiles = Configuration.GetSection("UploadFiles").Value;
            //  album.Title.Trim(' ') DateTime.Now.ToString("yyyyMMddHHmmssfff")

            foreach (var file in album.Files)
            {
                var path = Path.Combine(
                        Directory.GetCurrentDirectory(), _hostingEnvironment.WebRootPath, sUploadFiles, Guid.NewGuid().ToString() + file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> UploadFiles(List<IFormFile> files)
        {
            if (files == null || files.Count == 0)
                return Content("files not selected");

            foreach (var file in files)
            {
                var path = Path.Combine(
                        Directory.GetCurrentDirectory(), "", file.FileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }

            return RedirectToAction("Files");
        }

        public IActionResult MyCarousel()
        {
            var model = new FilesViewModel();

            foreach (var item in this.fileProvider.GetDirectoryContents(""))
            {
                model.Files.Add(
                    new FileDetails { Name = item.Name, Path=item.PhysicalPath, LastModified = item.LastModified.Date });
            }

            return View(model);
        }

        public JsonResult JsonCarousel()
        {
            var model = new FilesViewModel();

            foreach (var item in this.fileProvider.GetDirectoryContents(""))
            {
                model.Files.Add(
                    new FileDetails { Name = item.Name, Path = "/UploadFiles/" + item.Name });
            }

            return Json(model);
        }

        public IActionResult Files()
        {
            var model = new FilesViewModel();

            foreach (var item in this.fileProvider.GetDirectoryContents(""))
            {
                model.Files.Add(
                    new FileDetails { Name = item.Name, Path = item.PhysicalPath });
            }

            return View(model);
        }
    }
}
