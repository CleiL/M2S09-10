using labclothingcollectionbd.Context;
using labclothingcollectionbd.Mockusuario;
using labclothingcollectionbd.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace labclothingcollectionbd.Controllers
{
    [Route("api/v{version:apiVersion}/LAB")]
    [ApiController]
    public class LABController : ControllerBase
    {

        private readonly LABDbContext _labcontext;

        public LABController(LABDbContext labdbcontext)
        {
            _labcontext = labdbcontext;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 
        
        // GET: api/<LABController>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var Usuarios = await _labcontext.Usuarios.ToListAsync().ConfigureAwait(true);
            return Ok(Usuarios);
        }

        // GET api/<LABController>/5
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            Usuario usuario = await _labcontext.Usuarios.FirstOrDefaultAsync(x => x.Id == id).ConfigureAwait(true);
            if (usuario is null)
            {
                return NotFound();
            }

            return Ok(usuario);
        }

        // POST api/<LABController>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Usuario usuario)
        {
            _labcontext.Usuarios.Add(usuario);

            await _labcontext.SaveChangesAsync();

            return CreatedAtAction(nameof(Get), new {id = usuario.Id});
        }

        // PUT api/<LABController>/5
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(Guid id, [FromBody] Usuario usuario)
        {
            bool existeUsuario = await _labcontext.Usuarios.AnyAsync(x => x.Id == id).ConfigureAwait(true);
            if (!existeUsuario)
            {
                return NotFound();
            }

            _labcontext.Entry(usuario).State = EntityState.Modified;

            await _labcontext.SaveChangesAsync();

            return NoContent();
        }

        // DELETE api/<LABController>/5
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var usuario = await _labcontext.Usuarios.FirstOrDefaultAsync(x => x.Id == id).ConfigureAwait(true);
            if (usuario is null)
            {
                return NotFound();
            }
            _labcontext.Usuarios.Remove(usuario);

            await _labcontext.SaveChangesAsync();

            return NoContent();
        }
    }
}
