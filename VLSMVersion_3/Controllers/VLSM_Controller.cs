using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VLSMVersion_3.Models;

namespace VLSMVersion_3.Controllers
{
    public class VLSM_Controller : Controller
    {
        
        // GET: VLSM_Controller/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: VLSM_Controller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VLSM_Model model)
        {
            if (ModelState.IsValid)
            {
                ViewData["IP_Address"] = model.IP_Address;
                foreach (var value in model.LansValues)
                {
                    ViewBag["LanValues"] = value;
                }
                ViewData["cidrValue"] = model.cidrValue;
                ViewData["NetworkID"] = model.NetworkID();
                ViewData["TotalHosts"] = model.AvailableHosts();
            }

            return View("VlsmResult");
        }

        public ActionResult VlsmResult()
        {
            return View();
        }

        // POST: VLSM_Controller/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(VlsmResult));
            }
            catch
            {
                return View("Create");
            }
        }

        // GET: VLSM_Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: VLSM_Controller/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(VlsmResult));
            }
            catch
            {
                return View("Index");
            }
        }
        
    }
}
