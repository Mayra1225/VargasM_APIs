using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VargasM_APIs.Interfaces;
using VargasM_APIs.Repositories;

namespace VargasM_APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstudiantesController : ControllerBase
    {
        IEstudianteRepository _estudianteRepository;
        public EstudiantesController()
        {
            _estudianteRepository = new EstudianteRepository();
        }
        [HttpGet]
        public IActionResult DevuelveListadoEstudiantes()
        {
            var estudiantes = _estudianteRepository.DevuelveListadoEstudiantes();
            return Ok(estudiantes);
        }

        [Route("InfoEstudiante/{BannerId}")]
        [HttpGet]
        public IActionResult DevuelveInformacionEstudiante(String BannerId)
        {
            try
            {
                var infoEstudiante = _estudianteRepository.DevuelveInformacionEstudiante(BannerId);
                return Ok(infoEstudiante);
            }
            catch (Exception e)
            {
                return NotFound();
            }
        }
    }
}
