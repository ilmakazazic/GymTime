namespace eTeretane.WebAPI.Services
{
    public interface ICRUDService<T, TSearch, TUpdate, TInsert> : IService<T, TSearch>
    {
        T Insert(TInsert request);
        T Update(int id, TUpdate request);
    }
}
