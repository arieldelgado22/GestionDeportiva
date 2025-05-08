
public class ActividadDeportiva
{
    public int Id { get; set; }
    public string Nombre { get; set; } = "";
    public List<string> DiasDisponibles { get; set; } = new();
    public int CupoMaximo { get; set; }
    public int CupoActual { get; set; }
    public override string ToString() => $"\"{Nombre}\" con {CupoActual}/{CupoMaximo} inscriptos";
}
