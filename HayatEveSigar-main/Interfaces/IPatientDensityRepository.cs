public interface IPatientDensityRepository
{
    public Color CreateDensity(CreateUpdatePatientDensityDTO createPatientDensityDTO);
    public Color GetDensityByNeighborhoodId(int NeighborhoodId);
    public IEnumerable<PatientDensity> GetAll();
    public Color UpdateDensity(CreateUpdatePatientDensityDTO createUpdatePatientDensityDTO);
    public void DeleteDensity(int NeighborhoodId);
}