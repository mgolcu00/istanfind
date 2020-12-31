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
    public class ParkController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly UserManager<User> _userManager;

        public ParkController(ApplicationDbContext context, IWebHostEnvironment hostingEnvironment, UserManager<User> userManager)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }

        // GET: Parks
        public async Task<IActionResult> Index()
        {
            return View(await _context.Park.ToListAsync());
        }

        // GET: Parks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var park = await _context.Park
                .FirstOrDefaultAsync(m => m.Id == id);
            if (park == null)
            {
                return NotFound();
            }
            var dynmicModel = new DynmicViewModelP();
            dynmicModel.model = park;
            dynmicModel.comments = await _context.Comment.Where(x => x.PlaceId == park.Id && x.PlaceType == Constants.ParkType).ToListAsync();

            return View(dynmicModel);
        }

        // GET: Parks/Create
        [Authorize(Roles = Constants.AdministratorRole)]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddComment([Bind("Id,Text,Score,UserId,PlaceId")] Comment comment, [Bind("Id")] Park model)
        {
            if (ModelState.IsValid)
            {
                var id = _userManager.GetUserId(User);
                comment.UserId = id == null ? "non-user" : id;
                comment.UserName = _context.Users.Where(x => x.Id == id).ToArray()[0].Ad;
                comment.PlaceType = Constants.ParkType;
                comment.PlaceId = model.Id;
                _context.Add(comment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));//Details(model.Id).Result;
            }

            return RedirectToAction(nameof(Index)); /*View(comment);*/
        }
        // POST: Parks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = Constants.AdministratorRole)]
        public async Task<IActionResult> Create([Bind("Id,Name,PhoneNumber,WebSiteUrl,Adress,AdressUrl,Score,DataText,TitleText,ImageUrl")] Park park)
        {
            if (ModelState.IsValid)
            {
                //Resim ekleme
                string webRootPath = _hostingEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;


                string fileName = Guid.NewGuid().ToString();
                var uploads = Path.Combine(webRootPath, @"images\park");
                var extension = Path.GetExtension(files[0].FileName);

                using (var fileStream = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                park.ImageUrl = @"\images\park\" + fileName + extension;

                //********

                _context.Add(park);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(park);
        }

        // GET: Parks/Edit/5 
        [Authorize(Roles = Constants.AdministratorRole)]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var park = await _context.Park.FindAsync(id);
            if (park == null)
            {
                return NotFound();
            }
            return View(park);
        }

        // POST: Parks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = Constants.AdministratorRole)]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,PhoneNumber,WebSiteUrl,Adress,AdressUrl,Score,DataText,TitleText,ImageUrl")] Park park)
        {
            if (id != park.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(park);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ParkExists(park.Id))
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
            return View(park);
        }

        // GET: Parks/Delete/5
        [Authorize(Roles = Constants.AdministratorRole)]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var park = await _context.Park
                .FirstOrDefaultAsync(m => m.Id == id);
            if (park == null)
            {
                return NotFound();
            }

            return View(park);
        }

        // POST: Parks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = Constants.AdministratorRole)]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var park = await _context.Park.FindAsync(id);
            _context.Park.Remove(park);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ParkExists(int id)
        {
            return _context.Park.Any(e => e.Id == id);
        }
    }
    public class DynmicViewModelP
    {
        public IEnumerable<Comment> comments { get; set; }
        public Park model { get; set; }
        public Comment comment { get; set; }
    }
}
