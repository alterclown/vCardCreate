using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using vCardCreate.Models;

namespace vCardCreate.Controllers
{
    public class vCardController : Controller
    {
        // GET: vCard
        public ActionResult Index()
        {
            //vCard add = new vCard();
            //var get = from c in vCard
            //          orderby c.FirstName ascending
            //          select c;
            return View();
        }

        // GET: vCard/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: vCard/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: vCard/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> vCard()
        {
            var vcard = new vCard();
            vcard.FirstName = "Gunnar";
            vcard.LastName = "Peipman";
            vcard.Organization = "Freelancer";
            vcard.JobTitle = "Chief Everything Office";
            vcard.StreetAddress = "Test";
            vcard.Zip = "Lisbon-101";
            vcard.City = "Tallinn";
            vcard.CountryName = "Estonia";
            vcard.Phone = "00-12345";
            vcard.Mobile = "00-10101";
            vcard.Email = "gunnar@example.com";
            vcard.HomePage = "https://stackoverflow.com/";
            vcard.Image = await System.IO.File.ReadAllBytesAsync("gunnar300.jpg");

            return new vCardActionResult(vcard);

            //var vcard = new vCard();
            //vcard.FirstName = vcard.FirstName;
            //vcard.LastName = vcard.LastName;
            //vcard.Organization = vcard.Organization;
            //vcard.JobTitle = vcard.JobTitle;
            //vcard.StreetAddress = vcard.StreetAddress;
            //vcard.Zip = vcard.Zip;
            //vcard.City = vcard.City;
            //vcard.CountryName = vcard.CountryName;
            //vcard.Phone = vcard.Phone;
            //vcard.Mobile = vcard.Mobile;
            //vcard.Email = vcard.Email;
            //vcard.HomePage = vcard.HomePage;
            //vcard.Image = await System.IO.File.ReadAllBytesAsync(vcard.Image.ToString());

            //return new vCardActionResult(vcard);
        }

        // GET: vCard/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: vCard/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: vCard/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: vCard/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        //[HttpGet]
        //public async Task<IActionResult> Download()
        //{
        //    var path = @"C:\Users\rahir\Downloads\file_example_WAV_1MG.wav";
        //    var memory = new MemoryStream();
        //    using (var stream = new FileStream(path, FileMode.Open))
        //    {
        //        await stream.CopyToAsync(memory);
        //    }
        //    memory.Position = 0;
        //    var ext = Path.GetExtension(path).ToLowerInvariant();
        //    return File(memory, GetMimeTypes()[ext], Path.GetFileName(path));
        //}

        //private Dictionary<string, string> GetMimeTypes()
        //{
        //    return new Dictionary<string, string>
        //{
        //    {".txt", "text/plain"},
        //    {".pdf", "application/pdf"},
        //    {".doc", "application/vnd.ms-word"},
        //    {".docx", "application/vnd.ms-word"},
        //    {".png", "image/png"},
        //    {".jpg", "image/jpeg"},
        //    {".vcf", "text/x-vcard"},
        //    {".wav", "audio/wav"},
        //};
        //}
    }
}