
namespace HayatEveSigar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;
        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet("{ID}")]
        public async Task<ActionResult<AccountDTO>> GetAccountById(int ID)
        {
            return await _accountService.GetAccountById(ID);
        }

        [HttpGet("HesCodeId")]
        public async Task<ActionResult<AccountDTO>> GetAccountByHesCodeId(int HesCodeId)
        {
            return await _accountService.GetAccountByHesCodeId(HesCodeId);
        }

        [HttpGet("Account")]
        public async Task<ActionResult<AccountDTO>> GetAccountByPasswordAndPhoneNumber(LoginDTO loginDTO)
        {
            return await _accountService.GetAccountByPasswordAndPhoneNumber(loginDTO);
        }

        [HttpPut("{Id}")]
        public async Task<ActionResult<AccountDTO>> UpdateAccount(int Id, UpdateAccountDTO updateAccountDTO)
        {
            return await _accountService.UpdateAccount(Id, updateAccountDTO);
        }

        [HttpPost]
        public async Task<ActionResult<AccountDTO>> CreateAccount(CreateAccountDTO accountDTO)
        {
            return await _accountService.CreateAccount(accountDTO);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccountDTO>>> GetAllAccounts()
        {
            return await _accountService.GetAllAccounts();
        }

    }
}