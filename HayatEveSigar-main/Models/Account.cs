namespace HayatEveSigar.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string TCKN { get; set; }
        public string Password { get; set; }
        public bool Visibility { get; set; }
        public bool IsAdmin { get; set; }

        public Account()
        {

        }

        public Account(CreateAccountDTO createAccountDTO)
        {
            Visibility = true;
            PhoneNumber = createAccountDTO.PhoneNumber;
            TCKN = createAccountDTO.TCKN;
            Password = createAccountDTO.Password;
            IsAdmin = createAccountDTO.IsAdmin;
        }
    }
}