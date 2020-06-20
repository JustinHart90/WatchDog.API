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

    public class ShowsController : ControllerBase
    {
        private readonly Models.AppContext _context;

        public ShowsController(Models.AppContext context) {
            _context = context;

            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public IEnumerable<Show> GetAllShows() {
            return _context.Shows.ToArray();
        }
    }
}
