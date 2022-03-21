namespace HayatEveSigar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HesCodeController : ControllerBase
    {
        private readonly IHesCodeService _hesCodeService;
        public HesCodeController(IHesCodeService hesCodeService)
        {
            _hesCodeService = hesCodeService;
        }

        [HttpGet("{ID}")]
        public async Task<ActionResult<HesCodeDTO>> GetHesCodeById(int ID)
        {
            return await _hesCodeService.GetHesCodeById(ID);
        }

        [HttpGet("PhoneNumber")]
        public async Task<ActionResult<HesCodeDTO>> GetHesCodeByPhoneNumber(string PhoneNumber)
        {
            return await _hesCodeService.GetHesCodeByPhoneNumber(PhoneNumber);
        }

        [HttpPut("{AccountId}")]
        public async Task<ActionResult<HesCodeDTO>> UpdateHesCode(int AccountId)
        {
            return await _hesCodeService.UpdateHesCode(AccountId);
        }

        [HttpPost]
        public async Task<ActionResult<HesCodeDTO>> CreateHesCode(CreateHesCodeDTO createHesCodeDTO)
        {
            return await _hesCodeService.CreateHesCode(createHesCodeDTO);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<HesCodeDTO>>> GetAllHesCodes()
        {
            return await _hesCodeService.GetAllHesCodes();
        }
    }
}