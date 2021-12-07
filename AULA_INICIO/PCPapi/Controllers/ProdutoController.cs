using GenericController;
using GenericController.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GenericController_ini.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutoController : ControllerBase
    {
        protected DbAplication _context { get; set; }
        protected DbSet<Produto> _dbSet;

        public ProdutoController(DbAplication context)
        {

            _context = context;
            _dbSet = context.Set<Produto>();

        }

        [HttpGet]
        public async Task<ActionResult<List<Produto>>> Get()
        {
            return await _dbSet.ToListAsync();
        }

        [HttpGet("{id}")]
        public virtual async Task<ActionResult<Produto>> Get(int id)
        {
            var item = await _dbSet.FirstAsync(x => x.Id.Equals(id));


            if (item == null) { return NotFound(); }

            return item;
        }


        [HttpPost]
        public virtual async Task<ActionResult<Produto>> Post(Produto item)
        {
            _dbSet.Add(item);
            await _context.SaveChangesAsync();
            return item;
        }

        [HttpPut]
        public virtual async Task<ActionResult<Produto>> Put(Produto item)
        {
            _dbSet.Attach(item).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return item;
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var itemToRemove = await _dbSet.FirstOrDefaultAsync(x => x.Id.Equals(id));
            if (itemToRemove == null)
            {
                return NotFound();
            }

            _context.Remove(itemToRemove);
            await _context.SaveChangesAsync();
            return Ok("Item (" + id + "): Excluido com sucesso");
        }
    }
}
