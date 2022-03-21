public interface IRiskSurveyRepository
{
    public RiskSurvey CreateRiskSurvey(CreateUpdateRiskSurveyDTO createUpdateRiskSurveyDTO);
    public RiskSurvey UpdateRiskSurvey(CreateUpdateRiskSurveyDTO createUpdateRiskSurveyDTO, int Id);
    public RiskSurvey GetRiskSurveyByUserId(int userId);
    public IEnumerable<RiskSurvey> GetRiskSurveyByResult(int result);
}
