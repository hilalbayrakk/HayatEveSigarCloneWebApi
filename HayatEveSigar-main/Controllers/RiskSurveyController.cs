namespace HayatEveSigar.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class RiskSurveyController : ControllerBase
    {
        private readonly IRiskSurveyService _riskSurveyService;
        public RiskSurveyController(IRiskSurveyService riskSurveyService)
        {
            _riskSurveyService = riskSurveyService;
        }

        [HttpPost]
        public async Task<ActionResult<RiskSurveyDTO>> CreateRiskSurvey(CreateUpdateRiskSurveyDTO createUpdateRiskSurveyDTO)
        {
            return await _riskSurveyService.CreateRiskSurvey(createUpdateRiskSurveyDTO);
        }

        [HttpPut]
        public async Task<ActionResult<RiskSurveyDTO>> UpdateRiskSurvey(CreateUpdateRiskSurveyDTO createUpdateRiskSurveyDTO, int Id)
        {
            return await _riskSurveyService.UpdateRiskSurvey(createUpdateRiskSurveyDTO, Id);
        }

        [HttpGet("{userId}")]
        public async Task<ActionResult<RiskSurveyDTO>> GetRiskSurveyByUserId(int userId)
        {
            return await _riskSurveyService.GetRiskSurveyByUserId(userId);
        }

        [HttpGet("result")]
        public async Task<ActionResult<IEnumerable<RiskSurveyDTO>>> GetRiskSurveyByResult(int result)
        {
            return await _riskSurveyService.GetRiskSurveyByResult(result);
        }
    }
}