namespace SucursalesParcial.Models
{
    public class Sucursal
    {
        public int Id { get; set; } // Identificador único para la sucursal
        public string Nombre { get; set; } // Nombre de la sucursal
        public string Direccion { get; set; } // Dirección de la sucursal
        public string Ciudad { get; set; } // Ciudad donde se encuentra la sucursal
        public string Estado { get; set; } // Estado donde se encuentra la sucursal
        public string CodigoPostal { get; set; } // Código postal de la sucursal
        public string Telefono { get; set; } // Teléfono de contacto de la sucursal
        public string CorreoElectronico { get; set; } // Correo electrónico de la sucursal
    }
}
