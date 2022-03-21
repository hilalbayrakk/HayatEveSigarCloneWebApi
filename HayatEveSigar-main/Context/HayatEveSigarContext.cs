
public class HayatEveSigarContext : DbContext
{
    public DbSet<Account>? Accounts { get; set; }
    public DbSet<PatientDensity>? Densities { get; set; }
    public DbSet<HesCode>? HesCodes { get; set; }
    public DbSet<Address>? Addresses { get; set; }
    public DbSet<City>? Cities { get; set; }
    public DbSet<District>? Districts { get; set; }
    public DbSet<Neigborhood>? Neigborhoods { get; set; }
    public DbSet<User>? Users { get; set; }
    public DbSet<RiskSurvey>? RiskSurveys { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var serverVersion = new MySqlServerVersion(new Version(8, 0, 28));
        optionsBuilder.UseMySql("server=localhost;database=hayatevesigar;user=root;port=3306;password=toortoor", serverVersion);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        UserBuilder.TableBuilder(modelBuilder);
        AccountDatabaseBuilder.TableBuilder(modelBuilder);
        HesCodeDatabaseBuilder.TableBuilder(modelBuilder);
        PatientDensityDatabaseBuilder.TableBuilder(modelBuilder);
        AddressDatabaseBuilder.TableBuilder(modelBuilder);
        CityDatabaseBuilder.TableBuilder(modelBuilder);
        DistrictDatabaseBuilder.TableBuilder(modelBuilder);
        NeigborhoodDatabaseBuilder.TableBuilder(modelBuilder);
        RiskSurveyBuilder.TableBuilder(modelBuilder);
        
    }
}