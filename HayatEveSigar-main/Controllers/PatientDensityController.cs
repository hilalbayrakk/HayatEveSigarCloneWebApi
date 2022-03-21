namespace HayatEveSigar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PatientDensityController : ControllerBase
    {
        private readonly IPatientDensityService _PatientDensityService;
        public PatientDensityController(IPatientDensityService PatientDensityService)
        {
            _PatientDensityService = PatientDensityService;
        }

        [HttpPost]
        public async Task<ActionResult<Color>> CreateDensity(CreateUpdatePatientDensityDTO createPatientDensityDTO)
        {
            return await _PatientDensityService.CreateDensity(createPatientDensityDTO);
        }

        [HttpGet("NeighborhoodId")]
        public async Task<ActionResult<Color>> GetDensityByNeighborhoodId(int NeighborhoodId)
        {
            return await _PatientDensityService.GetDensityByNeighborhoodId(NeighborhoodId);
        }

        [HttpGet]
        public async Task<IEnumerable<PatientDensity>> GetAll()
        {
            return await _PatientDensityService.GetAll();
        }

        [HttpPut]
        public async Task<ActionResult<Color>> UpdateDensity(CreateUpdatePatientDensityDTO createUpdatePatientDensityDTO)
        {
            return await _PatientDensityService.UpdateDensity(createUpdatePatientDensityDTO);
        }

        [HttpDelete("{NeighborhoodId}")]
        public async Task DeleteDensity(int NeighborhoodId)
        {
            await _PatientDensityService.DeleteDensity(NeighborhoodId);
        }
    }
}