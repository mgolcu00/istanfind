using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using istanfind.Data;
using istanfind.Models;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace istanfind.Controllers
{
    public class HistoricalPlaceController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly UserManager<User> _userManager;

        public HistoricalPlaceController(ApplicationDbContext context, IWebHostEnvironment hostingEnvironment, UserManager<User> userManager)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }


        // GET: HistoricalPlaces
        public async Task<IActionResult> Index()
        {
            return View(await _context.HistoricalPlace.ToListAsync());
        }

        // GET: HistoricalPlaces/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicalPlace = await _context.HistoricalPlace
                .FirstOrDefaultAsync(m => m.Id == id);
            if (historicalPlace == null)
            {
                return NotFound();
            }
            var dynmicModel = new DynmicViewModelH();
            dynmicModel.model = historicalPlace;
            dynmicModel.comments = await _context.Comment.Where(x => x.PlaceId == historicalPlace.Id && x.PlaceType == Constants.HistoricalPlaceType).ToListAsync();
            return View(dynmicModel);
        }

        // GET: HistoricalPlaces/Create
        [Authorize(Roles = Constants.AdministratorRole)]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddComment([Bind("Id,Text,Score,UserId,PlaceId")] Comment comment, [Bind("Id")] HistoricalPlace model)
        {
            if (ModelState.IsValid)
            {
                var id = _userManager.GetUserId(User);
                comment.UserId = id == null ? "non-user" : id;
                comment.UserName = _context.Users.Where(x => x.Id == id).ToArray()[0].Ad;
                comment.PlaceType = Constants.HistoricalPlaceType;
                comment.PlaceId = model.Id;
                _context.Add(comment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));//Details(model.Id).Result;
            }

            return RedirectToAction(nameof(Index)); /*View(comment);*/
        }
        // POST: HistoricalPlaces/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,PhoneNumber,WebSiteUrl,Adress,AdressUrl,Score,DataText,TitleText,ImageUrl")] HistoricalPlace historicalPlace)
        {
            if (ModelState.IsValid)
            {
                //Resim ekleme
                string webRootPath = _hostingEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;


                string fileName = Guid.NewGuid().ToString();
                var uploads = Path.Combine(webRootPath, @"images\historicalplace");
                var extension = Path.GetExtension(files[0].FileName);

                using (var fileStream = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                historicalPlace.ImageUrl = @"\images\historicalplace\" + fileName + extension;

                //********

                _context.Add(historicalPlace);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(historicalPlace);
        }

        // GET: HistoricalPlaces/Edit/5      
        [Authorize(Roles = Constants.AdministratorRole)]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicalPlace = await _context.HistoricalPlace.FindAsync(id);
            if (historicalPlace == null)
            {
                return NotFound();
            }
            return View(historicalPlace);
        }

        // POST: HistoricalPlaces/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = Constants.AdministratorRole)]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,PhoneNumber,WebSiteUrl,Adress,AdressUrl,Score,DataText,TitleText,ImageUrl")] HistoricalPlace historicalPlace)
        {
            if (id != historicalPlace.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(historicalPlace);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HistoricalPlaceExists(historicalPlace.Id))
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
            return View(historicalPlace);
        }

        // GET: HistoricalPlaces/Delete/5
        [Authorize(Roles = Constants.AdministratorRole)]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var historicalPlace = await _context.HistoricalPlace
                .FirstOrDefaultAsync(m => m.Id == id);
            if (historicalPlace == null)
            {
                return NotFound();
            }

            return View(historicalPlace);
        }

        // POST: HistoricalPlaces/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = Constants.AdministratorRole)]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var historicalPlace = await _context.HistoricalPlace.FindAsync(id);
            _context.HistoricalPlace.Remove(historicalPlace);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HistoricalPlaceExists(int id)
        {
            return _context.HistoricalPlace.Any(e => e.Id == id);
        }
    }
    public class DynmicViewModelH
    {
        public IEnumerable<Comment> comments { get; set; }
        public HistoricalPlace model { get; set; }
        public Comment comment { get; set; }
    }
}
