using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SimpleTest.Models;

namespace SimpleTest.Controllers
{
    public class UserInformationController : Controller
    {
        private readonly SimpleTestDbContext _context;

        public UserInformationController(SimpleTestDbContext context)
        {
            _context = context;
        }
        public IActionResult Create(bool? result)
        {
            ViewBag.result = result != null ? result : false;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,name,phoneNumber,email")] UserInformation userInformation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userInformation);
                await _context.SaveChangesAsync();
                return RedirectToAction("Create", new { result = true });
            }
            return RedirectToAction("Create", new { result = false});
        }
       
    }
}
