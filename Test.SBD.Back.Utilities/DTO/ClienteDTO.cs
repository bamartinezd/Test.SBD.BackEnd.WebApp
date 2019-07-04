namespace Test.SBD.Back.Utilities.DTO
{
    using System;

    public partial class ClienteDTO
    {
        public long Id { get; set; }

        public string Nombre { get; set; }

        public string Direccion { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public bool? Estado { get; set; }
    }
}