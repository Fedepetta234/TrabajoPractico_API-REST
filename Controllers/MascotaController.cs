using Microsoft.AspNetCore.Mvc;

namespace Tp_Api_PettaFederico.Controllers;

[ApiController]
[Route("[controller]")]
public class MascotaController : ControllerBase
{
    private static readonly List<Mascota> mascotas = new()
    {
        new Perro { Id = 1, Nombre = "Firulas", Edad = 5, Raza = "Labrador" },
        new Gato { Id = 2, Nombre = "Luna", Edad = 3, Color = "Naranja" },
        new Perro { Id = 3, Nombre = "Rocky", Edad = 8, Raza = "Salchicha" },
        new Gato { Id = 4, Nombre = "Michi", Edad = 10, Color = "Negro" }
    };


    private readonly ILogger<MascotaController> _logger;

    public MascotaController(ILogger<MascotaController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Get()
    {
        foreach(Mascota m in mascotas)
        {
            if(m is Perro)
            {
                return Ok((Perro)m);
            }
            if(m is Gato)
            {
                return Ok((Gato)m);
            }
        }
        return NotFound("Mascota no encontrada");
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        foreach(Mascota m in mascotas)
        {
            if(m.Id == id)
            {
                return Ok(m);
            }
        }
        return NotFound("Mascota no encontrada");
    }

    [HttpGet("mayores-a/{edad}")]
    public IActionResult GetByEdad(int edad)
    {
        List<Mascota> mascotasMayores = new();

        foreach (Mascota m in mascotas)
        {
            if (m.Edad > edad)
            {
                mascotasMayores.Add(m);
            }
        }

        if (mascotasMayores.Count == 0)
        {
            return NotFound("No hay mascotas mayores a esa edad");
        }

        return Ok(mascotasMayores);
    }

    [HttpGet("tipo/{tipo}")]
    public IActionResult GetByTipo(string tipo)
    {
        List<Mascota> tipos = new();

        foreach (Mascota m in mascotas)
        {
            if(tipo.ToLower() == "perro" && m is Perro)
            {
                tipos.Add(m);
            }
            else if(tipo.ToLower() == "gato" && m is Gato)
            {
                tipos.Add(m);
            }
        }

        if (tipos.Count == 0)
        {
            return NotFound("No hay mascotas del tipo especificado");
        }

        return Ok(tipos);
    }
    
    [HttpPost("perros")]
    public IActionResult CreatePerro([FromBody]Perro nuevoPerro)
    {
        mascotas.Add(nuevoPerro);
        return Ok("Perro creado exitosamente");
    }

    [HttpPost("gatos")]
    public IActionResult CreateGatos([FromBody]Gato nuevoGato)
    {
        mascotas.Add(nuevoGato);
        return Ok("Gato creado exitosamente");
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, [FromBody]Mascota mascotaActualizada)
    {
        foreach(Mascota m in mascotas)
        {
            if(m.Id == id)
            {
                m.Nombre = mascotaActualizada.Nombre;
                m.Edad = mascotaActualizada.Edad;

                if(m is Perro)
                {
                    ((Perro)m).Raza = ((Perro)mascotaActualizada).Raza;
                }
                else if(m is Gato)
                {
                    ((Gato)m).Color = ((Gato)mascotaActualizada).Color;
                }

                return Ok("Mascota actualizada exitosamente");
            }
        }
        return NotFound("Mascota no encontrada");
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        foreach(Mascota m in mascotas)
        {
            if(m.Id == id)
            {
                mascotas.Remove(m);
                return Ok("Mascota eliminada exitosamente");
            }
        }
        return NotFound("Mascota no encontrada");
    }
    
}