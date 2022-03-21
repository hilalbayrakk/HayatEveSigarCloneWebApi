public interface IRiskSurveyService
{
    public Task<ActionResult<RiskSurveyDTO>> CreateRiskSurvey(CreateUpdateRiskSurveyDTO createUpdateRiskSurveyDTO);
    public Task<ActionResult<RiskSurveyDTO>> UpdateRiskSurvey(CreateUpdateRiskSurveyDTO createUpdateRiskSurveyDTO, int Id);
    public Task<ActionResult<RiskSurveyDTO>> GetRiskSurveyByUserId(int userId);
    public Task<ActionResult<IEnumerable<RiskSurveyDTO>>> GetRiskSurveyByResult(int result);

}
