using VargasM_APIs.Models;

namespace VargasM_APIs.Interfaces
{
    public interface IEstudianteRepository
    {
        IEnumerable<Estudiante> DevuelveListadoEstudiantes();
        Estudiante DevuelveInformacionEstudiante(string BannerId);
    }
}
