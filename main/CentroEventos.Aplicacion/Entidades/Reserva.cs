
public enum EstadoAsistencia
{
    Pendiente,
    Asistio,
    Ausente,
    Cancelada
}

public class Reserva
{
    public int Id { get; set; }
    public int PersonaId { get; set; }
    public int ActividadId { get; set; }
    public DateTime FechaReserva { get; set; }
    public EstadoAsistencia Estado { get; set; } = EstadoAsistencia.Pendiente;
}
