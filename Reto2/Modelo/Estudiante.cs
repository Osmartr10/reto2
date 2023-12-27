namespace Reto2.Modelo
{
    public class Estudiante
    {
        public int Id { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public int CursoId { get; set; }
        public Curso Curso { get; set; }
        public List<Enrolamiento> Enrolamientos { get; set; }
    }
}
