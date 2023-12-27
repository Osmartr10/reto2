namespace Reto2.Modelo
{
    public class Asignatura
    {
        public int Id { get; set; }
        public int MateriaId { get; set; }
        public Materia Materia { get; set; }
        public int AulaId { get; set; }
        public Aula Aula { get; set; }
        public int HorarioId { get; set; }
        public Horario Horario { get; set; }
        public int DocenteId { get; set; }
        public Docente Docente { get; set; } = null;
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }
        public string Estado { get; set; }
        public List<Enrolamiento> Enrolamientos { get; set; }
    }
}
