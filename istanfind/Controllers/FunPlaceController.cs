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
    public class FunPlaceController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly UserManager<User> _userManager;

        public FunPlaceController(ApplicationDbContext context, IWebHostEnvironment hostingEnvironment, UserManager<User> userManager)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        // GET: FunPlaces
        public async Task<IActionResult> Index()
        {
            return View(await _context.FunPlace.ToListAsync());
        }

        // GET: FunPlaces/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funPlace = await _context.FunPlace
                .FirstOrDefaultAsync(m => m.Id == id);
            if (funPlace == null)
            {
                return NotFound();
            }
            var dynmicModel = new DynmicViewModelF();
            dynmicModel.model = funPlace;
            dynmicModel.comments = await _context.Comment.Where(x => x.PlaceId == funPlace.Id && x.PlaceType==Constants.FunPlaceType).ToListAsync();

            return View(dynmicModel);
        }


        // GET: FunPlaces/Create
        [Authorize(Roles = Constants.AdministratorRole)]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddComment([Bind("Id,Text,Score,UserId,PlaceId")] Comment comment, [Bind("Id")] FunPlace model)
        {
            if (ModelState.IsValid)
            {
                var id = _userManager.GetUserId(User);
                comment.UserId = id == null ? "non-user" : id;
                comment.UserName = _context.Users.Where(x => x.Id == id).ToArray()[0].Ad;
                comment.PlaceType = Constants.FunPlaceType;
                comment.PlaceId = model.Id;
                _context.Add(comment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));//Details(model.Id).Result;
            }

            return RedirectToAction(nameof(Index)); /*View(comment);*/
        }
        // POST: FunPlaces/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,PhoneNumber,WebSiteUrl,Adress,AdressUrl,Score,DataText,TitleText,ImageUrl")] FunPlace funPlace)
        {
            if (ModelState.IsValid)
            {
                //Resim ekleme
                string webRootPath = _hostingEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;


                string fileName = Guid.NewGuid().ToString();
                var uploads = Path.Combine(webRootPath, @"images\funplace");
                var extension = Path.GetExtension(files[0].FileName);

                using (var fileStream = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                funPlace.ImageUrl = @"\images\funplace\" + fileName + extension;

                //********

                _context.Add(funPlace);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(funPlace);
        }

        // GET: FunPlaces/Edit/5
        [Authorize(Roles = Constants.AdministratorRole)]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funPlace = await _context.FunPlace.FindAsync(id);
            if (funPlace == null)
            {
                return NotFound();
            }
            return View(funPlace);
        }

        // POST: FunPlaces/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = Constants.AdministratorRole)]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,PhoneNumber,WebSiteUrl,Adress,AdressUrl,Score,DataText,TitleText,ImageUrl")] FunPlace funPlace)
        {
            if (id != funPlace.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(funPlace);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FunPlaceExists(funPlace.Id))
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
            return View(funPlace);
        }

        // GET: FunPlaces/Delete/5
        [Authorize(Roles = Constants.AdministratorRole)]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var funPlace = await _context.FunPlace
                .FirstOrDefaultAsync(m => m.Id == id);
            if (funPlace == null)
            {
                return NotFound();
            }

            return View(funPlace);
        }

        // POST: FunPlaces/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = Constants.AdministratorRole)]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var funPlace = await _context.FunPlace.FindAsync(id);
            _context.FunPlace.Remove(funPlace);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FunPlaceExists(int id)
        {
            return _context.FunPlace.Any(e => e.Id == id);
        }
    }
    public class DynmicViewModelF
    {
        public IEnumerable<Comment> comments { get; set; }
        public FunPlace model { get; set; }
        public Comment comment { get; set; }
    }
}
