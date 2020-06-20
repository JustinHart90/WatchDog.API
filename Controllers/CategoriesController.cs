using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchDog.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WatchDog.API.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class CategoriesController : ControllerBase
    {
        private readonly Models.AppContext _context;

        public CategoriesController(Models.AppContext context) {
            _context = context;

            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public IEnumerable<Category> GetAllCategories() {
            return _context.Categories.ToArray();
        }
    }
}
