using System.ComponentModel.DataAnnotations;

namespace bapptres.Data
{
    public class Producto
    {
        [Required(ErrorMessage = "El número de inventario es requerido.")]
        [Range(1, int.MaxValue, ErrorMessage = "El número de inventario debe ser un número entero positivo.")]
        public int NumeroInventario { get; set; }

        [Required(ErrorMessage = "El nombre es requerido.")]
        [MaxLength(200, ErrorMessage = "El nombre no puede tener más de 200 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El departamento es requerido.")]
        public string Departamento { get; set; }
    }
}
