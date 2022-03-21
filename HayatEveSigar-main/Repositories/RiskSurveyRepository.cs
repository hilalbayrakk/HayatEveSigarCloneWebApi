public class RiskSurveyRepository : IRiskSurveyRepository
{
    private readonly HayatEveSigarContext _context;

    public RiskSurveyRepository(HayatEveSigarContext context)
    {
        _context = context;
    }
    public RiskSurvey CreateRiskSurvey(CreateUpdateRiskSurveyDTO createUpdateRiskSurveyDTO)
    {
        var user = _context.Users.FirstOrDefault(x => x.Id == createUpdateRiskSurveyDTO.UserId);
        if (user == null)
        {
            return null;
        }
        int result = 0;
        if (createUpdateRiskSurveyDTO.BodyTemperature >= 40)
        {
            result = 3;
        }
        else if (createUpdateRiskSurveyDTO.BodyTemperature >= 38)
        {
            result = 2;
        }
        else
            result = 0;

        List<bool> RiskSurveyList = new List<bool>() { createUpdateRiskSurveyDTO.BodyPain, createUpdateRiskSurveyDTO.ChronicIllness, createUpdateRiskSurveyDTO.Cough, createUpdateRiskSurveyDTO.RunnyNose, createUpdateRiskSurveyDTO.ShortnessOfBreath, createUpdateRiskSurveyDTO.SmellAndTaste, createUpdateRiskSurveyDTO.Weakness };
        foreach (bool item in RiskSurveyList)
        {
            if (item == true)
                result += 1;
        }
        RiskSurvey riskSurvey = new RiskSurvey(createUpdateRiskSurveyDTO, result);
        _context.RiskSurveys.Add(riskSurvey);
        _context.SaveChanges();
        return riskSurvey;
    }

    public IEnumerable<RiskSurvey> GetRiskSurveyByResult(int result)
    {
        return _context.RiskSurveys.Where(x => x.Result > result).ToList();
    }

    public RiskSurvey GetRiskSurveyByUserId(int userId)
    {
         return _context.RiskSurveys.FirstOrDefault(x => x.UserId == userId);
    }

    public RiskSurvey UpdateRiskSurvey(CreateUpdateRiskSurveyDTO createUpdateRiskSurveyDTO, int Id)
    {
        var RiskSurvey = _context.RiskSurveys.FirstOrDefault(x => x.Id == Id);
        if (RiskSurvey == null)
            return null;

        var user = _context.Users.FirstOrDefault(x => x.Id == createUpdateRiskSurveyDTO.UserId);
        if (user == null)
        {
            return null;
        }
        int result = 0;
        if (createUpdateRiskSurveyDTO.BodyTemperature >= 40)
        {
            result = 3;
        }
        else if (createUpdateRiskSurveyDTO.BodyTemperature >= 38)
        {
            result = 2;
        }
        else
            result = 0;

        List<bool> RiskSurveyList = new List<bool>() { createUpdateRiskSurveyDTO.BodyPain, createUpdateRiskSurveyDTO.ChronicIllness, createUpdateRiskSurveyDTO.Cough, createUpdateRiskSurveyDTO.RunnyNose, createUpdateRiskSurveyDTO.ShortnessOfBreath, createUpdateRiskSurveyDTO.SmellAndTaste, createUpdateRiskSurveyDTO.Weakness };
        foreach (bool item in RiskSurveyList)
        {
            if (item == true)
                result += 1;
        }
        RiskSurvey.Result = result;
        RiskSurvey.BodyTemperature = createUpdateRiskSurveyDTO.BodyTemperature;
        RiskSurvey.ShortnessOfBreath = createUpdateRiskSurveyDTO.ShortnessOfBreath;
        RiskSurvey.RunnyNose = createUpdateRiskSurveyDTO.RunnyNose;
        RiskSurvey.BodyPain = createUpdateRiskSurveyDTO.BodyPain;
        RiskSurvey.Weakness = createUpdateRiskSurveyDTO.Weakness;
        RiskSurvey.Cough = createUpdateRiskSurveyDTO.Cough;
        RiskSurvey.ChronicIllness = createUpdateRiskSurveyDTO.ChronicIllness;
        RiskSurvey.SmellAndTaste = createUpdateRiskSurveyDTO.SmellAndTaste;
        _context.SaveChanges();
        return RiskSurvey;
    }
}
