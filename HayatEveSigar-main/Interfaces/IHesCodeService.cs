public interface IHesCodeService
{
    public Task<ActionResult<HesCodeDTO>> GetHesCodeById(int ID);
    public Task<ActionResult<HesCodeDTO>> GetHesCodeByPhoneNumber(string PhoneNumber);
    public Task<ActionResult<HesCodeDTO>> UpdateHesCode(int AccountId);
    public Task<ActionResult<HesCodeDTO>> CreateHesCode(CreateHesCodeDTO createHesCodeDTO);
    public Task<ActionResult<IEnumerable<HesCodeDTO>>> GetAllHesCodes();
}