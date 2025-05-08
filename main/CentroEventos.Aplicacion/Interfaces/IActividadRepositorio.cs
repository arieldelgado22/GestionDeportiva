
using CentroEventos.Aplicacion.Entidades;
using System.Collections.Generic;

public interface IActividadRepositorio
{
    void Agregar(ActividadDeportiva actividad);
    void Actualizar(ActividadDeportiva actividad);
    ActividadDeportiva? ObtenerPorId(int id);
    List<ActividadDeportiva> Listar();
}
