
using CentroEventos.Aplicacion.Entidades;
using System.Collections.Generic;

public interface IReservaRepositorio
{
    void Agregar(Reserva reserva);
    void Actualizar(Reserva reserva);
    Reserva? ObtenerPorId(int id);
    List<Reserva> Listar();
}
