namespace HayatEveSigar.Models
{
    public class RiskSurvey
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int Result { get; set; }
        public double BodyTemperature { get; set; }
        public bool ShortnessOfBreath { get; set; }
        public bool RunnyNose { get; set; }
        public bool BodyPain { get; set; }
        public bool Weakness { get; set; }
        public bool Cough { get; set; }
        public bool ChronicIllness { get; set; }
        public bool SmellAndTaste { get; set; }
        public virtual User? User { get; set; }

        public RiskSurvey()
        {

        }

        public RiskSurvey(CreateUpdateRiskSurveyDTO createupdateRiskSurveyDTO, int result)
        {
            UserId = createupdateRiskSurveyDTO.UserId;
            BodyTemperature = createupdateRiskSurveyDTO.BodyTemperature;
            ShortnessOfBreath = createupdateRiskSurveyDTO.ShortnessOfBreath;
            RunnyNose = createupdateRiskSurveyDTO.RunnyNose;
            BodyPain = createupdateRiskSurveyDTO.BodyPain;
            Weakness = createupdateRiskSurveyDTO.Weakness;
            Cough = createupdateRiskSurveyDTO.Cough;
            ChronicIllness = createupdateRiskSurveyDTO.ChronicIllness;
            SmellAndTaste = createupdateRiskSurveyDTO.SmellAndTaste;

            Result = result;
        }

    }
}
