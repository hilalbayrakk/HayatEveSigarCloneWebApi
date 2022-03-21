public interface IAccountService
{
    public Task<ActionResult<AccountDTO>> GetAccountById(int ID);
    public Task<ActionResult<AccountDTO>> GetAccountByHesCodeId(int HesCodeId);
    public Task<ActionResult<AccountDTO>> GetAccountByPasswordAndPhoneNumber(LoginDTO loginDTO);
    public Task<ActionResult<AccountDTO>> UpdateAccount(int Id, UpdateAccountDTO updateAccountDTO);
    public Task<ActionResult<AccountDTO>> CreateAccount(CreateAccountDTO accountDTO);
    public Task<ActionResult<IEnumerable<AccountDTO>>> GetAllAccounts();
}