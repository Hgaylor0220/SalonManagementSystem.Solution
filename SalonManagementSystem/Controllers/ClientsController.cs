using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalonManagementSystem.Models;

namespace SalonManagementSystem.Controllers
{
    public class ClientsController : Controller
    {
        private readonly SalonManagementSystemContext _db;

        public ClientsController(SalonManagementSystemContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            List<SClient> model = _db.Clients.ToList();
            return View(model);
        }

    }