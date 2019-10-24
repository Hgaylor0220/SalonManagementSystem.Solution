using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalonManagementSystem.Models;

namespace SalonManagementSystem.Controllers
{
    public class StylistsController : Controller
    {
        private readonly SalonManagementSystemContext _db;

        public StylistsController(SalonManagementSystemContext db)
        {
            _db =db;
        }
    }