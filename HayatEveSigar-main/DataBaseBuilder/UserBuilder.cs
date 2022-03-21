public static class UserBuilder
{

    static void SetDataToDB(ModelBuilder modelBuilder)
    {       
      
    }

    public static void TableBuilder(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<User>(entity=>{
            entity.HasKey(e=>e.Id);
            entity.Property(e=>e.Name).IsRequired();
            entity.Property(e=>e.Surname).IsRequired();
            entity.Property(e=>e.Email).IsRequired();
            entity.Property(e=>e.Birthday).IsRequired();
            entity.Property(e=>e.Gender).IsRequired();
            entity.Property(e=>e.HealthStatus);
            entity.HasOne(e=>e.Address).WithMany(r=>r.Users).HasForeignKey(k=>k.AddressId);
            entity.HasOne(e=>e.Account).WithOne().HasForeignKey("User","AccountId");
        });
        
        SetDataToDB(modelBuilder);
    }
}