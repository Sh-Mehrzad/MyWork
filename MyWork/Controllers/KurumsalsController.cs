using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyWork.Models;

namespace MyWork.Controllers
{
    public class KurumsalsController : Controller
    {
        private readonly MyWorkContext _context;

        public KurumsalsController(MyWorkContext context)
        {
            _context = context;
        }

        // GET: Kurumsals
        public async Task<IActionResult> Index()
        {
            return View(await _context.Kurumsal.ToListAsync());
        }

        // GET: Kurumsals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kurumsal = await _context.Kurumsal
                .FirstOrDefaultAsync(m => m.ID == id);
            if (kurumsal == null)
            {
                return NotFound();
            }

            return View(kurumsal);
        }

        // GET: Kurumsals/Create
        public IActionResult Create()
        {            
            ViewBag.IlList = Illist();
            ViewBag.IlceList = Ilcelist();
            ViewBag.PaketList = PaketList();
            ViewBag.ReklamList = ReklamList();
            return View();
        }

        // POST: Kurumsals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,FirmaAdi,VergiDairesi,VergiNo,Adres,Telefon,Fax,Email,Website,Yetkili,GSM,Not")] Kurumsal kurumsal)
        {
            if (ModelState.IsValid)
            {
                kurumsal.AppliedDate = DateTime.Now;
                _context.Add(kurumsal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kurumsal);
        }

        // GET: Kurumsals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kurumsal = await _context.Kurumsal.FindAsync(id);
            if (kurumsal == null)
            {
                return NotFound();
            }
            return View(kurumsal);
        }

        // POST: Kurumsals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,FirmaAdi,VergiDairesi,VergiNo,Adres,Telefon,Fax,Email,Website,Yetkili,GSM,Not,AppliedDate")] Kurumsal kurumsal)
        {
            if (id != kurumsal.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kurumsal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KurumsalExists(kurumsal.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(kurumsal);
        }

        // GET: Kurumsals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kurumsal = await _context.Kurumsal
                .FirstOrDefaultAsync(m => m.ID == id);
            if (kurumsal == null)
            {
                return NotFound();
            }

            return View(kurumsal);
        }

        // POST: Kurumsals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kurumsal = await _context.Kurumsal.FindAsync(id);
            _context.Kurumsal.Remove(kurumsal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KurumsalExists(int id)
        {
            return _context.Kurumsal.Any(e => e.ID == id);
        }

        private List<SelectListItem> Illist()
        {
            List<SelectListItem> ls = new List<SelectListItem>();
            foreach (var item in _context.Il.ToList())
            {
                ls.Add(new SelectListItem { Text = item.IlAdi, Value = item.ID.ToString() });
            }
            return ls;
        }
        private List<SelectListItem> Ilcelist()
        {
            List<SelectListItem> ls = new List<SelectListItem>();
            foreach (var item in _context.Ilce.ToList())
            {
                ls.Add(new SelectListItem { Text = item.IlceAdi, Value = item.ID.ToString() });
            }
            return ls;
        }

        private List<SelectListItem> PaketList()
        {
            List<SelectListItem> ls = new List<SelectListItem>();
            foreach (var item in _context.Paket.ToList())
            {
                ls.Add(new SelectListItem { Text = item.PaketName, Value = item.ID.ToString() });
            }
            return ls;
        }

        private List<SelectListItem> ReklamList()
        {
            List<SelectListItem> ls = new List<SelectListItem>();
            foreach (var item in _context.Reklam.ToList())
            {
                ls.Add(new SelectListItem { Text = item.ReklamName, Value = item.ID.ToString() });
            }
            return ls;
        }
    }
}
