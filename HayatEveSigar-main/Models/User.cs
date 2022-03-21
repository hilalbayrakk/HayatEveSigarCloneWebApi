
namespace HayatEveSigar.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Tc { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public Gender Gender { get; set; }
        public HealthStatus HealthStatus { get; set; }

        public int AccountId { get; set; }
        public Account? Account { get; set; }
        public int AddressId { get; set; }
        public Address? Address { get; set; }
        public int RiskSurveyId { get; set; }
        public RiskSurvey RiskSurvey { get; set; }
        
    }
}