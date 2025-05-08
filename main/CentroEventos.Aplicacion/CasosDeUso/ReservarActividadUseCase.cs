
public class ReservarActividadUseCase
{
    private readonly IReservaRepositorio _reservaRepo;
    private readonly IActividadRepositorio _actividadRepo;

    public ReservarActividadUseCase(IReservaRepositorio reservaRepo, IActividadRepositorio actividadRepo)
    {
        _reservaRepo = reservaRepo;
        _actividadRepo = actividadRepo;
    }

    public void Ejecutar(Reserva reserva)
    {
        var actividad = _actividadRepo.ObtenerPorId(reserva.ActividadId);
        if (actividad == null) throw new ValidacionException("Actividad no encontrada");
        if (actividad.CupoActual >= actividad.CupoMaximo) throw new CupoExcedidoException("Cupo lleno");

        actividad.CupoActual++;
        _actividadRepo.Actualizar(actividad);
        _reservaRepo.Agregar(reserva);
    }
}
