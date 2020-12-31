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
    public class RestaurantController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly UserManager<User> _userManager;

        public RestaurantController(ApplicationDbContext context, IWebHostEnvironment hostingEnvironment, UserManager<User> userManager)
        {
            _context = context;
            _hostingEnvironment = hostingEnvironment;
            _userManager = userManager;
        }


        // GET: Restaurants
        public async Task<IActionResult> Index()
        {
            return View(await _context.Restaurant.ToListAsync());
        }

        // GET: Restaurants/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurant = await _context.Restaurant
                .FirstOrDefaultAsync(m => m.Id == id);
            if (restaurant == null)
            {
                return NotFound();
            }
            var dynmicModel = new DynmicViewModelR();
            dynmicModel.model = restaurant;
            dynmicModel.comments = await _context.Comment.Where(x => x.PlaceId == restaurant.Id && x.PlaceType == Constants.RestaurantType).ToListAsync();

            return View(dynmicModel);
        }

        // GET: Restaurants/Create
        [Authorize(Roles = Constants.AdministratorRole)]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddComment([Bind("Id,Text,Score,UserId,PlaceId")] Comment comment, [Bind("Id")] Restaurant model)
        {
            if (ModelState.IsValid)
            {
                var id = _userManager.GetUserId(User);
                comment.UserId = id == null ? "non-user" : id;
                comment.UserName = _context.Users.Where(x => x.Id == id).ToArray()[0].Ad;
                comment.PlaceType = Constants.RestaurantType;
                comment.PlaceId = model.Id;
                _context.Add(comment);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));//Details(model.Id).Result;
            }


            return RedirectToAction(nameof(Index)); /*View(comment);*/
        }
        // POST: Restaurants/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = Constants.AdministratorRole)]
        public async Task<IActionResult> Create([Bind("Id,Name,PhoneNumber,WebSiteUrl,Adress,AdressUrl,Score,DataText,TitleText,ImageUrl")] Restaurant restaurant)
        {
            if (ModelState.IsValid)
            {
                //Resim ekleme
                string webRootPath = _hostingEnvironment.WebRootPath;
                var files = HttpContext.Request.Form.Files;


                string fileName = Guid.NewGuid().ToString();
                var uploads = Path.Combine(webRootPath, @"images\restaurant");
                var extension = Path.GetExtension(files[0].FileName);

                using (var fileStream = new FileStream(Path.Combine(uploads, fileName + extension), FileMode.Create))
                {
                    files[0].CopyTo(fileStream);
                }
                restaurant.ImageUrl = @"\images\restaurant\" + fileName + extension;

                //********

                _context.Add(restaurant);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(restaurant);
        }

        // GET: Restaurants/Edit/5
        [Authorize(Roles = Constants.AdministratorRole)]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurant = await _context.Restaurant.FindAsync(id);
            if (restaurant == null)
            {
                return NotFound();
            }
            return View(restaurant);
        }

        // POST: Restaurants/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = Constants.AdministratorRole)]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,PhoneNumber,WebSiteUrl,Adress,AdressUrl,Score,DataText,TitleText,ImageUrl")] Restaurant restaurant)
        {
            if (id != restaurant.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(restaurant);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RestaurantExists(restaurant.Id))
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
            return View(restaurant);
        }

        // GET: Restaurants/Delete/5
        [Authorize(Roles = Constants.AdministratorRole)]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var restaurant = await _context.Restaurant
                .FirstOrDefaultAsync(m => m.Id == id);
            if (restaurant == null)
            {
                return NotFound();
            }

            return View(restaurant);
        }

        // POST: Restaurants/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = Constants.AdministratorRole)]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var restaurant = await _context.Restaurant.FindAsync(id);
            _context.Restaurant.Remove(restaurant);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RestaurantExists(int id)
        {
            return _context.Restaurant.Any(e => e.Id == id);
        }
    }
    public class DynmicViewModelR
    {
        public IEnumerable<Comment> comments { get; set; }
        public Restaurant model { get; set; }
        public Comment comment { get; set; }
    }
}
