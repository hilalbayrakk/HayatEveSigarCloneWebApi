
public interface INeigborhoodService
{
    Task<ServiceResponse<Neigborhood>> CreateNeigborhood(Neigborhood Neigborhood);
    Task<ServiceResponse<Neigborhood>> DeleteNeigborhood(string name);
    Task<ServiceResponse<List<Neigborhood>>> GetAllNeigborhood();
    Task<ServiceResponse<Neigborhood>> NeigborhoodtEdit(Neigborhood Neigborhood);

}
