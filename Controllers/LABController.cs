using labclothingcollectionbd.Mockusuario;
using labclothingcollectionbd.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace labclothingcollectionbd.Controllers
{
    [Route("api/v{version:apiVersion}/LAB")]
    [ApiController]
    public class LABController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// 
        
        // GET: api/<LABController>
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(MockUsuario.Usuarios);
        }

        // GET api/<LABController>/5
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            Usuario usuario = MockUsuario.Usuarios.FirstOrDefault(x => x.Id == id);
            if (usuario is null)
            {
                return NotFound();
            }

            return Ok(usuario);
        }

        // POST api/<LABController>
        [ProducesResponseType(StatusCodes.Status201Created)]
        [HttpPost]
        public IActionResult Post([FromBody] Usuario usuario)
        {
            MockUsuario.Usuarios.Add(usuario);

            return CreatedAtAction(nameof(Get), new {id = usuario.Id});
        }

        // PUT api/<LABController>/5
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Usuario usuario)
        {
            Usuario usuarioUpdate = MockUsuario.Usuarios.FirstOrDefault(x => x.Id == id);
            if (usuarioUpdate is null)
            {
                return NotFound();
            }

            var index = MockUsuario.Usuarios.IndexOf(usuarioUpdate);
            if (index != -1)
            {
                MockUsuario.Usuarios[index] = usuario;
            }
            return NoContent();
        }

        // DELETE api/<LABController>/5
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            Usuario usuarioUpdate = MockUsuario.Usuarios.FirstOrDefault(x => x.Id == id);
            if (usuarioUpdate is null)
            {
                return NotFound();
            }
            MockUsuario.Usuarios.Remove(usuarioUpdate);

            return NoContent();
        }
    }
}
