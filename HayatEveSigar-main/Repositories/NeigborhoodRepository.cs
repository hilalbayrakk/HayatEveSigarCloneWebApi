public class NeigborhoodRepository : INeigborhoodRepository
{
    DbContext _DbContext;

    public NeigborhoodRepository()
    {
        _DbContext = new HayatEveSigarContext();
    }

    public async Task<Neigborhood> CreateNeigborhood(Neigborhood Neigborhood)
    {
        await _DbContext.Set<Neigborhood>().AddAsync(Neigborhood);
        await _DbContext.SaveChangesAsync();
        return Neigborhood;
    }

    public async Task<Neigborhood> DeleteNeigborhood(string name)
    {
        var deletedNeigborhood = await _DbContext.Set<Neigborhood>().FirstOrDefaultAsync(x => x.Name == name);
        _DbContext.Set<Neigborhood>().Remove(deletedNeigborhood);
        _DbContext.SaveChangesAsync();
        return deletedNeigborhood;
    }

    public async Task<Neigborhood> FindNeigborhoodByName(string NeigborhoodName)
    {
        return await _DbContext.Set<Neigborhood>().FirstOrDefaultAsync(c => c.Name == NeigborhoodName);
    }

    public async Task<List<Neigborhood>> GetAllNeigborhood()
    {
        return await _DbContext.Set<Neigborhood>().ToListAsync();
    }
    public async Task<Neigborhood> NeigborhoodEdit(Neigborhood Neigborhood)
    {
        _DbContext.Set<Neigborhood>().Update(Neigborhood);
        _DbContext.SaveChangesAsync();
        return Neigborhood;
    }
}





