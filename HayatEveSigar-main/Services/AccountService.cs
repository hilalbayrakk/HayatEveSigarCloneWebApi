namespace HayatEveSigar.Services
{
    public class AccountService : ControllerBase,  IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public async Task<ActionResult<AccountDTO>> CreateAccount(CreateAccountDTO accountDTO)
        {
            var account = _accountRepository.CreateAccount(accountDTO);
            if (account != null)
            {
                return new AccountDTO(account);
            }
            return BadRequest("Bu HES koduna ait bir hesap bulunmaktadır!");
        }

        public async Task<ActionResult<AccountDTO>> GetAccountByHesCodeId(int HesCodeId)
        {
            Account account = _accountRepository.GetAccountByHesCodeId(HesCodeId);
            if (account != null)
            {
                return new AccountDTO(account);
            }
            return BadRequest("Bulunamadı!");


        }

        public async Task<ActionResult<AccountDTO>> GetAccountById(int ID)
        {
            Account account = _accountRepository.GetAccountById(ID);
            if (account != null)
            {
                return new AccountDTO(account);
            }
            return BadRequest("Bulunamadı!");

        }

        public async Task<ActionResult<AccountDTO>> GetAccountByPasswordAndPhoneNumber(LoginDTO loginDTO)
        {
            Account account = _accountRepository.GetAccountByPasswordAndPhoneNumber(loginDTO);
            if (account != null)
            {
                return new AccountDTO(account);
            }
            return BadRequest("Bulunamadı!");

        }


        public async Task<ActionResult<AccountDTO>> UpdateAccount(int Id, UpdateAccountDTO updateAccountDTO)
        {
            Account account = _accountRepository.UpdateAccount(Id, updateAccountDTO);
            if (account != null)
            {
                return new AccountDTO(account);
            }
            return BadRequest("Bulunamadı!");

        }

        public async Task<ActionResult<IEnumerable<AccountDTO>>> GetAllAccounts()
        {
            List<AccountDTO> accDTOs = new List<AccountDTO>();
            foreach (Account acc in _accountRepository.GetAllAccounts())
            {
                accDTOs.Add(new AccountDTO(acc));
            }
            return accDTOs;
        }
    }
}