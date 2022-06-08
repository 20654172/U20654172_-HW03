using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace U20654172_HW03.Controllers
{
    public class FileController : Controller

    {

        // GET: File
        [HttpGet]
        public ActionResult Index()
        {
            string[] filepaths = Directory.GetFiles(Server.MapPath("~/Media/Document/"));
            List<Models.FileModel> files = new List<Models.FileModel>();

            foreach (string filePath in filepaths)
            {
                files.Add(new Models.FileModel { FileName = Path.GetFileName(filePath) });
            }

            return View(files);
        }

        //code to download the files
        public ActionResult DownloadFile(string fileName)
        {
            string path = Server.MapPath("~/Media/Document/") + fileName;
            byte[] bytes = System.IO.File.ReadAllBytes(path);

            return File(bytes, "application/octet-stream", fileName);
        }

          //code to delete the files
        public ActionResult DeleteFile(string fileName)
        {
            string path = Server.MapPath("~/Media/Document/") + fileName;
            byte[] bytes = System.IO.File.ReadAllBytes(path);

            System.IO.File.Delete(path);

            return RedirectToAction("Index");

        }
    }
}