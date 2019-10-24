
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SalonManagementSystem.Models;
using SalonManagementSystem.Data;

namespace SalonManagementSystem.Controllers
{
    public class StylistsController : Controller
    {
        private readonly ApplicationDbContext _db;

        public StylistsController(ApplicationDbContext db)
        {
            _db =db;
        }

        public ActionResult Index()
        {
            List<Stylist> model =_db.Stylists.ToList();
            return View(model);
        }
    }
}
