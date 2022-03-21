public class PatientDensityRepository : IPatientDensityRepository
{
    private readonly HayatEveSigarContext _hayatEveSigarContext;
    public PatientDensityRepository(HayatEveSigarContext hayatEveSigarContext)
    {
        _hayatEveSigarContext = hayatEveSigarContext;
    }

    public Color CreateDensity(CreateUpdatePatientDensityDTO createPatientDensityDTO)
    {
        Neigborhood neigborhood = _hayatEveSigarContext.Neigborhoods.FirstOrDefault(x=>x.Id == createPatientDensityDTO.NeighborhoodID);
        if(neigborhood == null ) return Color.NoColor;
        int numberOfRisky = 0, numberOfRiskless = 0;

         foreach (User user in _hayatEveSigarContext.Users.ToList())
         {
             if(user.HealthStatus == HealthStatus.Risky)
             {
                 numberOfRisky += 1;
             }
             else
             {
                 numberOfRiskless +=1;
             }
         }
         double density = (double)numberOfRisky / (double)neigborhood.Population;
         PatientDensity PatientDensity = new PatientDensity(createPatientDensityDTO, density);
         _hayatEveSigarContext.Densities.Add(PatientDensity);
         _hayatEveSigarContext.SaveChanges();
         return PatientDensity.Color;

    }
    public Color GetDensityByNeighborhoodId(int NeighborhoodId)
    {
        PatientDensity patientDensity = _hayatEveSigarContext.Densities.FirstOrDefault(x => x.NeighborhoodID == NeighborhoodId);
        return patientDensity.Color;
    }
    public IEnumerable<PatientDensity> GetAll()
    {
        return _hayatEveSigarContext.Densities.ToList();
    }
    public Color UpdateDensity(CreateUpdatePatientDensityDTO createUpdatePatientDensityDTO)
    {
        PatientDensity patientDensity =  _hayatEveSigarContext.Densities.FirstOrDefault(x=>x.NeighborhoodID == createUpdatePatientDensityDTO.NeighborhoodID);
        if(patientDensity == null ) return Color.NoColor;
        
        int numberOfRisky = 0, numberOfRiskless = 0;

         foreach (User user in _hayatEveSigarContext.Users.ToList())
         {
             if(user.HealthStatus == HealthStatus.Risky)
             {
                 numberOfRisky += 1;
             }
             else
             {
                 numberOfRiskless +=1;
             }
        }
        double density = (double)numberOfRisky / (double)patientDensity.Neigborhood.Population;
        patientDensity.Density = density;
        if (density < 0.3) patientDensity.Color = Color.Green;
        if (density < 0.6) patientDensity.Color = Color.Orange;
        else patientDensity.Color = Color.Red;
        _hayatEveSigarContext.SaveChanges();
         return patientDensity.Color;
    }
    public void DeleteDensity(int NeighborhoodId)
    {
        PatientDensity patientDensity = _hayatEveSigarContext.Densities.FirstOrDefault(x => x.NeighborhoodID == NeighborhoodId);
        if(patientDensity != null)
        {
            _hayatEveSigarContext.Densities.Remove(patientDensity);
            _hayatEveSigarContext.SaveChanges();
        }
    }
}