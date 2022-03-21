public class HesCodeDTO
{
    public string Code { get; set; }
    public HesCodeDTO()
    {
        

    }

    public HesCodeDTO(HesCode hesCode)
    {
        Code = hesCode.Code;
    }
}