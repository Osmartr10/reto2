namespace Reto2.Modelo
{
    public class Materia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Estado { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
    }
}
