
[ApiController]
[Route("[controller]")]
public class NeigborhoodController : ControllerBase
{
    private readonly INeigborhoodService _INeigborhoodService;
    private ResponseGeneratorHelper ResponseGeneratorHelper;

    public NeigborhoodController(INeigborhoodService INeigborhoodService)
    {
        _INeigborhoodService = INeigborhoodService;
        ResponseGeneratorHelper = new ResponseGeneratorHelper();
    }


    [HttpGet]
    public async Task<ActionResult<ServiceResponse<List<Neigborhood>>>> GetAllNeigborhood()
    {
        return await _INeigborhoodService.GetAllNeigborhood();
    }

    [HttpPost("CreateNeigborhood")]
    public async Task<ActionResult<ServiceResponse<Neigborhood>>> CreateNeigborhood(Neigborhood Neigborhood)
    {
        return await _INeigborhoodService.CreateNeigborhood(Neigborhood);

    }

    [HttpDelete("{Name}")]
    public async Task<ActionResult<ServiceResponse<Neigborhood>>> DeleteNeigborhood(string Name)
    {
        return await _INeigborhoodService.DeleteNeigborhood(Name);

    }

    [HttpPut]
    public async Task<ActionResult<ServiceResponse<Neigborhood>>> NeigborhoodEdit(Neigborhood Neigborhood)
    {
        return await _INeigborhoodService.NeigborhoodtEdit(Neigborhood);
    }

}



