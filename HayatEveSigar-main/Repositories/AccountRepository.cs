
public class AccountRepository : IAccountRepository
{
    HayatEveSigarContext _hayatEveSigarContext;
    public AccountRepository(HayatEveSigarContext hayatEveSigarContext)
    {
        this._hayatEveSigarContext = hayatEveSigarContext;
    }

    public Account GetAccountById(int ID)
    {
        Account account = (from x in _hayatEveSigarContext.Accounts where x.Id == ID select x).FirstOrDefault();
        return account;
    }
    public Account GetAccountByHesCodeId(int HesCodeId)
    {
        int accountId = (from x in _hayatEveSigarContext.HesCodes where x.Id == HesCodeId select x.AccountId).FirstOrDefault();
        Account account = GetAccountById(accountId);
        return account;
    }
    public Account GetAccountByPasswordAndPhoneNumber(LoginDTO loginDTO)
    { 
        Account account = (from x in _hayatEveSigarContext.Accounts where x.Password == loginDTO.Password
                           && x.PhoneNumber == loginDTO.PhoneNumber select x).FirstOrDefault();
        return account;
    }
    public Account UpdateAccount(int Id, UpdateAccountDTO updateAccountDTO)
    {
        Account account = (from x in _hayatEveSigarContext.Accounts where x.Id == Id select x).FirstOrDefault();
        if(account == null) return null;
        account.PhoneNumber = updateAccountDTO.PhoneNumber;
        account.Visibility = updateAccountDTO.Visibility;
        account.TCKN = updateAccountDTO.TCKN;
        account.IsAdmin = updateAccountDTO.IsAdmin;
        _hayatEveSigarContext.SaveChanges();
        return account;
    }
    public Account CreateAccount(CreateAccountDTO accountDTO)
    {
        Account account = new Account(accountDTO);
        _hayatEveSigarContext.Accounts.Add(account);
        _hayatEveSigarContext.SaveChanges();
        return account;  
    }
    public IEnumerable<Account> GetAllAccounts()
    {
        return _hayatEveSigarContext.Accounts.ToList();
    }
}