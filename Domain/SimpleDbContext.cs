using System.Data.Entity;

namespace Domain
{
    public class SimpleDbContext : DbContext
    {
        public SimpleDbContext(string name) : base(name) { }
        public SimpleDbContext() { }

        //Add DbSet properties for root objects, thus:
        public DbSet<SimpleObject> SimpleObjects{ get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Initialisation
            //Use the Naked Objects > DbInitialiser template to add an initialiser, then reference thus:
            Database.SetInitializer(new SimpleDbInitialiser()); 

            //Mappings
            //Use the Naked Objects > DbMapping template to create mapping classes & reference them thus:
            modelBuilder.Configurations.Add(new SimpleObjectMapping());
        }
    }
}