public interface IPatientDensityService
{
    public Task<ActionResult<Color>> CreateDensity(CreateUpdatePatientDensityDTO createPatientDensityDTO);
    public Task<ActionResult<Color>> GetDensityByNeighborhoodId(int NeighborhoodId);
    public Task<IEnumerable<PatientDensity>> GetAll();
    public Task<ActionResult<Color>> UpdateDensity(CreateUpdatePatientDensityDTO createUpdatePatientDensityDTO);
    public Task DeleteDensity(int NeighborhoodId);
}