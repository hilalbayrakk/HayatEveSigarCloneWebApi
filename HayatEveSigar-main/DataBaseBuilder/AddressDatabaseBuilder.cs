
    public class AddressDatabaseBuilder
    {

        static void SetDataToDB(ModelBuilder modelBuilder)
        {
            
        }
        public static void TableBuilder(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
              {
                  entity.HasKey(e => e.Id);
                  entity.Property(e => e.OpenAddress).IsRequired();
                  entity.Property(e => e.CityId).IsRequired();
                  entity.Property(e => e.DistrictId).IsRequired();
                  
              });
        }
    }
