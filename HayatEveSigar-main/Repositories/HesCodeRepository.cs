using System;
using System.Drawing;
using System.Linq;
public class HesCodeRepository : IHesCodeRepository
{
    private readonly HayatEveSigarContext _hayatEveSigarContext;
    public HesCodeRepository(HayatEveSigarContext hayatEveSigarContext)
    {
        _hayatEveSigarContext = hayatEveSigarContext;
    }
    public HesCode GetHesCodeById(int ID)
    {
        return _hayatEveSigarContext.HesCodes.FirstOrDefault(x => x.Id == ID);
    }
    public HesCode GetHesCodeByPhoneNumber(string PhoneNumber)
    {
        return _hayatEveSigarContext.HesCodes.FirstOrDefault(x => x.Account.PhoneNumber == PhoneNumber);
    }
    public HesCode UpdateHesCode(int AccountId)
    {
        HesCode hesCode = _hayatEveSigarContext.HesCodes.FirstOrDefault(x => x.Account.Id == AccountId);
        if(hesCode == null) return null;
        string newHesCode = HesCodeRepository.HesCodeGenerator();
         while(_hayatEveSigarContext.HesCodes.Any(x=>x.Code == newHesCode))
        {
            newHesCode = HesCodeRepository.HesCodeGenerator();
        }
        hesCode.Code = newHesCode;
        _hayatEveSigarContext.SaveChanges();
        return hesCode;
    }
    public HesCode CreateHesCode(CreateHesCodeDTO createHesCodeDTO)
    {
        if(_hayatEveSigarContext.Accounts.Any(x=>x.Id != createHesCodeDTO.AccountId)) return null;
        HesCode hesCode = new HesCode(createHesCodeDTO, _hayatEveSigarContext);
        _hayatEveSigarContext.HesCodes.Add(hesCode);
        _hayatEveSigarContext.SaveChanges();
        return hesCode;
    }
    public IEnumerable<HesCode> GetAllHesCodes()
    {
        return _hayatEveSigarContext.HesCodes.ToList();
    }

    public static string HesCodeGenerator()
    {
        Random random = new Random();
        char harf1 = HesCodeRepository.GetRandomCharacter("QWERTYUIOPASDFGHJKLZXCVBNM", random);
        char harf2 = HesCodeRepository.GetRandomCharacter("QWERTYUIOPASDFGHJKLZXCVBNM", random);
        int number; string code = "";
        List<int> numberList = new List<int>();
        for (int i = 0; i < 8; i++)
        {
            number = random.Next(0, 10);
            numberList.Add(number);
        }
        code = harf1 + numberList[0] + harf2 + numberList[1] + "-";
        for (int i = 2; i < 8; i++)
        {
            code += numberList[i];
            if (i == 5) code += "-";
        }
        return code;
    }
    public static char GetRandomCharacter(string text, Random rng)
    {
        int index = rng.Next(text.Length);
        return text[index];
    }
}