namespace Test.SBD.Back.DAL.EF
{
    using System;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Factura
    {
        public int Id { get; set; }

        public long? ClienteId { get; set; }

        public DateTime? FechaVenta { get; set; }

        [Column(TypeName = "money")]
        public decimal? ValorTotal { get; set; }

        public bool? Estado { get; set; }

        public virtual Cliente Cliente { get; set; }
    }
}