public interface IHesCodeRepository
{
    public HesCode GetHesCodeById(int ID);
    public HesCode GetHesCodeByPhoneNumber(string PhoneNumber);
    public HesCode UpdateHesCode(int AccountId);
    public HesCode CreateHesCode(CreateHesCodeDTO createHesCodeDTO);
    public IEnumerable<HesCode> GetAllHesCodes();
}