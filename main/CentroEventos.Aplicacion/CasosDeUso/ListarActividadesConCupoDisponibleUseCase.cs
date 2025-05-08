
public class ListarActividadesConCupoDisponibleUseCase
{
    private readonly IActividadRepositorio _actividadRepo;

    public ListarActividadesConCupoDisponibleUseCase(IActividadRepositorio actividadRepo)
    {
        _actividadRepo = actividadRepo;
    }

    public List<ActividadDeportiva> Ejecutar()
    {
        return _actividadRepo.Listar().Where(a => a.CupoActual < a.CupoMaximo).ToList();
    }
}
