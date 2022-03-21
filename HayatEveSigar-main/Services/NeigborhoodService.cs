
public class NeigborhoodService : INeigborhoodService
{
    private NeigborhoodRepository _NeigborhoodRepository;
    public NeigborhoodService()
    {
        _NeigborhoodRepository = new NeigborhoodRepository();
    }

    public async Task<ServiceResponse<Neigborhood>> CreateNeigborhood(Neigborhood Neigborhood)
    {
        ServiceResponse<Neigborhood> response = new ServiceResponse<Neigborhood>();
        var IncomingNeigborhood = await _NeigborhoodRepository.FindNeigborhoodByName(Neigborhood.Name);
        if (IncomingNeigborhood == null)
        {
            await _NeigborhoodRepository.CreateNeigborhood(Neigborhood);
            response.ResponseCode = ResponseCodeEnum.CreateNeigborhoodOperationSuccess;
            response.Data = Neigborhood;
            return response;
        }
        else
        {
            response.ResponseCode = ResponseCodeEnum.CreateNeigborhoodOperationFail;
            return response;
        }
    }

    public async Task<ServiceResponse<Neigborhood>> DeleteNeigborhood(string name)
    {
        ServiceResponse<Neigborhood> response = new ServiceResponse<Neigborhood>();
        var IncomingNeigborhood = await _NeigborhoodRepository.FindNeigborhoodByName(name);
        if (IncomingNeigborhood != null)
        {
            await _NeigborhoodRepository.DeleteNeigborhood(name);
            response.ResponseCode = ResponseCodeEnum.DeleteNeigborhoodOperationSuccess;
            response.Data = IncomingNeigborhood;
            return response;
        }
        else
        {
            response.ResponseCode = ResponseCodeEnum.DeleteNeigborhoodOperationFail;
            response.Data = null;
            return response;
        }
    }

    public async Task<ServiceResponse<List<Neigborhood>>> GetAllNeigborhood()
    {
        ServiceResponse<List<Neigborhood>> response = new ServiceResponse<List<Neigborhood>>();
        try
        {
            response.Data = await _NeigborhoodRepository.GetAllNeigborhood();
            response.ResponseCode = ResponseCodeEnum.GetAllNeigborhoodOperationSuccess;
            return response;
        }
        catch (Exception e)
        {
            response.Data = null;
            response.ResponseCode = ResponseCodeEnum.GetAllNeigborhoodOperationFail;
            return response;
        }
    }

    public async Task<ServiceResponse<Neigborhood>> NeigborhoodtEdit(Neigborhood Neigborhood)
    {
        ServiceResponse<Neigborhood> response = new ServiceResponse<Neigborhood>();
        var editedNeigborhood = _NeigborhoodRepository.NeigborhoodEdit(Neigborhood);

        if (editedNeigborhood != null)
        {
            response.ResponseCode = ResponseCodeEnum.Success;
            response.Data = await editedNeigborhood;
            return response;
        }
        else
        {
            response.ResponseCode = ResponseCodeEnum.NeigborhoodEditOperationFail;
            return response;
        }
    }
}






