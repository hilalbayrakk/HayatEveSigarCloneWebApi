public static class HesCodeDatabaseBuilder
{

    static void SetDataToDB(ModelBuilder modelBuilder)
    {

    }

    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<HesCode>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.Code);
            entity.HasOne(e=>e.Account).WithOne().HasForeignKey("HesCode","AccountId");
        });

        SetDataToDB(modelBuilder);
    }
}