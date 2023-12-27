namespace Reto2.Modelo
{
    public class Horario
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fin { get; set; }
        public string Estado { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
    }
}
