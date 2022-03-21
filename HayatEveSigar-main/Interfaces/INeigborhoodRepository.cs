
    public interface INeigborhoodRepository
    {
        Task<Neigborhood> CreateNeigborhood(Neigborhood Neigborhood);
        Task<Neigborhood> DeleteNeigborhood(string name);
        Task<List<Neigborhood>> GetAllNeigborhood();
        Task<Neigborhood> FindNeigborhoodByName(string NeigborhoodName);
        Task<Neigborhood> NeigborhoodEdit(Neigborhood Neigborhood);

    }
