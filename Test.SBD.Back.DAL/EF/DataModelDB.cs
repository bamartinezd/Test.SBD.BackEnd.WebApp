namespace Test.SBD.Back.DAL.EF
{
    using System.Data.Entity;

    public partial class DataModelDB : DbContext
    {
        public DataModelDB()
            : base("name=DataModelDB")
        {
        }

        public virtual DbSet<Cliente> Clientes { get; set; }
        public virtual DbSet<Factura> Facturas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Cliente>()
                .Property(e => e.Direccion)
                .IsUnicode(false);

            modelBuilder.Entity<Factura>()
                .Property(e => e.ValorTotal)
                .HasPrecision(19, 4);
        }
    }
}