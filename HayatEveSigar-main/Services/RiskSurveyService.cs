namespace HayatEveSigar.Services
{
    public class RiskSurveyService : ControllerBase, IRiskSurveyService
    {
        private readonly IRiskSurveyRepository _riskSurveyRepository;

        public RiskSurveyService(IRiskSurveyRepository riskSurveyRepository)
        {
            _riskSurveyRepository = riskSurveyRepository;
        }
        public async Task<ActionResult<RiskSurveyDTO>> CreateRiskSurvey(CreateUpdateRiskSurveyDTO createUpdateRiskSurveyDTO)
        {
            var RiskSurvey = _riskSurveyRepository.CreateRiskSurvey(createUpdateRiskSurveyDTO);
            if (RiskSurvey == null)
            {
                return BadRequest("Bu UserId mevcut değildir!");
            }
            return new RiskSurveyDTO(RiskSurvey);

        }

        public async Task<ActionResult<IEnumerable<RiskSurveyDTO>>> GetRiskSurveyByResult(int result)
        {
            List<RiskSurveyDTO> RiskServeyDTOs = new List<RiskSurveyDTO>();
            foreach (RiskSurvey riskSurvey in _riskSurveyRepository.GetRiskSurveyByResult(result))
            {
                RiskServeyDTOs.Add(new RiskSurveyDTO(riskSurvey));
            }
            return RiskServeyDTOs;
        }

        public async Task<ActionResult<RiskSurveyDTO>> GetRiskSurveyByUserId(int userId)
        {
            var RiskSurvey = _riskSurveyRepository.GetRiskSurveyByUserId(userId);
            if (RiskSurvey == null)
            {
                return BadRequest("Bu UserId mevcut değildir!");
            }
            return new RiskSurveyDTO(RiskSurvey);

        }

        public async Task<ActionResult<RiskSurveyDTO>> UpdateRiskSurvey(CreateUpdateRiskSurveyDTO createUpdateRiskSurveyDTO, int Id)
        {
            var RiskSurvey = _riskSurveyRepository.UpdateRiskSurvey(createUpdateRiskSurveyDTO, Id);
            if (RiskSurvey == null)
            {
                return BadRequest("Bu UserId mevcut değildir!");
            }
            return new RiskSurveyDTO(RiskSurvey);

        }
    }
}