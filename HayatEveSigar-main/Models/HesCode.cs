public class HesCode
{
    public int Id { get; set; }
    public string Code { get; set; }
    public int AccountId {get; set;}
    public virtual Account Account { get; set; }
    public HesCode()
    {
        
    }
    public HesCode(CreateHesCodeDTO createHesCodeDTO, HayatEveSigarContext _context)
    {
        Code = HesCodeRepository.HesCodeGenerator();
        while(_context.HesCodes.Any(x=>x.Code == Code))
        {
            Code = HesCodeRepository.HesCodeGenerator();
        }
        AccountId = createHesCodeDTO.AccountId;
    }
}