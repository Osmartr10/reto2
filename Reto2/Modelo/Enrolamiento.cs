namespace Reto2.Modelo
{
    public class Enrolamiento
    {
        public int Id { get; set; }
        public int AsignaturaId { get; set; }
        public Asignatura Asignaturas { get; set; }
        public int EstudianteId { get; set; }
        public Estudiante Estudiante { get; set; }
        public DateTime FechaEnrolamiento { get; set; }
        public DateTime FechaBaja { get; set; }
        public string Estado { get; set; }
    }
}
