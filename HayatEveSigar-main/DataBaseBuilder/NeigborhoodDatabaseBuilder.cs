
public class NeigborhoodDatabaseBuilder
{

    static void SetDataToDB(ModelBuilder modelBuilder)
    {

    }
    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Neigborhood>(entity =>
     {
         entity.HasKey(e => e.Id);
         entity.Property(e => e.Name);
         entity.Property(e => e.Population);
         entity.Property(e => e.DistrictId);
         entity.Property(e => e.PatientDensityId);
         entity.HasOne(e => e.District).WithMany(e => e.Neigborhood).HasForeignKey(e => e.DistrictId);
     });
    }
}
