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

    
    
    
}