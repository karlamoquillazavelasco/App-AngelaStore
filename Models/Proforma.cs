using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace App_AngelaStore.Models
{
    //CARRITO
    [Table("t_proforma")]
    public class Proforma
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        public String UserID {get; set;}
        public Producto Producto {get; set;}
        public int Stock{get; set;}
        public Decimal Precio { get; set; }
    }
}