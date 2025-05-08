
public class CancelarReservaUseCase
{
    private readonly IReservaRepositorio _reservaRepo;

    public CancelarReservaUseCase(IReservaRepositorio reservaRepo)
    {
        _reservaRepo = reservaRepo;
    }

    public void Ejecutar(int idReserva)
    {
        var reserva = _reservaRepo.ObtenerPorId(idReserva);
        if (reserva == null) throw new ValidacionException("Reserva no encontrada");
        reserva.Estado = EstadoAsistencia.Cancelada;
        _reservaRepo.Actualizar(reserva);
    }
}
