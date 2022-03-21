
namespace HayatEveSigar.DTO
{
    public class UserDTO
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Birthday { get; set; }
        public string Gender { get; set; }
        public string HealthStatus { get; set; }

        public AccountDTO? Account { get; set; }
        public Address? Address { get; set; }
    
        public UserDTO()
        {
            
        }

        public UserDTO(User user)
        {
            if(user != null)
            {
                this.Name = user.Name;
                this.Surname = user.Surname;
                this.Email = user.Email;
                this.Birthday = user.Birthday.ToString("g");
                
                if(user.Gender == global::Gender.Male) this.Gender = "Male";
                else if(user.Gender == global::Gender.Female) this.Gender = "Female";
                else this.Gender = "Others";

                this.HealthStatus = (user.HealthStatus == global::HealthStatus.Risky) ? "Riskli" : "Risksiz";
                if(user.Account != null){
                    this.Account.PhoneNumber = user.Account.PhoneNumber;
                    this.Account.Visibility = user.Account.Visibility;
                    this.Account.IsAdmin = user.Account.IsAdmin;
                }
                else this.Account = null;

                if(user.Address != null) this.Address = null;
                else this.Address = null;
            }
        }
    }


}