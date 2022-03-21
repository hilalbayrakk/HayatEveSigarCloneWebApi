public class PatientDensityService : ControllerBase, IPatientDensityService
{
    private readonly IPatientDensityRepository _patientDensityRepository;
    public PatientDensityService(IPatientDensityRepository patientDensityRepository)
    {
        _patientDensityRepository = patientDensityRepository;
    }
    public async Task<ActionResult<Color>> CreateDensity(CreateUpdatePatientDensityDTO createPatientDensityDTO)
    {
        Color Color = _patientDensityRepository.CreateDensity(createPatientDensityDTO);
        if(Color == Color.NoColor) return BadRequest("Girilen neigborhood Id mevcut değildir.");
        return Color;
    }
    public async Task<ActionResult<Color>> GetDensityByNeighborhoodId(int NeighborhoodId)
    {
        Color Color = _patientDensityRepository.GetDensityByNeighborhoodId(NeighborhoodId);
        if (Color == Color.NoColor) return BadRequest("Girilen neigborhood Id mevcut değildir.");
        return Color;
    }
    public async Task<IEnumerable<PatientDensity>> GetAll()
    {
        return _patientDensityRepository.GetAll();
    }
    public async Task<ActionResult<Color>> UpdateDensity(CreateUpdatePatientDensityDTO createUpdatePatientDensityDTO)
    {
        Color Color = _patientDensityRepository.UpdateDensity(createUpdatePatientDensityDTO);
        if (Color == Color.NoColor) return BadRequest("Girilen neigborhood Id mevcut değildir.");
        return Color;
    }
    public async Task DeleteDensity(int NeighborhoodId)
    {
        _patientDensityRepository.DeleteDensity(NeighborhoodId);
    }
}