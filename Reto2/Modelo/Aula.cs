namespace Reto2.Modelo
{
    public class Aula
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Bloque { get; set; }
        public string Piso { get; set; }
        public string Estado { get; set; }
        public List<Asignatura> Asignaturas { get; set; }
    }
}
