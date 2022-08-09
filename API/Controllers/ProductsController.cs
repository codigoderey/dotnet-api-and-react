using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using API.Data;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class ProductsController : ControllerBase
    {
      private readonly StoreContext context;
      public ProductsController(StoreContext context)
      {
        this.context = context;
      }

      //  get all products
      [HttpGet]
      // question mark means that can return null
      public async Task<ActionResult<List<Product>>> GetProducts()
      {
        return await context.Products.ToListAsync();
      }

      // get a single product by id
      [HttpGet("{id}")]
      public async Task<ActionResult<Product>> GetProduct(int? id)
      {
        return await context.Products.FindAsync(id);
      }
    }
}