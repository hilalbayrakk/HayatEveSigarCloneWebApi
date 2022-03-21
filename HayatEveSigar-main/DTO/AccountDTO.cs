public class AccountDTO
{

    public string PhoneNumber { get; set; }
    public bool Visibility {get;set;}
    public bool IsAdmin { get; set; }
    public AccountDTO()
    {

    }
    public AccountDTO(Account account)
    {
        PhoneNumber = account.PhoneNumber;
        Visibility = account.Visibility;
        IsAdmin = account.IsAdmin;
    }
}
