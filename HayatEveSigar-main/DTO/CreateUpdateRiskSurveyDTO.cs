namespace HayatEveSigar.DTO
{
    public class CreateUpdateRiskSurveyDTO
    {
        public int UserId { get; set; }
        public double BodyTemperature { get; set; }
        public bool ShortnessOfBreath { get; set; }
        public bool RunnyNose { get; set; }
        public bool BodyPain { get; set; }
        public bool Weakness { get; set; }
        public bool Cough { get; set; }
        public bool ChronicIllness { get; set; }
        public bool SmellAndTaste { get; set; }
        
    }
}