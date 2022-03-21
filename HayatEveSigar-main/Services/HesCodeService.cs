public class HesCodeService : ControllerBase, IHesCodeService
{
    private readonly IHesCodeRepository _hesCodeRepository;
    public HesCodeService(IHesCodeRepository hesCodeRepository)
    {
        _hesCodeRepository = hesCodeRepository;
    }
    public async Task<ActionResult<HesCodeDTO>> GetHesCodeById(int ID)
    {
        var hescode = _hesCodeRepository.GetHesCodeById(ID);
        if(hescode == null)  return BadRequest("Bulunamadı.");
        return new HesCodeDTO(hescode);
    }
    public async Task<ActionResult<HesCodeDTO>> GetHesCodeByPhoneNumber(string PhoneNumber)
    {
        var hescode = _hesCodeRepository.GetHesCodeByPhoneNumber(PhoneNumber);
        if(hescode == null)  return BadRequest("Bulunamadı.");
        return new HesCodeDTO(hescode);
    }
    public async Task<ActionResult<HesCodeDTO>> UpdateHesCode(int AccountId)
    {
        var hescode = _hesCodeRepository.UpdateHesCode(AccountId);
        if (hescode == null) return BadRequest("Girilen Account Id ile Account Bulunamadı.");
        return new HesCodeDTO(hescode);
    }
    public async Task<ActionResult<HesCodeDTO>> CreateHesCode(CreateHesCodeDTO createHesCodeDTO)
    {
        var hescode = _hesCodeRepository.CreateHesCode(createHesCodeDTO);
        if (hescode == null) return BadRequest("Girilen Account Id ile Account Bulunamadı.");
        return new HesCodeDTO(hescode);
    }
    public async Task<ActionResult<IEnumerable<HesCodeDTO>>> GetAllHesCodes()
    {
        List<HesCodeDTO> DTOs = new List<HesCodeDTO>();
        foreach (HesCode hesCode in _hesCodeRepository.GetAllHesCodes())
        {
            DTOs.Add(new HesCodeDTO(hesCode));
        }
        return DTOs;
    }
}