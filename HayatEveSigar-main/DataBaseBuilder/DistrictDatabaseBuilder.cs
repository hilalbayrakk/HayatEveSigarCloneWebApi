
    public class DistrictDatabaseBuilder
    {

        static void SetDataToDB(ModelBuilder modelBuilder)
        {

        }

        public static void TableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<District>(entity =>
           {
               entity.HasKey(e => e.Id);
               entity.Property(e => e.Name);
               entity.HasOne(c => c.City).WithMany(c => c.District).HasForeignKey(c => c.CityId);
           });
        }
    }

