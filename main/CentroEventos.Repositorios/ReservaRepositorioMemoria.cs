
using CentroEventos.Aplicacion.Entidades;
using CentroEventos.Aplicacion.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace CentroEventos.Repositorios
{
    public class ReservaRepositorioMemoria : IReservaRepositorio
    {
        private readonly List<Reserva> _reservas = new();
        public void Agregar(Reserva reserva) => _reservas.Add(reserva);
        public void Actualizar(Reserva reserva)
        {
            var index = _reservas.FindIndex(r => r.Id == reserva.Id);
            if (index >= 0) _reservas[index] = reserva;
        }
        public Reserva? ObtenerPorId(int id) => _reservas.FirstOrDefault(r => r.Id == id);
        public List<Reserva> Listar() => _reservas;
    }
}
