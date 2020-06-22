using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WatchDog.API.Models;
using WatchDog.API.Classes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WatchDog.API.Controllers
{
    [Route("[controller]")]
    [ApiController]

    public class ProductsController : ControllerBase
    {
        private readonly Models.AppContext _context;

        public ProductsController(Models.AppContext context) {
            _context = context;

            _context.Database.EnsureCreated();
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts([FromQuery] Classes.ProductQueryParameters queryParameters) {
            IQueryable<Product> products = _context.Products;

            // Filter by Min/Max Price
            if (queryParameters.MinPrice != null &&
                queryParameters.MaxPrice != null)
            {
                products = products.Where(
                    p => p.Price >= queryParameters.MinPrice.Value &&
                    p.Price <= queryParameters.MaxPrice.Value);
            }

            // Filter by SKU
            if (!string.IsNullOrEmpty(queryParameters.Sku))
            {
                products = products.Where(p => p.Sku.ToLower() == queryParameters.Sku.ToLower());
            }

            // Search by Name
            if (!string.IsNullOrEmpty(queryParameters.Name))
            {
                products = products.Where(p => p.Name.ToLower().Contains(queryParameters.Name.ToLower()));
            }

            if (!string.IsNullOrEmpty(queryParameters.SortBy))
            {
                if (typeof(Product).GetProperty(queryParameters.SortBy) != null)
                {
                    products = products.OrderByCustom(queryParameters.SortBy, queryParameters.SortOrder);
                }
            }

            // Paginate results
            products = products
                .Skip(queryParameters.Size * (queryParameters.Page - 1))
                .Take(queryParameters.Size);

            // Query results
            var productsArray = await products.ToArrayAsync();
            if (productsArray == null) {
                return NotFound();
            }

            return Ok(productsArray);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetProduct(int id) {
            var product = await _context.Products.FindAsync(id);
            if (product == null) {
                return NotFound();
            }

            return Ok(product);
        }
    }
}
