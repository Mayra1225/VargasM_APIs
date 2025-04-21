using VargasM_APIs.Interfaces;
using VargasM_APIs.Models;

namespace VargasM_APIs.Repositories
{
    public class EstudianteRepository : IEstudianteRepository
    {
        public Estudiante DevuelveInformacionEstudiante(string BannerId)
        {
            var estudiantes = DevuelveListadoEstudiantes();
            return estudiantes.First(item => item.BannerId == BannerId);
        }

        public IEnumerable<Estudiante> DevuelveListadoEstudiantes()
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            Estudiante estudiante1 = new Estudiante
            {
                BannerId = "12345",
                Nombre = "Santiago",
                Edad = 30,
                TieneBeca = false
            };

            estudiantes.Add(estudiante1);

            Estudiante estudiante2 = new Estudiante
            {
                BannerId = "98765",
                Nombre = "Diana",
                Edad = 18,
                TieneBeca = true
            };

            estudiantes.Add(estudiante2);

            return estudiantes;
        }
    }
}
