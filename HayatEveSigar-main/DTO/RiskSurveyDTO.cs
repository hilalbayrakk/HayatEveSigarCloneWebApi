public class RiskSurveyDTO
{

    public int Id { get; set; }
    public int Result { get; set; }
    public double BodyTemperature { get; set; }
    public bool ShortnessOfBreath { get; set; }
    public bool RunnyNose { get; set; }
    public bool BodyPain { get; set; }
    public bool Weakness { get; set; }
    public bool Cough { get; set; }
    public bool ChronicIllness { get; set; }
    public bool SmellAndTaste { get; set; }


    public RiskSurveyDTO()
    {

    }

    public RiskSurveyDTO(RiskSurvey riskSurvey)
    {
        Id = riskSurvey.Id;
        BodyTemperature = riskSurvey.BodyTemperature;
        ShortnessOfBreath = riskSurvey.ShortnessOfBreath;
        RunnyNose = riskSurvey.RunnyNose;
        BodyPain = riskSurvey.BodyPain;
        Weakness = riskSurvey.Weakness;
        Cough = riskSurvey.Cough;
        ChronicIllness = riskSurvey.ChronicIllness;
        SmellAndTaste = riskSurvey.SmellAndTaste;
        Result = riskSurvey.Result;

    }
}
