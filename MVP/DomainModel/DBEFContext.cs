namespace MVP.DomainModel
{
    using System.Data.Entity;

    public class DBEFContext : DbContext
    {
        public DBEFContext()
            : base("name=DBEFContext") { }

        public DbSet<Website> Websites { get; set; }
    }
}
