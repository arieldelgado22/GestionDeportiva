
using CentroEventos.Aplicacion.Entidades;
using CentroEventos.Aplicacion.CasosDeUso;
using CentroEventos.Aplicacion.Excepciones;
using CentroEventos.Repositorios;
using System;

class Program
{
    static void Main()
    {
        var actividadRepo = new ActividadRepositorioMemoria();
        var reservaRepo = new ReservaRepositorioMemoria();

        var actividad = new ActividadDeportiva
        {
            Id = 1,
            Nombre = "Fútbol",
            CupoMaximo = 10,
            CupoActual = 0
        };
        actividadRepo.Agregar(actividad);

        var reserva = new Reserva
        {
            Id = 1,
            ActividadId = 1,
            PersonaId = 123,
            FechaReserva = DateTime.Today
        };

        var reservarUseCase = new ReservarActividadUseCase(reservaRepo, actividadRepo);
        try
        {
            reservarUseCase.Ejecutar(reserva);
            Console.WriteLine("Reserva realizada con éxito.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        var listar = new ListarReservasActivasUseCase(reservaRepo);
        foreach (var r in listar.Ejecutar())
        {
            Console.WriteLine($"Reserva ID: {r.Id}, Actividad: {r.ActividadId}, Estado: {r.Estado}");
        }
    }
}
