public static class AccountDatabaseBuilder
{

    static void SetDataToDB(ModelBuilder modelBuilder)
    {
  
    }

    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        
        modelBuilder.Entity<Account>(entity =>
        {
            entity.HasKey(e => e.Id);
            entity.Property(e => e.PhoneNumber);
            entity.Property(e => e.TCKN);
            entity.Property(e => e.Password);
            entity.Property(e => e.IsAdmin);
            entity.Property(e => e.Visibility);
        });
 

        SetDataToDB(modelBuilder);
    }
}