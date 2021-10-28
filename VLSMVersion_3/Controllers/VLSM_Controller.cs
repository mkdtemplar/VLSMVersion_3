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
        public List<Lans> _LansList { get; set; }
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
            var model1 = new VLSM_Model(model.LansValues);
            
            if (ModelState.IsValid)
            {
                
                ViewData["IP_Address"] = model.IP_Address;

                ViewData["LansValues"] = model.LansValues;
                _LansList = model.LansValues;
                ViewData["cidrValue"] = model.cidrValue;
                ViewData["NetworkID"] = model.NetworkID();
                ViewData["TotalHosts"] = model.AvailableHosts();
                ViewData["FinalResult"] = model.getSubAndMask();
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
/*
        // GET: VLSM_Controller/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }
*/
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
