
public class ListarReservasActivasUseCase
{
    private readonly IReservaRepositorio _reservaRepo;

    public ListarReservasActivasUseCase(IReservaRepositorio reservaRepo)
    {
        _reservaRepo = reservaRepo;
    }

    public List<Reserva> Ejecutar()
    {
        return _reservaRepo.Listar()
            .Where(r => r.Estado == EstadoAsistencia.Pendiente || r.Estado == EstadoAsistencia.Asistio)
            .ToList();
    }
}
