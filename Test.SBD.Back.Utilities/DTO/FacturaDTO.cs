namespace Test.SBD.Back.Utilities.DTO
{
    using System;

    public partial class FacturaDTO
    {
        public int Id { get; set; }

        public long? ClienteId { get; set; }

        public DateTime? FechaVenta { get; set; }

        public decimal? ValorTotal { get; set; }

        public bool? Estado { get; set; }
    }
}