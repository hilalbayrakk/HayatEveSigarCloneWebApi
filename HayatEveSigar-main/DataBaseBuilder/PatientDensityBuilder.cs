public static class PatientDensityDatabaseBuilder
{

    static void SetDataToDB(ModelBuilder modelBuilder)
    {

    }

    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<PatientDensity>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.NeighborhoodID);
            entity.Property(e => e.Density);
            entity.Property(e => e.Color);
            entity.HasOne(e => e.Neigborhood).WithOne().HasForeignKey("Neigborhood","PatientDensityId");
            entity.HasMany(e => e.Users);
        });

        SetDataToDB(modelBuilder);
    }
}