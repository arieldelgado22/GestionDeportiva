
using CentroEventos.Aplicacion.Entidades;
using CentroEventos.Aplicacion.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CentroEventos.Repositorios
{
    public class ActividadRepositorioMemoria : IActividadRepositorio
    {
        private readonly List<ActividadDeportiva> _actividades = new();
        public void Agregar(ActividadDeportiva actividad) => _actividades.Add(actividad);
        public void Actualizar(ActividadDeportiva actividad)
        {
            var index = _actividades.FindIndex(a => a.Id == actividad.Id);
            if (index >= 0) _actividades[index] = actividad;
        }
        public ActividadDeportiva? ObtenerPorId(int id) => _actividades.FirstOrDefault(a => a.Id == id);
        public List<ActividadDeportiva> Listar() => _actividades;
    }
}
