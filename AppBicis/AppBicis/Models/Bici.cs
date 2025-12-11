using System.ComponentModel.DataAnnotations;

namespace AppBicis.Models
{
    public class Bici
    {
        [Key]
        public string CodBarra { get; set; }

        public string Modelo { get; set; }

        public int Annio { get; set; }
        public decimal PrecioVenta { get; set; }

        public string Proveedor { get; set; }   

        public DateTime FechaRegistro { get; set; }

        public char Estado { get; set; }


    }//cierre class
}//cierre namespace
