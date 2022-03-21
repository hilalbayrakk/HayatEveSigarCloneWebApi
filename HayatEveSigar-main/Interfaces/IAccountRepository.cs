public interface IAccountRepository
{
    public Account GetAccountById(int ID);
    public Account GetAccountByHesCodeId(int HesCodeId);
    public Account GetAccountByPasswordAndPhoneNumber(LoginDTO loginDTO);
    public Account UpdateAccount(int Id, UpdateAccountDTO updateAccountDTO);
    public Account CreateAccount(CreateAccountDTO accountDTO);
    public IEnumerable<Account> GetAllAccounts();

}