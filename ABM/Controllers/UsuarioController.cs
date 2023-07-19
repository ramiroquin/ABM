using DataBase;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ABM.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly UsuarioContext _dbcontext;

        public UsuarioController( UsuarioContext context)
        {
            _dbcontext = context;
        }

        [HttpGet]
        [Route("Listar")]
        public IActionResult Listar()
        {
            List<Usuario> lista = new List<Usuario>();

            try
            {
                lista = _dbcontext.usuarios.ToList();
                return Ok(lista);

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }

        [HttpGet]
        [Route("Obtener/{id:int}")]
        public IActionResult Obtener(int id)
        {
            Usuario? oUsuario = _dbcontext.usuarios.Find(id);

            if (oUsuario == null)
                return NotFound("No existe el usuario");
            
            try
            {
                oUsuario = _dbcontext.usuarios.Where(c => c.Id == id).FirstOrDefault();
                return Ok(oUsuario);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }

        [HttpPost]
        [Route("Guardar")]
        public IActionResult Guardar([FromBody] Usuario usuario)
        {
            try
            {
                if (string.IsNullOrEmpty(usuario.Nombre))
                    return BadRequest("Complete el campo Nombre");
                
                if (string.IsNullOrEmpty(usuario.Nombre))
                    return BadRequest("Complete el campo Email");
                
                if (_dbcontext.usuarios.Any(c => c.Email == usuario.Email))
                    return BadRequest("El e-mail ya existe");
                
                usuario.Id = 0;
                _dbcontext.usuarios.Add(usuario);
                _dbcontext.SaveChanges();
                return Ok("Usuario guardado");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }

        [HttpPut]
        [Route("Editar")]
        public IActionResult Editar(int id, [FromBody] Usuario usuario)
        {
            Usuario? oUsuario = _dbcontext.usuarios.Find(id);

            if (oUsuario == null)
                return BadRequest("No existe el usuario");

            try
            {
                oUsuario.Nombre = usuario.Nombre;
                oUsuario.Email = usuario.Email;
                usuario.Id = oUsuario.Id;
                usuario.FechaCreacion = oUsuario.FechaCreacion;

                if (_dbcontext.usuarios.Any(c => c.Email == usuario.Email))
                    return BadRequest("El e-mail ya existe");
                
                _dbcontext.Update(oUsuario);
                _dbcontext.SaveChanges();

                return Ok("Usuario modificado");
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }

        [HttpDelete]
        [Route("Eliminar/{id:int}")]
        public IActionResult Eliminar(int id)
        {
            Usuario? oUsuario = _dbcontext.usuarios.Find(id);

            if (oUsuario == null)
                return NotFound("No existe el usuario");

            try
            {
                _dbcontext.usuarios.Remove(oUsuario);
                _dbcontext.SaveChanges();

                return StatusCode(StatusCodes.Status200OK, new { mensaje = "Usuario eliminado" });
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status200OK, new { mensaje = ex.Message });
            }
        }
    }
}
