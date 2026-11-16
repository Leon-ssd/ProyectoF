using System.ComponentModel.DataAnnotations;

public class Video
{
    [Key]
    public int IdVideo { get; set; }
    public string Titulo { get; set; }
    public string Descripcion { get; set; }
    public string RutaArchivo { get; set; }
    public int Duracion { get; set; }
}
