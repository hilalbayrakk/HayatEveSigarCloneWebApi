
    public class CityDatabaseBuilder
    {

        static void SetDataToDB(ModelBuilder modelBuilder)
        {

        }

        public static void TableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<City>(entity =>
           {
               entity.HasKey(e => e.Id);
               entity.Property(e => e.Name);
           });
        }
    }

