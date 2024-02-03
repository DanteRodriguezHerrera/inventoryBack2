using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InventoryBack.Models
{
    public class Inventory
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Pertenece { get; set; } = "";
        [Column(TypeName = "nvarchar(10)")]
        public string Fondo { get; set; } = "";
        [Column(TypeName = "nvarchar(10)")]
        public string Unidad_Presupuestal { get; set; } = "";
        [Column(TypeName = "nvarchar(10)")]
        public string Cuenta { get; set; } = "";
        [Column(TypeName = "nvarchar(10)")]
        public string Subcuenta { get; set; } = "";
        [Column(TypeName = "nvarchar(10)")]
        public string Folio { get; set; } = "";
        [Column(TypeName = "nvarchar(30)")]
        public string Codigo { get; set; } = "";
        [Column(TypeName = "tinyint")]
        public int Cantidad { get; set; } = 0;
        [Column(TypeName = "nvarchar(100)")]
        public string Descripcion { get; set; } = "";
        [Column(TypeName = "nvarchar(100)")]
        public string Modelo { get; set; } = "";
        [Column(TypeName = "nvarchar(100)")]
        public string Serie_De_Fabrica { get; set; } = "";
        [Column(TypeName = "nvarchar(50)")]
        public string Ubicacion { get; set; } = "";
        [Column(TypeName = "nvarchar(100)")]
        public string Responsable { get; set; } = "";
        [Column(TypeName = "nvarchar(20)")]
        public string Num_Empleado { get; set; } = "";
        [Column(TypeName = "nvarchar(100)")]
        public string Observaciones { get; set; } = "";
    }
}
