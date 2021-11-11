using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contracts;
using DatabaseContext;
using Microsoft.EntityFrameworkCore;
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

        private VlsmDb _context;
        private IRepositoryManager _repositoryManager;

        public VLSM_Controller(IRepositoryManager repositoryManager, VlsmDb context)
        {
            _repositoryManager = repositoryManager;
            _context = context;
        }

        // POST: VLSM_Controller/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(VLSM_Model model)
        {

            if (ModelState.IsValid)
            {

                ViewData["IP_Address"] = model.IP_Address;

                ViewData["LansValues"] = model.LansValues;
                _LansList = model.LansValues;
                ViewData["cidrValue"] = model.cidrValue;
                ViewData["NetworkID"] = model.NetworkID();
                ViewData["TotalHosts"] = model.AvailableHosts(); 
                ViewData["FinalResult"] = model.GetSubAndMask();
            }


            return View("VlsmResultNew");
        }

        [HttpGet]
        public IActionResult DisplayDatabase()
        {
            return View(_repositoryManager.Vlsm.GetAllResults(trackChanges: false));
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

        
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vlsmresult = await _context.Vlsmresults
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vlsmresult == null)
            {
                return NotFound();
            }

            return View(vlsmresult);
        }

        // POST: Vlsmresults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            var vlsmresult = await _context.Vlsmresults.FindAsync(id);
            _context.Vlsmresults.Remove(vlsmresult);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(DisplayDatabase));
        }

        private bool VlsmresultExists(long id)
        {
            return _context.Vlsmresults.Any(e => e.Id == id);
        }
        
    }
}
